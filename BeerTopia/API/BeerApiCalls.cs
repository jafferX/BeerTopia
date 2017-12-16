using System;

using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeerTopia.Models;

using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BeerTopia.API
{
    class BeerApiCalls
    {
        ApiManager httpCall = new ApiManager();

        public async void GetSampleBeers(ObservableCollection<Datum> observableCollection)
        {
            observableCollection.Clear();
            HttpClient client = httpCall.StartHTTP();
            var uri = new Uri(
                string.Format(
                    $"{ApiManager.apiURL}beers?key={ApiKey.BeerKey}&styleId=15"));
            var response = await client.GetAsync(uri);
            BeerDetailsModel beerData = null;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                beerData = BeerDetailsModel.FromJson(content);
            }
            for (int i = 0; i < beerData.Data.Length; i++)
            {
                observableCollection.Add(beerData.Data[i]);
              
            }
            
        }

        public async void GetBeerByName(ObservableCollection<Datum> observableCollection, string userInput)
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
                beerData = BeerDetailsModel.FromJson(content);
            }
            for(int i = 0; i < beerData.Data.Length;i++)
            {
                observableCollection.Add(beerData.Data[i]);
            }
            
        }


    }
}
