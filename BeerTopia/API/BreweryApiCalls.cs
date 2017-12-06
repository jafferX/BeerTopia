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
    class BreweryApiCalls
    {
        ApiManager httpCall;

        async void GetSampleBreweryList(ObservableCollection<Brewery> collection)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                     $"{ApiManager.apiURL}breweries?key={ApiKey.BeerKey}&established=1992"));
            var response = await client.GetAsync(uri);
            Brewery brewData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                brewData = null; //from json function here
            }
            collection.Add(brewData);
        }

        async void GetBreweryList (ObservableCollection<Brewery> collection, string breweryID)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{ApiManager.apiURL}brewery/{breweryID}?key={ApiKey.BeerKey}"));
            var response = await client.GetAsync(uri);
            Brewery brewData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                brewData = null; //from json function goes here
            }
            collection.Add(brewData);
        }
    }
}
