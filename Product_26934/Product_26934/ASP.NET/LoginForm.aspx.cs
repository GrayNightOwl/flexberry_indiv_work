namespace ICSSoft.STORMNET.Web
{
    using System;
    using System.Web;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using ICSSoft.STORMNET.Web.AjaxControls.Forms;
    using ICSSoft.STORMNET.Web.Tools;

    using NewPlatform.Flexberry.Web.Themeable;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Class of user login form.
    /// </summary>
    public partial class LoginForm : BasePage
    {
        protected override void OnInit(EventArgs e)
        {

            ThemeService.Current.Theme = "BlueSky";
            base.OnInit(e);
        }
    }
}
