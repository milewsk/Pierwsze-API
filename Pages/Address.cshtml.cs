using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;
using Pierwsze_API.Models;

namespace Pierwsze_API.Pages
{
    public class AddressModel : PageModel
    {
        public Address Address;

        public void OnGet()
        {
           var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
            {
                Address = JsonConvert.DeserializeObject<Address>(SessionAddress);
            }
        }
    }
}
