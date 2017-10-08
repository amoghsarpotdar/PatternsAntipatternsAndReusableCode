using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageController
{
    /// <summary>
    /// This is our base implementation. Notice how it uses ASP.Net's framework features like events to control the
    /// execution of thelflow. This is a standard design pattern used in hundreads of web forms applications, howeber
    /// it imposes certain limitations -
    /// 1. Unit testing becomes very difficult task.
    /// 2. Inheritance plays a major part in this type of implementation.
    /// - For example, unit testing business logic is pretty much impossible as 
    /// 
    /// 
    /// </summary>
    public class TheRootPage1 : Page
    {
        protected Label eMail;
        protected Label siteName;

        virtual protected void PageLoadEvent(object sender, System.EventArgs e)
        { }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = Context.User.Identity.Name;

                eMail.Text = DatabaseGateway.RetrieveAddress(name);
                siteName.Text = "Micro-site";

                PageLoadEvent(sender, e);
            }
        }

        override protected void OnInit(EventArgs e)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.Page_Load);
        }
    }
}