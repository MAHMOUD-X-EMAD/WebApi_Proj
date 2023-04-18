
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Identity;
using System.Text;
using WebApi_Angular_Proj.Models;
namespace WebApi_Angular_Proj.Hubs
{
    public class CommentHub : Hub
    {

        
        Context context = new Context();
        private readonly UserManager<ApplicationUser> _userManager;

        public CommentHub(UserManager<ApplicationUser> userManager)
        {
            
            _userManager = userManager;
        }
        public void NewComment(string comment, int Tid, string UserName)
        {
            var currentUser = _userManager.Users.FirstOrDefault(c=> c.UserName == UserName);

            Clients.All.SendAsync("CommentAdded", UserName, comment,Tid);

            var date = DateTime.Now;

            /*Comment c = new Comment { Text = comment, TemplateId = Tid, username = UserName , Date =date,image= Encoding.Default.GetString(currentUser.image) };

            commentRepository.Insert(c, Tid);*/
            

        }

        

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
