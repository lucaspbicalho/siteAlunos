﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using MySql.Data.MySqlClient;
using System;
using System.Web;
using System.Web.UI;
using WebSite1;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
		Boolean verificalogin = false;
		string usuario="";
		string senha = "";
		string nome = "";
		string tipo = "";
		Conector c = new Conector();
		c.open();
		MySqlDataReader datareader =c.doquery("select * from users where login ='" + UserName.Text + "' and senha = '"+ Password.Text+"'");
		if (datareader.HasRows)
		{
			verificalogin = true;
			while (datareader.Read())
			{
				usuario = datareader.GetString("login");
				senha = datareader.GetString("senha");
				nome = datareader.GetString("nome");
				tipo = datareader.GetString("tipousuario");
			}
		}
		if (verificalogin)
		{
			//var manager = new UserManager();
			//ApplicationUser user = manager.Find(UserName.Text, Password.Text);
			//IdentityHelper.SignIn(manager, user, RememberMe.Checked);
			//IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
			string currentURL = HttpContext.Current.Request.Url.AbsoluteUri;
			currentURL = currentURL.Substring(0, currentURL.LastIndexOf("/"));
			currentURL = currentURL.Substring(0, currentURL.LastIndexOf("/"));
			currentURL = currentURL + @"/Table.aspx";
			Response.Redirect(currentURL);
		}
		else
		{
			FailureText.Text = "Invalid username or password.";
			ErrorMessage.Visible = true;
		}


		//if (IsValid)
		//{
		//    // Validate the user password
		//    var manager = new UserManager();
		//    ApplicationUser user = manager.Find(UserName.Text, Password.Text);
		//    if (user != null)
		//    {
		//        IdentityHelper.SignIn(manager, user, RememberMe.Checked);
		//        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
		//    }
		//    else
		//    {
		//        FailureText.Text = "Invalid username or password.";
		//        ErrorMessage.Visible = true;
		//    }
		//}           
	}
}