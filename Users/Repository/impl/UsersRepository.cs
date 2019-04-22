using Entities;
using LiteDB;
using System;
using System.IO;

namespace Repository
{
    public class UsersRepository : IUsersRepository
    {
        private const string COLLECTION = "Users";
        private const string SOURCE = @"Users.db";

        private MemoryStream mem = new MemoryStream();
        private bool _test = false;

        private LiteDatabase GetLiteDatabase() => _test ? new LiteDatabase(mem) : new LiteDatabase(SOURCE);


        public UsersRepository()
        {
            // TODO -> Call this(false)
            using (var db = new LiteDatabase(SOURCE))
            {
                if (!db.CollectionExists(COLLECTION))
                {
                    var col = db.GetCollection<User>(COLLECTION);
                    col.EnsureIndex(x => x.Id, true);
                    col.EnsureIndex(x => x.Username, true);
                }
            }
        }

        public UsersRepository(bool test)
        {
            _test = test;
            using (var db = GetLiteDatabase())
            {
                if (!db.CollectionExists(COLLECTION))
                {
                    var col = db.GetCollection<User>(COLLECTION);
                    col.EnsureIndex(x => x.Id, true);
                    col.EnsureIndex(x => x.Username, true);
                }
            }
        }

        public void Insert(User user)
        {
            throw new NotImplementedException();
        }

        public void Select(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
