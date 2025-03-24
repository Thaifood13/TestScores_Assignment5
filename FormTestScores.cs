using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestScores_Assignment5
{
    public partial class FormTestScores : Form
    {
        public FormTestScores()
        {
            InitializeComponent();
        }

        private StreamWriter outAveragesFile;

        private void ListBox_Load(object sender, EventArgs e)
        {

            string inScores;
            if (File.Exists("Student_TestScores.txt"))
            {
                try
                {
                    using (StreamReader inScoresFile = new StreamReader("Student_TestScores.txt"))
                    {
                        while ((inScores = inScoresFile.ReadLine()) != null)
                        {
                            this.listTestScores.Items.Add(inScores);
                        }

                    }
                }

                catch (FileNotFoundException exc)
                {
                    MessageBox.Show(exc.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Issue with file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            try
            {
                outAveragesFile = new StreamWriter("Student_TestAverages");
            }

            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message, "Issues with File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCalcAverage_Click(object sender, EventArgs e)
        {
            if (listTestScores.SelectedItems.Count > 0)
            {
                string selectedText = listTestScores.SelectedItems[0].Text; // Gets Selected items text
                List<int> testScores = new List<int>();

                // Extracts all numbers from selected inbox
                foreach (Match match in Regex.Matches(selectedText, @"\d+"))
                {
                    if (int.TryParse(match.Value, out int testScore))
                    {
                        testScores.Add(testScore);
                    }
                }

                if (testScores.Count > 0)
                {
                    int average = testScores.Sum() / testScores.Count; //calculates the average of the textscores
                    if (listTestScores.SelectedItems[0] != null)
                    {
                        string Name = Regex.Replace(listTestScores.SelectedItems[0].Text, @"[^a-zA-Z\s]", "");
                        listScoreAverage.Items.Add(string.Join(" ", Name, average));
                    }
                }
                else
                {
                    MessageBox.Show("Selected item contains no vaild scores", "Invaild Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please select a student's scores", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSendtoFile_Click(object sender, EventArgs e)
        {
            if (listScoreAverage.SelectedItems.Count > 0)
            {
                string selectedAverage = listScoreAverage.SelectedItems[0].Text;
                try
                {
                    using (StreamWriter outAveragesFile = new StreamWriter("Student_TestAverages.txt", true))
                    {
                        outAveragesFile.WriteLine(selectedAverage);
                    }
                    MessageBox.Show("Average successfully written to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message, "Issues with File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an average to send to the file.", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
