using WebApplication1.Models;

namespace WebApi_Angular_Proj.Repository
{
    public interface IPostRepository
    {

        public List<Post> GetPostsByUser(string Id);
        public List<Post> GetAllPosts();
        public void CreatePost(Post Post);
        public Post GetByPostId(int Id);

    }
}
