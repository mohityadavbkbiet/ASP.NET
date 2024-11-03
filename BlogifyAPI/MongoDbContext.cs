using MongoDB.Driver;
using BlogifyAPI.Models;

namespace BlogifyAPI
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("test");
        }

        public IMongoCollection<BlogPost> BlogPosts => _database.GetCollection<BlogPost>("BlogPosts");
    }
}
