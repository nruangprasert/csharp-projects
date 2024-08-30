using System;
using System.Windows.Forms;
using SingleFamilyNamespace;
using MultiUnitNamespace;

namespace HousingPresentationGUI
{
   
    public partial class HousingPresentationGUI : Form
    {
        SingleFamily[] privateHome;
        MultiUnits[] multi;

        public HousingPresentationGUI()
        {
            InitializeComponent();
        }

        private void HousingPresentationGUI_Load(object sender, EventArgs e)
        {
            privateHome = new SingleFamily[5];

            privateHome[0] = new SingleFamily("34 Winston Street", 3, 2, 900.00m);
            privateHome[1] = new SingleFamily("5234 Carolina Ave", 2, 2, 850.00m);
            privateHome[2] = new SingleFamily("54 Magnolia Court", 4, 2, 1150.00m);
            privateHome[3] = new SingleFamily("6910 Reiley", 3, 2, 1000.00m);
            privateHome[4] = new SingleFamily("76 St. Johns Ct.", 3, 2, 1000.00m);

            foreach (SingleFamily homes in privateHome)
            {
                lstBxSingle.Items.Add(homes.Address);
            }


            multi = new MultiUnits[2];

            multi[0] = new MultiUnits("8674 Victoria Lane", 2, 750.00m);
            multi[1] = new MultiUnits("9724 Bridge Street", 2, 700.00m);

            foreach (MultiUnits duplex in multi)
            {
                lstBxMulti.Items.Add(duplex.Address);
            }

        }

        private void cmboTypeOfRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRentalDetails.Text = "";

            lblInstructions.Visible = true;
            if (cmboTypeOfRental.SelectedIndex == 0)
            {
                lstBxSingle.Visible = true;
                lstBxMulti.Visible = false;
            }
            else
            {
                lstBxSingle.Visible = false;
                lstBxMulti.Visible = true;
            }

        }

        private void lstBxMulti_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MultiUnits duplex in multi)
            {
                if (duplex.Address == lstBxMulti.SelectedItem.ToString())
                    lblRentalDetails.Text = duplex.ToString();
            }
        }

        private void lstBxSingle_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (SingleFamily home in privateHome)
            {
                if (home.Address == lstBxSingle.SelectedItem.ToString())
                    lblRentalDetails.Text = home.ToString();
            }

        }
    }
}
