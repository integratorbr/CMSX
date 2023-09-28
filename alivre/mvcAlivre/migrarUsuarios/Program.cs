using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using mvcAlivre.Models;
using System.Configuration;

namespace migrarUsuarios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            migraUser(args[0]);
        }

        public static void migraUser(string limiteMinimo)
        {
            ApplicationDbContext context = new mvcAlivre.Models.ApplicationDbContext();
            int limite = int.Parse(limiteMinimo);
            int count = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=177.70.98.16;Initial Catalog=cainaprova_1;User ID=cainaprova_1;Password=c3c1@2526"))
            {
                SqlCommand command = new SqlCommand("SELECT NomeUsuario,SenhaUsuario,CodUsuario,TipoUsuario,InstUsuario,CampUsuario from Usuario",connection);// Where CodUsuario='webmaster@aulalivre.com';",connection);
                //SqlCommand command = new SqlCommand("SELECT NomeUsuario,SenhaUsuario,CodUsuario,TipoUsuario,InstUsuario,CampUsuario from Usuario Where CodUsuario='webmaster@aulalivre.com';",connection);
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (count >= limite)
                        {
                            try
                            {
                                var userStore = new UserStore<ApplicationUser>(context);
                                var manager = new UserManager<ApplicationUser>(userStore);

                                var user = new ApplicationUser() { UserName = reader.GetString(2), Email = reader.GetString(2), NomeUsuario = reader.GetString(0), TipoUsuario = reader.GetInt16(3), InstId = reader.GetInt16(4), CampId = reader.GetInt16(5), EmailConfirmed = true };
                                string pss = reader.GetString(1);

                                manager.UserValidator = new UserValidator<ApplicationUser>(manager)
                                {
                                    AllowOnlyAlphanumericUserNames = false,
                                    RequireUniqueEmail = true
                                };

                                // Configure validation logic for passwords
                                manager.PasswordValidator = new PasswordValidator
                                {
                                    RequiredLength = 1,
                                    RequireNonLetterOrDigit = false,
                                    RequireDigit = false,
                                    RequireLowercase = false,
                                    RequireUppercase = false,
                                };

                                IdentityResult result = manager.Create(user, pss);
                                System.Console.WriteLine(result.Succeeded.ToString() + ":" + reader.GetString(2) + "--" + result.Errors.FirstOrDefault());
                            }
                            catch
                            {
                                System.Console.WriteLine("Erro ao processar o registro");
                            }
                        }
                        else 
                        {
                            count++;
                        }
                    }
                }
            }
        }
    }
}