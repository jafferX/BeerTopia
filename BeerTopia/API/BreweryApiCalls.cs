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
    public class BreweryApiCalls
    {
        ApiManager httpCall;

        public async void GetSampleBreweryList(ObservableCollection<DatumB> collection)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                     $"{ApiManager.apiURL}breweries?key={ApiKey.BeerKey}&established=1992"));
            var response = await client.GetAsync(uri);
            Breweries brewData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                brewData = Breweries.FromJson(content); //from json function here
            }
            for (int i = 0; i < brewData.Data.Length; i++)
            {
                collection.Add(brewData.Data[i]);
            }
        }

        async void GetBreweryList (ObservableCollection<DatumB> collection, string breweryID)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{ApiManager.apiURL}brewery/{breweryID}?key={ApiKey.BeerKey}"));
            var response = await client.GetAsync(uri);
            Breweries brewData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                brewData = Breweries.FromJson(content); //from json function goes here
            }
            for (int i = 0; i < brewData.Data.Length; i++)
            {
                collection.Add(brewData.Data[i]);
            }
           // collection.Add(brewData);
        }
    }
}
