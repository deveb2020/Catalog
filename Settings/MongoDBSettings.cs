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
        /// Connection string
        /// </summary>
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
