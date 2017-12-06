using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using BeerTopia.Models;
//
//    var data = BeerDetailsModel.FromJson(jsonString);
//
namespace BeerTopia.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class BeerDetailsModel
    {
        [JsonProperty("currentPage")]
        public long CurrentPage { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("numberOfPages")]
        public long NumberOfPages { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public long TotalResults { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("abv")]
        public string Abv { get; set; }

        [JsonProperty("available")]
        public Available Available { get; set; }

        [JsonProperty("availableId")]
        public long? AvailableId { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foodPairings")]
        public string FoodPairings { get; set; }

        [JsonProperty("glass")]
        public Category Glass { get; set; }

        [JsonProperty("glasswareId")]
        public long? GlasswareId { get; set; }

        [JsonProperty("ibu")]
        public string Ibu { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isOrganic")]
        public string IsOrganic { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameDisplay")]
        public string NameDisplay { get; set; }

        [JsonProperty("originalGravity")]
        public string OriginalGravity { get; set; }

        [JsonProperty("servingTemperature")]
        public string ServingTemperature { get; set; }

        [JsonProperty("servingTemperatureDisplay")]
        public string ServingTemperatureDisplay { get; set; }

        [JsonProperty("srm")]
        public Srm Srm { get; set; }

        [JsonProperty("srmId")]
        public long? SrmId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDisplay")]
        public string StatusDisplay { get; set; }

        [JsonProperty("style")]
        public Style Style { get; set; }

        [JsonProperty("styleId")]
        public long StyleId { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    public partial class Style
    {
        [JsonProperty("abvMax")]
        public string AbvMax { get; set; }

        [JsonProperty("abvMin")]
        public string AbvMin { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fgMax")]
        public string FgMax { get; set; }

        [JsonProperty("fgMin")]
        public string FgMin { get; set; }

        [JsonProperty("ibuMax")]
        public string IbuMax { get; set; }

        [JsonProperty("ibuMin")]
        public string IbuMin { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ogMin")]
        public string OgMin { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("srmMax")]
        public string SrmMax { get; set; }

        [JsonProperty("srmMin")]
        public string SrmMin { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    public partial class Srm
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Labels
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Available
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class BeerDetailsModel
    {
        public static BeerDetailsModel FromJson(string json) => JsonConvert.DeserializeObject<BeerDetailsModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BeerDetailsModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
