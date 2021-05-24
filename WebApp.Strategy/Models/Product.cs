using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Strategy.Models
{
    public class Product
    {

        [BsonId]
        [Key]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public string UserId { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }


    }
}
