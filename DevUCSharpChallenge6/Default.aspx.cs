using System;
using System.Linq;
using System.Web.UI;

namespace DevUCSharpChallenge6
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //need to store an array of agents with name, # of elections rigged, and # of acts of subterfuge preformed
            //ORRRRR 3 separate arrays, one for each attribute.
            if (!Page.IsPostBack)
            {
                double[] electionsRigged = new double[0];
                ViewState.Add("ElectionsRigged", electionsRigged);

                double[] actsOfSubterfuge = new double[0];
                ViewState.Add("ActsOfSubterfuge", actsOfSubterfuge);

                string[] assetNames = new string[0];
                ViewState.Add("AssetNames", assetNames);
                
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            
            double[] electionsRigged = (double[])ViewState["ElectionsRigged"];
            int newLength = electionsRigged.Length + 1;
            int newIndex = electionsRigged.GetUpperBound(0);
            Array.Resize(ref electionsRigged, newLength);
            electionsRigged[newIndex] = int.Parse(electionsRiggedTextBox.Text);

            double[] actsOfSubterfuge = (double[])ViewState["ActsOfSubterfuge"];
            Array.Resize(ref actsOfSubterfuge, newLength);
            actsOfSubterfuge[newIndex] = int.Parse(actsOfSubterfugeTextBox.Text);


            string[] assetNames = (string[])ViewState["AssetNames"];
            Array.Resize(ref assetNames, newLength);
            assetNames[newIndex] = assetNameTextBox.Text;


            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br ?>" +
                "Average Acts of Subterfuge per Asset: {1}<br />" +
                "(Last Asset you added: {2})", electionsRigged.Sum(), actsOfSubterfuge.Average(), assetNames[0]);
        }
    }
}