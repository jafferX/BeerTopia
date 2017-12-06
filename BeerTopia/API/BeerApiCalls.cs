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
    class BeerApiCalls
    {
        ApiManager httpCall;

        async void GetSampleBeers(ObservableCollection<BeerDetailsModel> observableCollection)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{ApiManager.apiURL}beers?key={ApiKey.BeerKey}&styleId=15"));
            var response = await client.GetAsync(uri);
            BeerDetailsModel beerData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                beerData = null;
            }
            observableCollection.Add(beerData);
        }

        async void GetBeerByName(ObservableCollection<BeerDetailsModel> observableCollection, string userInput)
        {
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{ApiManager.apiURL}beers?key={ApiKey.BeerKey}&name={userInput}"));
            var response = await client.GetAsync(uri);
            BeerDetailsModel beerData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                beerData = null;
            }
            observableCollection.Add(beerData);
        }


    }
}
