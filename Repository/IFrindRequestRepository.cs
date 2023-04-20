using WebApi_Angular_Proj.DTO;
using WebApi_Angular_Proj.Models;

namespace WebApi_Angular_Proj.Repository
{
    public interface IFrindRequestRepository
    {
        public void SendRequest(RequestDTO request);
        public void AcceptRequest(string UserId, string FrindId);
        public void RejectRequest(string UserId, string FrindId);

        public List<User> GetAllRequests(string id);
    }
}
