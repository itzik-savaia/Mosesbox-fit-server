using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mosesbox_fit.Models
{
    public class MongoConnect : IMongoConnectSettings
    {
            public string UsersCollectionName { get; set; }
            public string ConnectionString { get; set; }
            public string DatabaseName { get; set; }

    }
    public interface IMongoConnectSettings
    {
        public string UsersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
