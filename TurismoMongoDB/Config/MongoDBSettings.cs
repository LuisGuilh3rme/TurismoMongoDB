﻿namespace TurismoMongoDB.Config
{
    public class MongoDBSettings : IMongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
