using RestSharp;

namespace ParkEase.Model.Response
{
    public class BaseResponse<T>
    {
        public BaseResponse(RestResponse<BaseResponse<T>> res)
        {
            if (res.Data != null)
            {
                this.Code = res.Data.Code;
                this.Message = res.Data.Message;
                this.Data = res.Data.Data;
            }
        }

        public int Code { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }

        public bool IsErrorConfirmation()
        {
            int[] codes = { 400, 401, 403, 422 };
            return codes.Contains(this.Code);
        }
    }

    public class BaseResponsePagination<T> : BaseResponse<T>
    {
        public BaseResponsePagination(RestResponse<BaseResponse<T>> res) : base(res)
        {
        }

        public Metadata? Metadata { get; set; }
    }

    public partial class Metadata
    {
        public bool HasNext { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
    }
}
