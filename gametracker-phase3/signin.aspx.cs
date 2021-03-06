﻿using System;
using System.Collections.Generic;
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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SigninButton_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // search for and create a new user object
            var user = userManager.Find(UserNameTextBox.Text, PasswordTextBox.Text);

            // if a match is found for the user
            if (user != null)
            {
                // authenticate and login our user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // sign in the user
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                // redirect the user to the main menu
                Response.Redirect("~/Default.aspx");
            }
            else // user is not found
            {
                SigninFailedLabel.Text = "Invalid Username or Password";
                AlertFlash.Visible = true;
            }
        }
    }
}