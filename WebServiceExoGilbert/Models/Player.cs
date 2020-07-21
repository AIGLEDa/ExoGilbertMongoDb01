using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebServiceExoGilbert.Models
{
    public class Player
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdPlayer { get; set; }

        public int Id_player { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Skills { get; set; }
        public string injuries { get; set; }
        public bool Captain { get; set; }
        public int Id_team { get; set; }

    }
}
