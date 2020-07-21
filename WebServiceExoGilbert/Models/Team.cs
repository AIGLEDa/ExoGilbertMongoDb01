using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebServiceExoGilbert.Models
{
    public class Team
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdTeam { get; set; }

        public int Id_team { get; set; }

        [BsonElement("Name")]
        public string Team_name { get; set; }

        public string City { get; set; }
        public int Captain { get; set; }
        public int[] Id_player { get; set; }



    }
}
