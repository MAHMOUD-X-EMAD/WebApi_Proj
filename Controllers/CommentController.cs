using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Angular_Proj.Repository;
using WebApplication1.Models;

namespace WebApi_Angular_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentRepository CommentRepository;
        public CommentController(ICommentRepository _commentRepository) 
        {
            CommentRepository = _commentRepository;
        }
        [HttpPost]
        public  IActionResult AddComment(Comment Comment)
        {
            CommentRepository.AddComment(Comment);
            return Ok("Does");
        }
        [HttpPut]
        public IActionResult UpdateComment(int CommentId , string  CommentContent)
        {
            CommentRepository.UpdateComment(CommentId, CommentContent);
            return Ok("Does :)");
        }
        [HttpDelete]
        public IActionResult DeleteComment(int CommentId)
        {
            CommentRepository.DeleteComment(CommentId);
            return Ok("Deleted");
        }
        [HttpGet("{PostId:int}")]
        public IActionResult GetAllCommentsInPost(int PostId)
        {
            
            return Ok(CommentRepository.GetComments(PostId));
        }


    }
}
