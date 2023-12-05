using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;

namespace BarbAgenda.Infrastructure
{
    public class UserRepository
    {
        public readonly BarbAgendaDbContext _barbAgendaDbContext;

        public UserRepository(BarbAgendaDbContext barbAgendaDbContext)
        {
            _barbAgendaDbContext = barbAgendaDbContext;
        }

        public bool Add(User user)
        {
            _barbAgendaDbContext.Add(user);
            var result = _barbAgendaDbContext.SaveChanges();

            if (result <= 0)
            {
                return false;
            }

            return true;
        }

        public bool Login(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            
            bool userExists = _barbAgendaDbContext.Users.Any(user =>
                    user.Nome.Equals(name) &&
                    user.Password.Equals(password));

            return userExists;
        }
    }
}
