using MongoDB.Driver;

namespace CRMApp.Models
{
    public class CRMAppContext
    {
        private readonly IMongoDatabase _database;

        public CRMAppContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("test");
        }

        public IMongoCollection<Customer> Customers => _database.GetCollection<Customer>("Customers");
    }
}
