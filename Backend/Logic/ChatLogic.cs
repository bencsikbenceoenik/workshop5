using Backend.Model;
using Backend.Repository;
using System.Linq;

namespace Backend.Logic
{
    public class ChatLogic : IChatLogic
    {
        ChatRepository repo;

        public ChatLogic(ChatRepository repo)
        {
            this.repo = repo;
        }

        public void Create(Chat item)
        {
            repo.Create(item);
        }

        public IQueryable<Chat> ReadAll()
        {
            return repo.ReadAll();
        }
    }
}
