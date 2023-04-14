﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Angular_Proj.Repository;
using WebApplication1.Models;

namespace WebApi_Angular_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IPostRepository PostRepository;
        ICommentRepository CommentRepository;
        public PostController(IPostRepository _PostRepository, ICommentRepository _CommentRepository)
        {
            PostRepository = _PostRepository;
            CommentRepository = _CommentRepository;
        }
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            return Ok(PostRepository.GetAllPosts());
        }

        [HttpGet("{Id}")]
        public IActionResult GetPostByUserId(string Id)
        {
            return Ok(PostRepository.GetPostsByUser(Id));
        }


        [HttpGet("{Postid:int}")]
        public IActionResult GetPostById(int Postid)
        {

            return Ok(PostRepository.GetByPostId(Postid));
        }


        [HttpPost]
        public IActionResult CreatePost(Post Post)
        {
            PostRepository.CreatePost(Post);
            return Ok();
        }

    }
}
