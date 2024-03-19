﻿using Backend.Model;
using System.Linq;

namespace Backend.Repository
{
    public class ChatRepository /*: Repository*/
    {
        protected ChatHistory ch;
        public ChatRepository(ChatHistory ch)
        {
            this.ch = ch;
        }

        public void Create(Chat item)
        {
            ch.chats.Add(item);
        }

        public IQueryable<Chat> ReadAll()
        {
            return (IQueryable<Chat>)ch.chats;
        }
    }
}
