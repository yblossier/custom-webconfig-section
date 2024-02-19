using System.Configuration;

namespace MyLibrary
{
    public class MyCustomSection : ConfigurationSection 
    { 
        public static MyCustomSection GetConfig()
        {
            return (MyCustomSection)ConfigurationManager.GetSection(SectionName) ?? new MyCustomSection();
        }

        /// <summary>
        /// The string name of the section in the configuration file as defined in its XML schema
        /// </summary>
        public const string SectionName = "mySection";
        
        [System.Configuration.ConfigurationProperty("", IsDefaultCollection = true, IsRequired = false)]
        [ConfigurationCollection(typeof(KeyValueConfigurationCollection), AddItemName = "add")]
        public KeyValueConfigurationCollection Settings { 
            get { 
                var o = this[""];
                return o as KeyValueConfigurationCollection;
            } 
        }
    }
}
