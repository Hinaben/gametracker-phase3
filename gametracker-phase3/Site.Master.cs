using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gametracker_phase3
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Page.Title + " loaded...");
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // show the contoso content area
                    ContosoPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;
                }
                else
                {
                    // only show login and register
                    ContosoPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                }

            }
            SetActivePage();
        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
                case "Signup":
                    signup.Attributes.Add("class", "active");
                    break;
                case "Signin":
                    signin.Attributes.Add("class", "active");
                    break;
                case "Signout":
                    signin.Attributes.Add("class", "active");
                    break;

            }
        }
        //    private void changeNavWord() {
        //        switch (Page.Title)
        //        {
        //            case "Home":

        //                break;


        //        }
    }
}