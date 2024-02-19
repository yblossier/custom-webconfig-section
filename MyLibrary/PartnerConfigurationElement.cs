using System.Configuration;

namespace MyLibrary
{
    /// <summary>
    /// The configuration element contains the configuration values of partner
    /// </summary>
    public class PartnerConfigurationElement : ConfigurationElement
    {
        /// <summary>
        /// Get or set the name of partner use as unique key
        /// </summary>
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        /// <summary>
        /// Get or set the status of availability of the identity provider
        /// </summary>
        [ConfigurationProperty("Enabled", DefaultValue = "false", IsRequired = false)]
        public bool Enabled
        {
            get { return (bool)this["Enabled"]; }
            set { this["Enabled"] = value; }
        }

        /// <summary>
        /// Get or set the identifier of customer for the partner usage
        /// </summary>
        [ConfigurationProperty("ClientId", IsRequired = false)]
        public string ClientId
        {
            get { return (string)this["ClientId"]; }
            set { this["ClientId"] = value; }
        }

        /// <summary>
        /// Get or set the secret key of customer for the partner usage
        /// </summary>
        [ConfigurationProperty("ClientSecret", IsRequired = false)]
        public string ClientSecret
        {
            get { return (string)this["ClientSecret"]; }
            set { this["ClientSecret"] = value; }
        }

        /// <summary>
        /// Get or set the parameters collection
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = false)]
        [ConfigurationCollection(typeof(KeyValueConfigurationCollection), AddItemName = "add")]
        public KeyValueConfigurationCollection Parameters
        {
            get { return (KeyValueConfigurationCollection)this[""]; }
            set { this[""] = value; }
        }
    }
}