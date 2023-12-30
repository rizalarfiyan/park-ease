using RestSharp;
using System.Text.Json.Serialization;

namespace ParkEase.Model.Entity
{
    public class BaseRequestPagination
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("search")]
        public string? Search { get; set; }

        [JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        [JsonPropertyName("order")]
        public string? Order { get; set; }

        public void Build(RestRequest req)
        {
            req.AddParameter("page", Page);
            req.AddParameter("limit", Limit);

            if (!string.IsNullOrEmpty(Search))
            {
                req.AddParameter("search", Search);
            }

            if (!string.IsNullOrEmpty(Order))
            {
                req.AddParameter("order", Order);
            }

            if (!string.IsNullOrEmpty(OrderBy))
            {
                req.AddParameter("order_by", OrderBy);
            }
        }
    }

    public class BaseRequestPagination<T> : BaseRequestPagination
    {
        [JsonPropertyName("aditional")]
        public T Additional { get; set; }
    }
}
