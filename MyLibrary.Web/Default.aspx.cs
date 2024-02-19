using System;
using System.Configuration;
using System.Web.UI;

namespace MyLibrary.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMyCustomSectionParam1.Text = MyCustomSection.GetConfig().Settings["param1"].Value;
                lblMyCustomSectionParam2.Text = MyCustomSection.GetConfig().Settings["param2"].Value;

                lblMyPartnerSectionPartner1_Name.Text = PartnerConfigSection.GetConfig().Partners["Partner1"].Name;
                lblMyPartnerSectionPartner1_Param1.Text = PartnerConfigSection.GetConfig().Partners["Partner1"].Parameters["param1"].Value;
                lblMyPartnerSectionPartner1_Param2.Text = PartnerConfigSection.GetConfig().Partners["Partner1"].Parameters["url"].Value;

                lblMyPartnerSectionPartner2_Name.Text = PartnerConfigSection.GetConfig().Partners["Partner2"].Name;
                lblMyPartnerSectionPartner2_ClientId.Text = PartnerConfigSection.GetConfig().Partners["Partner2"].ClientId;
                lblMyPartnerSectionPartner2_ClientSecret.Text = PartnerConfigSection.GetConfig().Partners["Partner2"].ClientSecret;
                lblMyPartnerSectionPartner2_Param1.Text = PartnerConfigSection.GetConfig().Partners["Partner2"].Parameters["url"].Value;
            }
        }
    }
}