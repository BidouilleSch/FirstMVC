using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class GuestResponse
    {
        public string Nom { get; set; }
        public string Prenom { get; set;}
        public string Email { get; set;}
        public bool? presence {get;set;}
    }
}