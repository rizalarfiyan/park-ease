using ParkEase.Libs;
using ParkEase.Model.Entity;
using ParkEase.Model.Response;
using RestSharp;

namespace ParkEase.Model.Repository
{
    public class HistoryRepository
    {
        private RestClient _api;
        public HistoryRepository()
        {
            _api = new Api().Get();
        }

        public BaseResponse<BaseResponsePagination<History>>? GetAllHistory(BaseRequestPagination param)
        {
            var req = new RestRequest("/history", Method.Get);
            param.Build(req);
            var res = _api.Execute<BaseResponse<BaseResponsePagination<History>>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CreateEntryHistory(EntryHistoryRequest payload)
        {
            var req = new RestRequest("/history/entry", Method.Post);
            req.AddJsonBody<EntryHistoryRequest>(payload);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CreateExitHistory(ExitHistoryRequest payload)
        {
            var req = new RestRequest("/history/exit", Method.Post);
            req.AddJsonBody<ExitHistoryRequest>(payload);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CreateFineHistory(FineHistoryRequest payload)
        {
            var req = new RestRequest("/history/fine", Method.Post);
            req.AddJsonBody<FineHistoryRequest>(payload);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }

        public BaseResponse<string?>? CalculateHistory(CalculateHistoryRequest payload)
        {
            var req = new RestRequest("/history/calculate", Method.Post);
            req.AddJsonBody<CalculateHistoryRequest>(payload);
            var res = _api.Execute<BaseResponse<string?>?>(req);
            return res.Data;
        }
    }
}
