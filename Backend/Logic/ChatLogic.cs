using Backend.Model;
using Backend.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Logic
{
    public class ChatLogic : IChatLogic
    {
        //collection
        List<Chat> ch;
        //ChatRepository repo;

        public ChatLogic()
        {
        }

        public void Create(Chat item)
        {
            ch = new List<Chat>();
            ch.Add(item);
            //repo.Create(item);
        }

        public List<Chat> ReadAll()
        {
            return ch;
        }
    }
}
