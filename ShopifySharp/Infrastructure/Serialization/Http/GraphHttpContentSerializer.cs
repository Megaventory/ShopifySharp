using System.Text;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Http;

public class GraphHttpContentSerializer(JsonSerializerOptions jsonSerializerOptions) : IHttpContentSerializer
{
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest)
    {
        var jsonData = new Dictionary<string, object>
        {
            { "query", graphRequest.Query },
            { "variables", graphRequest.Variables },
        };

        var jsonStr = JsonSerializer.Serialize(jsonData, jsonSerializerOptions);
        const string mediaType = "application/json";
        var content = new StringContent(jsonStr, Encoding.UTF8, mediaType);

        return content;
    }
}
