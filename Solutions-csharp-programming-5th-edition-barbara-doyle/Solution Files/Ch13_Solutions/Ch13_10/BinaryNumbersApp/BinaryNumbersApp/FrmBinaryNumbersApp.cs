/* BinaryNumbersApp.cs
 * Allows the user to enter 5 numbers which will be stored to a binary file
 * along with the average of those 5 numbers.
 * Numbers may be entered multiple times.
 */
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

namespace BinaryNumbersApp
{
    public partial class FrmBinaryNumbersApp : Form
    {
        private bool firstRecord;
        private FileStream filStream;
        private BinaryWriter binWriter;
        private BinaryReader binReader;
        private double average;

        public FrmBinaryNumbersApp()
        {
            InitializeComponent();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            RetrieveData();
            StoreInFile();
            ClearTextBoxes();
            txtBxValue1.Focus();
            btnRetrieve.Visible = true;
        }
        
        private void RetrieveData( )
        {
            try
            {
                if (txtBxValue1.Text == "" || txtBxValue2.Text == "" 
                    || txtBxValue3.Text == "" || txtBxValue4.Text == "" 
                    || txtBxValue5.Text == "")
                    MessageBox.Show("Please enter 5 numbers");
                else
                    average = (int.Parse(txtBxValue1.Text) + int.Parse(txtBxValue2.Text) +
                                int.Parse(txtBxValue3.Text) + int.Parse(txtBxValue4.Text) + 
                                int.Parse(txtBxValue5.Text)) / 5.0;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }

        }

        private void ClearTextBoxes()
        {
            txtBxValue1.Text = string.Empty;
            txtBxValue2.Text = string.Empty;
            txtBxValue3.Text = string.Empty;
            txtBxValue4.Text = string.Empty;
            txtBxValue5.Text = string.Empty;
        }


        private void StoreInFile( )
        {
            try
            {
                    if (File.Exists("info.txt"))
                    {
                          if (firstRecord)
                          {
                              File.Delete("info.txt");
                              firstRecord = false;
                              filStream = new FileStream("info.txt", FileMode.CreateNew);
                              binWriter = new BinaryWriter(filStream);
                          }
                          else
                          {
                            filStream = new FileStream("info.txt", FileMode.Append);
                            binWriter = new BinaryWriter(filStream);
                          }
                    }
                    else
                    {
                        filStream = new FileStream("info.txt", FileMode.CreateNew);
                        binWriter = new BinaryWriter(filStream);
                    }
                     
                binWriter.Write(int.Parse(txtBxValue1.Text)); 
                binWriter.Write(int.Parse(txtBxValue2.Text));
                binWriter.Write(int.Parse(txtBxValue3.Text));
                binWriter.Write(int.Parse(txtBxValue4.Text));
                binWriter.Write(int.Parse(txtBxValue5.Text));
                binWriter.Write((double)average);

                binWriter.Close();
                filStream.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string val ="";
            try
            {
                txtBxValue1.Enabled = false;
                txtBxValue2.Enabled = false;
                txtBxValue3.Enabled = false;
                txtBxValue4.Enabled = false;
                txtBxValue5.Enabled = false;
                btnStore.Enabled = false;

                if (File.Exists("info.txt"))
                {
                    filStream = new FileStream("info.txt", FileMode.Open, FileAccess.Read);
                    binReader = new BinaryReader(filStream);                       
                    this.lstBxNumbers.Visible = true;
                    lblForListBox.Visible = true;
                    while(binReader.PeekChar() != -1)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            val += string.Format("{0,15}", binReader.ReadInt32().ToString());
                        }
                        val += string.Format("{0,24}", binReader.ReadDouble().ToString("F2"));
                        lstBxNumbers.Items.Add(val);
                        val = string.Empty;
                    }
                    binReader.Close();
                    filStream.Close();
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

         private void FrmBinaryNumbersApp_Load(object sender, EventArgs e)
        {
            this.lstBxNumbers.Visible = false;
            firstRecord = true;
        }
    }
}
