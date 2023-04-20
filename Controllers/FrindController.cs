using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;
using WebApi_Angular_Proj.DTO;
using WebApi_Angular_Proj.Repository;

namespace WebApi_Angular_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "https://localhost:4200/", headers: "*", methods: "*")]
    public class FrindController : ControllerBase
    {
        IFrindRequestRepository FrindRequest;
        public FrindController(IFrindRequestRepository _frindRequestRepository)
        {
            FrindRequest = _frindRequestRepository;
        }
        [HttpPost("SendRequset")]
        public IActionResult SendRequest(RequestDTO request)
        {

            FrindRequest.SendRequest(request);
            return Ok();
        }

        [HttpPost("Accept")]
        public IActionResult AcceptRequest(RequestDTO requestDTO)
        {
            FrindRequest.AcceptRequest(requestDTO.FromId, requestDTO.ToId);
            return Ok();
        }

        [HttpPost("Reject")]
        public IActionResult RejectRequest(RequestDTO requestDTO)
        {
            FrindRequest.RejectRequest(requestDTO.FromId, requestDTO.ToId);
            return Ok();
        }

        [HttpGet("ToId")]
        public IActionResult GetRequest(string ToId)
        {
            return Ok(FrindRequest.GetAllRequests(ToId));
        }

    }
}
