using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RGRProject.Controllers
{
    [ApiController]
    public class APIController : Controller
    {
        [HttpGet]
        [Route("api/v1/GetPlaces")]
        public ActionResult<ApiAnswer<string>> GetPlaces()
        {
           return new ApiAnswer<string>(HttpContext.Response.StatusCode, "", "", "places");
        }

        [HttpGet]
        [Route("api/v1/GetPlace")]
        public ActionResult<ApiAnswer<int>> GetPlace(int id)
        {
            return new ApiAnswer<int>(HttpContext.Response.StatusCode, "", "", id);
        }

        [HttpPost]
        [Route("api/v1/BookPlace")]
        public ActionResult<ApiAnswer<string>> BookPlace([FromBody]string data)
        {
            return new ApiAnswer<string>(HttpContext.Response.StatusCode, "", "", data);
        }
    }

    [DataContract]
    public class ApiAnswer<T>
    {
        [DataMember]
        internal int RequestStatus;

        [DataMember]
        internal string RequestDescription;

        [DataMember]
        internal string News;

        [DataMember]
        internal T Data;

        public ApiAnswer(int requestStatus, string requestDescription, string news, T data)
        {
            RequestStatus = requestStatus;
            RequestDescription = requestDescription;
            News = news;
            Data = data;
        }
    }
}
