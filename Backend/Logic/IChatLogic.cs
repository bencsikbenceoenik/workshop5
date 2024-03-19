using Backend.Model;
using System.Collections.Generic;

namespace Backend.Logic
{
    public interface IChatLogic
    {
        public void Create(Chat item);

        public List<Chat> ReadAll();
    }
}
