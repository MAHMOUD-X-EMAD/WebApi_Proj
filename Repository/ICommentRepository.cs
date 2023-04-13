using WebApplication1.Models;

namespace WebApi_Angular_Proj.Repository
{
    public interface ICommentRepository
    {
        public List<Comment> GetComments(int PostId );
        public void AddComment (Comment Comment);
        public void UpdateComment (int CommentId, Comment Comment);
        public void DeleteComment (int CommentId);
    }
}
