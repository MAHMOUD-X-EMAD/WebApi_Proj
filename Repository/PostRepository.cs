﻿using Microsoft.EntityFrameworkCore;
using WebApi_Angular_Proj.DTO;
using WebApi_Angular_Proj.Models;
using WebApplication1.Models;

namespace WebApi_Angular_Proj.Repository
{
    public class PostRepository : IPostRepository
    {
        Context Context;
        public PostRepository(Context _context)
        {
            Context = _context;
        }
        public void CreatePost(CreatePostDTO PostDTO)
        {
            Post Post = new Post();
            Post.UserId = PostDTO.UserId;
            Post.PostContent = PostDTO.PostContent;
            Post.Like = 0;
            Post.Created = DateTime.Now;
            Context.Posts.Add(Post);
            Context.SaveChanges();
        }

        public List<Post> GetAllPosts()
        {
            return Context.Posts.Include(p => p.User).ToList();
        }

        public Post GetByPostId(int Id)
        {
            return Context.Posts.FirstOrDefault(p => p.Id == Id);

        }

        public List<Post> GetPostsByUser(string Id)
        {
            return Context.Posts.Where(p => p.UserId == Id).ToList();
        }
    }
}
