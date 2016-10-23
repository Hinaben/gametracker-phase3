using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace gametracker_phase3
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // create a new user object for game tracker
            var user = new IdentityUser()
            {
                UserName = UserNameTextBox.Text,
                PhoneNumber = ContactNumberTextBox.Text,
                Email = EmailTextBox.Text
            };

            // create a new user in the db and store the results
            IdentityResult result = userManager.Create(user, PasswordTextBox.Text);

            // check if successfully registered?
            if (result.Succeeded)
            {
                // authenticate and login our new user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // sign in the user
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);

                // Redirect to the sign in page
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                // display error in the AlertFlash div
                StatusLabel.Text = result.Errors.FirstOrDefault();
                AlertFlash.Visible = true;
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the home page
            Response.Redirect("~/Default.aspx");
        }
    }
}