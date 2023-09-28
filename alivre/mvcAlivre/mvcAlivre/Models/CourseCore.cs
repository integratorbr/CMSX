using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace mvcAlivre.Models
{
    public class CourseCore
    {
        #region properties
        public virtual Instituicao inst { get; set; }
        public virtual Campus camp { get; set; }
        public virtual Turma turm { get; set; }
        public virtual Curso curs { get; set; }
        public virtual Disciplina disc { get; set; }
        public virtual Usuario us { get; set; }
        public virtual Texto text { get; set; }
        #endregion  

        #region methods

        #endregion
    }
}