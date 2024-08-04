﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using CerebellumRestLib.Models.Base;
using CerebellumRestLib.Models.JSON.Entities;
using Newtonsoft.Json;

namespace CerebellumRestLib.Models.JSON.Requests
{
    public class CreateTaskUnitRequest : JsonBase
    {
        [JsonProperty("action")]
        public string Action => "put";

        [JsonProperty("values")]
        public TaskUnitEdit TaskUnit { get; set; }

        [JsonProperty("point")]
        public double[] Point { get; set; }
    }
}