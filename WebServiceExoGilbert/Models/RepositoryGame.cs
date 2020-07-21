using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceExoGilbert.Models
{
    public class RepositoryGame
    {

        private readonly IMongoCollection<Player> _players;

        public RepositoryGame(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _players = database.GetCollection<Player>(settings.BooksCollectionName);
        }

        public List<Player> Get() =>
            _players.Find(player => true).ToList();

        public Player Get(string id) =>
            _players.Find<Player>(player => player.IdPlayer == id).FirstOrDefault();

        public Player Create(Player player)
        {
            _players.InsertOne(player);
            return player;
        }

        public void Update(string id, Player playerIn) =>
            _players.ReplaceOne(player => player.IdPlayer == id, playerIn);

        public void Remove(Player playerIn) =>
            _players.DeleteOne(player => player.IdPlayer == playerIn.IdPlayer);

        public void Remove(string id) =>
            _players.DeleteOne(player => player.IdPlayer == id);
    }
}

