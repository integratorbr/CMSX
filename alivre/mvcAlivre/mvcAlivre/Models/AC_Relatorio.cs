//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcAlivre.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AC_Relatorio
    {
        public int Codigo { get; set; }
        public Nullable<int> Aluno { get; set; }
        public Nullable<int> Atividade { get; set; }
        public Nullable<int> Turma { get; set; }
        public string Texto { get; set; }
        public Nullable<bool> Exposicao { get; set; }
        public string Artista { get; set; }
        public Nullable<System.DateTime> DtInicio { get; set; }
        public Nullable<System.DateTime> DtFim { get; set; }
        public string Museu { get; set; }
        public Nullable<System.DateTime> DtRealiza { get; set; }
        public Nullable<short> Status { get; set; }
        public string NovoTexto { get; set; }
    }
}
