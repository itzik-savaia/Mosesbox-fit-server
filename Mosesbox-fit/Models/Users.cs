using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Mosesbox_fit.Models
{
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime RegisterTime { get; set; }

        public Users()
        {
            if (RegisterTime == null)
                this.RegisterTime = DateTime.Now;

            
        }

    }
}
