using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography;
using WebApi_Angular_Proj.Models;
using WebApplication1.Models;

namespace WebApi_Angular_Proj.Hubs
{
    public class PostHub : Hub
    {
        Context context = new Context();
        private readonly UserManager<ApplicationUser> _userManager;

        public PostHub(UserManager<ApplicationUser> userManager)
        {

            _userManager = userManager;
        }
        public void NewPost(string content, User user)
        {/*
            var currentUser = _userManager.Users.FirstOrDefault(c => c.UserName == UserName);

            Clients.All.SendAsync("PostAdded", UserName, comment, Tid);

            var date = DateTime.Now;

            *//*Comment c = new Comment { Text = comment, TemplateId = Tid, username = UserName , Date =date,image= Encoding.Default.GetString(currentUser.image) };

            commentRepository.Insert(c, Tid);*/


        }



        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}

