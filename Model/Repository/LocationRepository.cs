using ParkEase.Libs;
using ParkEase.Model.Entity;
using ParkEase.Model.Response;
using RestSharp;


namespace ParkEase.Model.Repository;

public class LocationRepository
{
    private RestClient _api;
    
    public LocationRepository()
    {
        _api = new Api().Get();
    }
    
    public BaseResponse<BaseResponsePagination<Location>>? GetAllLocation(BaseRequestPagination<LocationFilterRequest> param)
    {
        var req = new RestRequest("/location", Method.Get);
        param.Build(req);
        if (param?.Additional?.IsExit != null)
        {
            req.AddParameter("is_exit", (bool)param.Additional.IsExit ? "true" : "false");
        }
        var res = _api.Execute<BaseResponse<BaseResponsePagination<Location>>?>(req);
        return res.Data;
    }
    
    public BaseResponse<Location>? GetLocationByCode(string code)
    {
        var req = new RestRequest("/location/{code}", Method.Get);
        req.AddUrlSegment("code", code);
        var res = _api.Execute<BaseResponse<Location>?>(req);
        return res.Data;
    }
    
    public BaseResponse<string?>? CreateLocation(Location payload)
    {
        var req = new RestRequest("/location", Method.Post);
        req.AddJsonBody(new
        {
            name = payload.Name,
            code = payload.Code,
            is_exit = payload.IsExit,
        });
        var res = _api.Execute<BaseResponse<string?>?>(req);
        return res.Data;
    }
    
    public BaseResponse<string?>? UpdateLocation(Location payload)
    {
        var req = new RestRequest("/location/{code}", Method.Put);
        req.AddUrlSegment("code", payload.Code);
        req.AddJsonBody(new
        {
            name = payload.Name,
            is_exit = payload.IsExit,
        });
        var res = _api.Execute<BaseResponse<string?>?>(req);
        return res.Data;
    }
    
    public BaseResponse<string?>? DeleteLocation(string code)
    {
        var req = new RestRequest("/location/{code}", Method.Delete);
        req.AddUrlSegment("code", code);
        var res = _api.Execute<BaseResponse<string?>?>(req);
        return res.Data;
    }
}