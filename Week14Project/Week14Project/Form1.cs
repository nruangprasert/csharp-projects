using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week14Project
{
    public partial class PracticeApp : Form
    {
        public PracticeApp()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = 
                    new StreamWriter("StudentInfo.txt",true);
                writer.Write(txtBxID.Text + " ");
                writer.WriteLine(txtBxName.Text);    
                //string name = txtBxName.Text;
                MessageBox.Show("student data is saved in the file");
                writer.Close();

            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            txtBxID.Text = "";
            listEvents.ClearSelected();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader =
                    new StreamReader("StudentInfo.txt");
                //string txt = reader.ReadToEnd();
                //txtBxOutput.Text = txt;
                string line;
                while((line = reader.ReadLine()) != null) {
                    listNames.Items.Add(line);  
                }
                reader.Close();
                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string str = listEvents.SelectedItem.ToString();
            /*string str = "Event you are interested in is "
                +listEvents.Text;*/
            string str = "";
            foreach(string s in listEvents.SelectedItems)
            {
                str += s + " ";
            }
            txtBxOutput.Text = "Events you are interested in " +
                "are " + str;
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            if(txtNewEvent.Text != "")
            {
                listEvents.Items.Add(txtNewEvent.Text);
            }
            
        }

        private void ComputeCost_CheckedChanged(object sender, EventArgs e)
        {
            double cost = 0;
            if (chBxSwim.Checked)
                cost += 50;
            if (chBxSnorkal.Checked)
                cost += 25;
            if (chBxDive.Checked)
                cost += 100;
            if (rdBtnBeg.Checked)
                cost += 20;
            else if (rdBtnAdvance.Checked)
                cost -= 10;
            txtBxOutput.Text = "The cost is " + 
                cost.ToString("c");

        }

        
    }
}
