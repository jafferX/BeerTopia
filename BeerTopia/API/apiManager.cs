using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeerTopia.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BeerTopia.API
{
    class ApiManager
    {
        public const string apiURL = "http://api.brewerydb.com/v2/";

       public HttpClient StartHTTP()
        {
            HttpClient client = new HttpClient();
            return client;
        }

    }
}
