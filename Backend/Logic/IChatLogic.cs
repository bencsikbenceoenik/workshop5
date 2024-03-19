using Backend.Model;
using System.Linq;

namespace Backend.Logic
{
    public interface IChatLogic
    {
        public void Create(Chat item);

        public IQueryable<Chat> ReadAll();
    }
}
