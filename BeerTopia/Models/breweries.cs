using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BeerTopia.Models
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using breweriesDataModel;
    //
    //    var data = Breweries.FromJson(jsonString);
    //
        public partial class Breweries
        {
            [JsonProperty("currentPage")]
            public long CurrentPage { get; set; }

            [JsonProperty("numberOfPages")]
            public long NumberOfPages { get; set; }

            [JsonProperty("totalResults")]
            public long TotalResults { get; set; }

            [JsonProperty("data")]
            public DatumB[] Data { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }

        public partial class DatumB
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("nameShortDisplay")]
            public string NameShortDisplay { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("website")]
            public string Website { get; set; }

            [JsonProperty("established")]
            public string Established { get; set; }

            [JsonProperty("isOrganic")]
            public string IsOrganic { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("statusDisplay")]
            public string StatusDisplay { get; set; }

            [JsonProperty("createDate")]
            public string CreateDate { get; set; }

            [JsonProperty("updateDate")]
            public string UpdateDate { get; set; }

            [JsonProperty("isMassOwned")]
            public string IsMassOwned { get; set; }

            [JsonProperty("brandClassification")]
            public string BrandClassification { get; set; }

            [JsonProperty("images")]
            public Images Images { get; set; }

            [JsonProperty("mailingListUrl")]
            public string MailingListUrl { get; set; }
        }

        public partial class Images
        {
            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("medium")]
            public string Medium { get; set; }

            [JsonProperty("large")]
            public string Large { get; set; }

            [JsonProperty("squareMedium")]
            public string SquareMedium { get; set; }

            [JsonProperty("squareLarge")]
            public string SquareLarge { get; set; }
        }

        public partial class Breweries
        {
            public static Breweries FromJson(string json) => JsonConvert.DeserializeObject<Breweries>(json, ConverterB.Settings);
        }

        public static class SerializeB
        {
            public static string ToJson(this Breweries self) => JsonConvert.SerializeObject(self, ConverterB.Settings);
        }

        public class ConverterB
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    

}
