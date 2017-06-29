using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VaupelElectric.Models;

namespace VaupelElectric.ViewModels
{
    public class ServicesViewModel
    {
        public IEnumerable<HomeService> HomeServices { get; set; }
        public IEnumerable<CommercialService> CommercialServices { get; set; }
    }
}