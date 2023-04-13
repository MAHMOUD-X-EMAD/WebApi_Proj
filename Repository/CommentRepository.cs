using WebApi_Angular_Proj.Models;
using WebApplication1.Models;

namespace WebApi_Angular_Proj.Repository
{
    public class CommentRepository : ICommentRepository
    {
        Context Context;
        public CommentRepository(Context _context)
        {
            Context = _context;
        }

        public void AddComment(Comment Comment)
        {
            Context.Comments.Add(Comment);
            Context.SaveChanges();
        }

        public void DeleteComment(int CommentId)
        {
            Comment Comment = Context.Comments.FirstOrDefault(c => c.Id == CommentId);
            Context.Comments.Remove(Comment);
            Context.SaveChanges();
        }

        public List<Comment> GetComments(int PostId)
        {
            return Context.Comments.Where(c => c.PostId == PostId).ToList();
        }

        public void UpdateComment(int CommentId, Comment NewComment)
        {
            Comment Comment = Context.Comments.FirstOrDefault(c => c.Id == CommentId);
            Comment.Content = NewComment.Content;
            Comment.Updated = true;
            Context.SaveChanges();
        }
    }
}
