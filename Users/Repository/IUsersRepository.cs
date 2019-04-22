using Entities;

namespace Repository
{
    public interface IUsersRepository
    {
        void Insert(User user);

        void Select(long id);

        void Update(User user);

        void Delete(long id);
    }
}