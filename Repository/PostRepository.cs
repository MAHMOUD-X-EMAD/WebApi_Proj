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
        public void CreatePost(Post Post)
        {
            Context.Add(Post);
            Context.SaveChanges();
        }

        public List<Post> GetAllPosts()
        {
            return Context.Posts.ToList();
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
