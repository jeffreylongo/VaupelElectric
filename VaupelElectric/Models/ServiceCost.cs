using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaupelElectric.Models
{
    public class ServiceCost
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Price { get; set; }
    }
}