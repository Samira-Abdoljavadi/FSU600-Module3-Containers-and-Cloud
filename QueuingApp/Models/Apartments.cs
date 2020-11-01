using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Runtime.Serialization;

namespace QueuingApp.Models
{
    public class Apartments
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string objectId { get; set; }

        [Key]
        public int id { get; set; } 

        [BsonElement("Situation")]
        public string Situation { get; set; }

        [BsonElement("Street")]
        [Required]
        public string Street { get; set; }

        [BsonElement("Area")]
        [Display(Name = "Zone")]
        public string Area { get; set; }

        [BsonElement("City")]
        [Required]
        public string City { get; set; }

        [BsonElement("Rooms")]
        [Required]
        public int Rooms { get; set; }

        [BsonElement("SquareMeters")]
        [Display(Name = "Area")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:#,0}")]
        public decimal SquareMeters { get; set; }

        [BsonElement("Rent")]
        [Required]
        public int Rent { get; set; }

        [BsonElement("MoveInDate")]
        [Display(Name = "Move in Date")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //To remove time from display
        public DateTime MoveInDate { get; set; }

        [BsonElement("Floor")]
        [Required]
        public int Floor { get; set; }

        [BsonElement("WholeFloor")]
        [Display(Name = "Whole Floor")]
        public int WholeFloor { get; set; }

        [BsonElement("PublishDate")]
        [Display(Name = "Publish Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")] //To remove time from display
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [BsonElement("Pets")]
        public string Pets { get; set; }

        [BsonElement("Smoke")]
        public string Smoke { get; set; }

        [BsonElement("LandlordComments")]
        [Display(Name = "Landlord Comments")]
        public string LandlordComments { get; set; }

        [BsonElement("Properties")]
        public string Properties { get; set; }

        [BsonElement("RentInclude")]
        [Display(Name = "Rent Include")]
        public string RentInclude { get; set; }

        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

    }
}
