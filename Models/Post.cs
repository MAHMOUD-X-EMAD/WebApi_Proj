using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApi_Angular_Proj.Models;

namespace WebApplication1.Models
{
    public class Post
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public string PostContent { get; set; }
        public int Like { get; set; }
        public DateTime Created { get; set; }
        [JsonIgnore]
        public virtual User? User { get; set; }
 /*       [JsonIgnore]
        public virtual List<PostFiles> Files { get; set; }
        [JsonIgnore]
        public virtual List<Comment> Comments { get; set; }*/

    }
}
