using System.Configuration;

namespace MyLibrary
{
    /// <summary>
    /// The configuration element collection contains all definitions
    /// </summary>
    public class PartnerConfigurationCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Manage the element described by the <paramref name="name"/>
        /// </summary>
        /// <param name="name">The key value of the element to retrieve in the collection</param>
        /// <returns>The configuration element found in the collection</returns>
        public new PartnerConfigurationElement this[string name]
        {
            get { return (PartnerConfigurationElement)this.BaseGet((object)name); }
            set { int index = -1; PartnerConfigurationElement configurationElement = (PartnerConfigurationElement)this.BaseGet((object)name); if (configurationElement != null) { index = this.BaseIndexOf(configurationElement); this.BaseRemoveAt(index); } this.BaseAdd(index, value); }
        }
        /// <summary>
        /// Create a new element in the collection
        /// </summary>
        /// <returns>The newly created element</returns>
        protected override ConfigurationElement CreateNewElement() { return new PartnerConfigurationElement(); }

        /// <summary>
        /// Get the key of the configuration element
        /// </summary>
        /// <param name="element">The configuration element</param>
        /// <returns>The configuration element key</returns>
        protected override object GetElementKey(ConfigurationElement element) { return ((PartnerConfigurationElement)element).Name; }
    }
}