using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    public class DraftOrderInvoice : Parameterizable
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("bcc")]
        public IEnumerable<string> BCC { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("custom_message")]
        public string CustomMessage { get; set; }
    }
}