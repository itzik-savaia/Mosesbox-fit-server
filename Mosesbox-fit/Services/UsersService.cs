using MongoDB.Driver;
using Mosesbox_fit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mosesbox_fit.Services
{
    public class UsersService
    {
        private readonly IMongoCollection<Users> _users;

        public UsersService(IMongoConnectSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<Users>(settings.UsersCollectionName);
        }

        public async Task<List<Users>> GetAllAsync()
        {
            var users = await _users.Find(m => true).ToListAsync();
            if (users.Count != 0)
                return users;
            else return users;
        }

        public async Task<Users> CreateAsync(Users users)
        {
            await _users.InsertOneAsync(users);
            return users;
        }

    }
}
