using Backend.Model;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Repository
{
    public class ChatRepository : IRepository<Chat>
    {
        public List<Chat> ch;
        public ChatRepository(List<Chat> ch)
        {
            this.ch = ch;
        }

        public void Create(Chat item)
        {
            ch.Add(item);
        }

        public IQueryable<Chat> ReadAll()
        {
            return ch.AsQueryable();
        }
    }
}
