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
    
    public partial class Amigo
    {
        public int NumAmigo { get; set; }
        public string NomeAmigo { get; set; }
        public string EmailAmigo { get; set; }
        public Nullable<int> NumUsuario { get; set; }
        public Nullable<System.DateTime> DtIndicacao { get; set; }
        public Nullable<System.DateTime> DtLeitura { get; set; }
        public Nullable<bool> LeuEmail { get; set; }
    }
}
