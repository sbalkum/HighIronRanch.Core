using System;
using Newtonsoft.Json;

namespace HighIronRanch.Core.Repositories
{
    public interface IViewModel
    {
        [JsonProperty("id")]
        Guid Id { get; set; }
    }
}
