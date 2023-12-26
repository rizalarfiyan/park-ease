using System.Text.Json.Serialization;

namespace ParkEase.Model.Response
{
    public class BaseResponse<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public required string Message { get; set; }

        [JsonPropertyName("data")]
        public T? Data { get; set; }

        public bool IsErrorConfirmation()
        {
            int[] codes = { 400, 401, 403, 422 };
            return codes.Contains(this.Code);
        }
    }

    public class BaseResponsePagination<T> : BaseResponse<T>
    {

        [JsonPropertyName("metadata")]
        public required Metadata Metadata { get; set; }
    }

    public partial class Metadata
    {
        [JsonPropertyName("has_next")]
        public bool HasNext { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
