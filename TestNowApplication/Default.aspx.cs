using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //InitializeCulture();
        }

        protected void btnTestResource_Click(object sender, EventArgs e)
        {

        }
        //static string cultureName;

        //public static string CultureName
        //{
        //    get { return cultureName; }
        //    set { cultureName = value; }
        //}

        //protected override void InitializeCulture()
        //{
        //    Thread.CurrentThread.CurrentCulture =
        //        CultureInfo.CreateSpecificCulture(cultureName);
        //    Thread.CurrentThread.CurrentUICulture = new
        //        CultureInfo(cultureName);

        //    base.InitializeCulture();
        //}
        //protected void gvModels_RowDataBound(object sender,GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        CarModel cm = (CarModel)e.Row.DataItem;

        //        img.ImageUrl = String.Format("images/{0}.jpg",
        //       cm.ID);

        //    }
        //}
    }
}