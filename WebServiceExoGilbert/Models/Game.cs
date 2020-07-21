using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebServiceExoGilbert.Models
{
    public class Game
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdGame { get; set; }

        [BsonElement("Name")]
        public string Host_team { get; set; }
        public string Guest_team { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }


    }
}
