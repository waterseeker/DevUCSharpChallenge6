using DevUCSharpChallenge6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpChallenge6
{
    
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //need to store an array of agents with name, # of elections rigged, and # of acts of subterfuge preformed
            if (!Page.IsPostBack)
            {
                Asset[] assets = new Asset[0];
                ViewState.Add("Assets", assets);
                assets.ActsOfSubterfuge
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            Asset[] assets = (Asset[])ViewState["Assets"];
            Array.Resize(ref assets, assets.Length + 1);

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br ?>" +
                "Average Acts of Subterfuge per Asset: {1}" +
                "(Last Asset you added: {2}", assets.)
        }
    }
}