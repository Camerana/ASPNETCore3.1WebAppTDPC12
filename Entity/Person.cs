using System;

namespace TDPC12_ASPNETCore3._1WebAppMVC.Entity
{
    public class Person
    {
        public Guid? ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public decimal? Stipendio { get; set; }
    }
}
