using System;
using System.Collections.Generic;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using CMSXBLL.Repositorio;
using CMSXDB;

namespace CMSXBLL
{
    public class Aplicacao:aplicacao
    {
        public Guid AplicacaoId { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public string ImagemUrl { get; set; }
        public string DataFinal { get; set; }
        public string PagSeguroToken { get; set; }
        public string Layout { get; set; }
        public int LayoutType { get; set; }
        public List<string> socialmedia { get; set; }
        public string header { get; set; }
        public static Aplicacao ObterAplicacao()
        {
            return new Aplicacao();
        }
    }
}
