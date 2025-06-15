using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    String LogonUserID = Request.ServerVariables["LOGON_USER"].ToString().Substring(5);
        //    if (!String.IsNullOrEmpty(LogonUserID))
        //    {
        //        //LogonID.Text = "Logon ID: " + LogonUserID;

        //        //UserInfo UserInfoObj = new UserInfo();
        //        //String DisplayName = UserInfoObj.GetLoggedUserName(LogonUserID);
        //        //if (!String.IsNullOrEmpty(DisplayName))
        //        //    LogonID.Text = "Welcome " + DisplayName;
        //    }
        //}
    }
}
