using Backend.Model;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class ChatHistory
    {
        public List<Chat> chats;
        public ChatHistory(List<Chat> chats)
        {
            chats = new List<Chat>();
        }
    }
}
