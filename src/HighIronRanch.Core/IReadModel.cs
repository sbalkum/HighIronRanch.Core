using System;
using Newtonsoft.Json;

namespace HighIronRanch.Core
{
	public interface IReadModel
	{
		[JsonProperty("id")]
		Guid Id { get; set; }
	}
}
