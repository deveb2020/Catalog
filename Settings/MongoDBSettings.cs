namespace Catalog.Settings
{
    /// <summary>
    /// Classe Setting MongoDB
    /// </summary>
    public class MongoDBSettings
    {
        /// <summary>
        /// Host name
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port number
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// User name DB
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Password DB
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Connection string
        /// </summary>
        public string ConnectionString => $"mongodb://{User}:{Password}@{Host}:{Port}";
    }
}
