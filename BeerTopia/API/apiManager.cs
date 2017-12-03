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
        private string apiURL = "http://api.brewerydb.com/v2/";

        HttpClient StartHTTP()
        {
            HttpClient client = new HttpClient();
            return client;
        }

        async void GetSampleBeers (ObservableCollection<Beer> observableCollection)
        {
            HttpClient client = StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{apiURL}beers?key={ApiKey.BeerKey}&styleId=15"));
            var response = await client.GetAsync(uri);
            Beer beerData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                beerData = null;
            }
            observableCollection.Add(beerData);
        }

        async void GetBeerByName(ObservableCollection<Beer> observableCollection, string userInput)
        {
            HttpClient client = StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{apiURL}beers?key={ApiKey.BeerKey}&name={userInput}"));
            var response = await client.GetAsync(uri);
            Beer beerData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                beerData = null;
            }
            observableCollection.Add(beerData);
        }

    }
}
