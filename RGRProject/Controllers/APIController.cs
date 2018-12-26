using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RGRProject.Models;

namespace RGRProject.Controllers
{
    [ApiController]
    public class APIController : Controller
    {
        private readonly DatabaseContext _context;

        public APIController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/v1/GetPlaces")]
        public ActionResult<ApiAnswer<List<Place>>> GetPlaces()
        {
            try
            {
                using (_context)
                {
                    var res = _context.Places.ToList();
                    var response = new ApiAnswer<List<Place>>(HttpContext.Response.StatusCode, "", "", res);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var response = new ApiAnswer<List<Place>>(500, ex.Message, "", new List<Place>());
                return response;
            }
        }

        [HttpGet]
        [Route("api/v1/GetPlace")]
        public ActionResult<ApiAnswer<Place>> GetPlace(int id)
        {
            try
            {
                using (_context)
                {
                    var res = _context.Places.Where(place => place.ID == id).FirstOrDefault();
                    var response = new ApiAnswer<Place>(HttpContext.Response.StatusCode, "", "", res);
                    return response;
                }
            }
            catch (Exception ex)
            {
                var response = new ApiAnswer<Place>(500, ex.Message, "", null);
                return response;
            }
        }

        [HttpPost]
        [Route("api/v1/BookPlace")]
        public ActionResult<ApiAnswer<Booking>> BookPlace([FromBody]Booking data)
        {
            try
            {
                using (_context)
                {
                    _context.Bookings.Add(data);
                    _context.SaveChanges();
                    return new ApiAnswer<Booking>(200, "", "", data);
                }
            }
            catch (Exception ex)
            {
                var response = new ApiAnswer<Booking>(500, ex.Message, "", null);
                return response;
            }
        }
    }

    [DataContract]
    public class ApiAnswer<T>
    {
        [DataMember]
        public int RequestStatus;

        [DataMember]
        public string RequestDescription;

        [DataMember]
        public string News;

        [DataMember]
        public T Data;

        public ApiAnswer(int requestStatus, string requestDescription, string news, T data)
        {
            RequestStatus = requestStatus;
            RequestDescription = requestDescription;
            News = news;
            Data = data;
        }
    }
}
