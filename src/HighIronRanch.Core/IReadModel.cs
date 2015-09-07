using System;
using Newtonsoft.Json;

namespace HighIronRanch.Core
{
    [Obsolete("Use IViewModel instead")]
	public interface IReadModel
	{
		[JsonProperty("id")]
		Guid Id { get; set; }
	}
}
