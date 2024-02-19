using System.Configuration;

namespace MyLibrary
{
    /// <summary>    
    /// The configuration section class determines the partners configuration elements
    /// </summary>
    public class PartnerConfigSection : ConfigurationSection
    {
        public static PartnerConfigSection GetConfig()
        {
            return (PartnerConfigSection)ConfigurationManager.GetSection(SectionName) ?? new PartnerConfigSection();
        }

        /// <summary>
        /// The string name of the section in the configuration file as defined in its XML schema
        /// </summary>
        public const string SectionName = "partnerConfig";

        /// <summary>
        /// The XML namespace. Used to solve live compilation issue
        /// </summary>
        [ConfigurationProperty("xmlns", IsRequired = false)]
        public string XmlNamespace
        {
            get { return (string)this["xmlns"]; }
            set { this["xmlns"] = value; }
        }

        /// <summary>
        /// The name of partners group
        /// </summary>
        [ConfigurationProperty("name", IsRequired = false)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        /// <summary>
        /// The partner configuration to use it(s) service(s)
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = false)]
        [ConfigurationCollection(typeof(PartnerConfigurationElement), AddItemName = "partner")]
        public PartnerConfigurationCollection Partners
        {
            get { return (PartnerConfigurationCollection)this[""]; }
        }
    }
}