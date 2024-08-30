/* StudentAverage.cs
 * This program retrieves a name and three scores
 * from a text file. The scores are stored originally
 * in the text file deliminated by '|'. Records are
 * displayed in a ListBox. A button on GUI
 * enables you to calculate the average. The
 * average and name are written to a different text file.
 * Both files are stored in the project directory 
 * (bin\debug directory).
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace StudentApp
{
    public partial class FrmStudentApp : Form
    {
        private StreamReader inFile;
        private StreamWriter outFile;
        private double[] averages;
        private string[,] data = new string[8, 4];


        public FrmStudentApp()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                OpenInputFile();
                RetrieveDataAndStoreInArray();
                SetListBox();
                btnRetrieve.Enabled = false;
                btnStore.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Could not read data - " + exc.Message, "Error");
            }
        }

        private void OpenInputFile()
        {
            try
            {
                inFile = new StreamReader("studentRawData.txt"); // File stored in bin\debug directory
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private  void RetrieveDataAndStoreInArray()
        {
            string inData;
            int r = 0;

            string[] studentRecord = new string[4];  // name plus 3 exam scores on each line
            try
            {
                while ((inData = inFile.ReadLine()) != null)
                {
                    studentRecord = inData.Split('|');  // create array using delimiter to separate data
                    for (int c = 0; c < 4; c++)
                    {
                        data[r, c] = studentRecord[c];
                    }
                    r++;       // i represents record 
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SetListBox()
        {
            for (int x = 0; x < data.GetLength(0); x++)
            {
                string studentRec = "";
                for (int y = 0; y < data.GetLength(1); y++)
                {
                    studentRec += data[x, y] + " ";
                }
                lstBxStudents.Items.Add(studentRec);
            }
        }

        private bool CalculateAverages()
        {
            double total = 0;
            averages = new double[data.GetLength(0)];
            try
            {
                for (int r = 0; r < averages.Length; r++)
                {
                    for (int c = 1; c < 4; c++)  // skip name index (0)
                    {
                        total += int.Parse(data[r, c]);
                    }

                    averages[r] = total / 3.0;
                    total = 0;
                }
                return true;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        private bool WriteAverages()
        {
            try
            {
                outFile = new StreamWriter("StudentAverages.txt");
                for (int x = 0; x < averages.Length; x++)
                {
                    lstBxStudents.Items.Add(data[x,0] + "\t" + averages[x].ToString("#.00"));
                    outFile.WriteLine("{0, -20}{1,-8}", data[x, 0], averages[x].ToString("#.00"));
                }
                return true;
            }
            catch
            {
                lblMessage.Text = "Could not open file.";
                return false;
            }
        }

        private void ShowNewRecords()
        {
            try
            {
                lstBxStudents.Items.Clear();
                lblHeading.Text = string.Format("{0,-15}{1,12}","Name", "Average");
                for (int x = 0; x < averages.Length; x++)
                {
                    lstBxStudents.Items.Add(string.Format("{0,-15}", data[x, 0]) + "\t" + averages[x].ToString("#.00"));
                }
            }
            catch
            {
                lblMessage.Text = "Could not show records.";
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            if (CalculateAverages())
                if (WriteAverages())
                {
                    lblMessage.Text = "Data has been written as shown above.";
                    ShowNewRecords();
                    btnStore.Enabled = false;
                }
                else
                    lblMessage.Text = "Could not write data to file";
            else
                lblMessage.Text = "Problem finding averages.";
        }

        private void FrmStudentApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFiles();
        }

        private void CloseFiles()
        {
            try
            {
                inFile.Close();
                outFile.Close();
            }
            catch
            {
                MessageBox.Show("Could not close files");
            }
        }
    }
}
