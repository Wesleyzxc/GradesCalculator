using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WeightArray();
        }

        // Dictionary of GPA to marks for 7 grade system
        public IDictionary<int, int> marksDictionary = new Dictionary<int, int>()
                                            {
                { 1, 0 },
                { 2, 25 },
                { 3, 40 },
                { 4, 50 },
                { 5, 65 },
                { 6, 75 },
                { 7, 85 }
            };

        private int GetSelectedTab()
        {
            
            int tabIndex = tabControl.SelectedIndex;
            return tabIndex;
        }

        private void SetUnitName(object sender, EventArgs e)
        {
            int tabIndex = GetSelectedTab();
            if (unitText.Text != "") tabControl.TabPages[tabIndex].Text = unitText.Text;
            //unitText.Text = ;
            unitText.Focus();
            unitText.SelectAll();
        }

        private void EnterKey(object sender, KeyEventArgs e) // UpdateTab if enter is pressed
        {
            RemoveSound(sender, e);
            if (e.KeyCode == Keys.Enter) // if enter
            {
                UpdateTab(this, e);
            }

        }


        /*
         * When Submit button is interacted with
         */
        private void UpdateTab(object sender, EventArgs e) 
        {
            SetUnitName(this, e);
            UpdateWeightage();
            double currentGrades = CalculateGrades();
            marksLabel.Text = string.Format("Marks left: {0}", marksDictionary[(int)GPAUpDown1.Value] - currentGrades);
        }

        private void ChangeTabPages(object sender, EventArgs e)
        {
            int numPages = tabControl.TabCount;
            if (numUpDown.Value == tabControl.TabCount) { }
            else if (numUpDown.Value > tabControl.TabCount) // increase tabs
            {
                string title = "TabPage " + (tabControl.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                tabControl.TabPages.Add(myTabPage);
            }
            else // decrease tabs
            { 
                // Removes the selected tab:  
                tabControl.TabPages.Remove(tabControl.TabPages[tabControl.TabCount-1]);
            }
            Console.WriteLine(numUpDown.Value);
        }

        private void EnableAssignment(object sender, EventArgs e)
        {
            string name = (sender as CheckBox).Name; // retrieves checkbox that was interacted with
            string checkedNumber = Regex.Match(name, @"\d+").Value;

            List<GroupBox> groupList = new List<GroupBox>()
            {
                groupBox1, groupBox2, groupBox3, groupBox4, groupBox5
            };

            groupList[int.Parse(checkedNumber) - 1].Enabled = !groupList[int.Parse(checkedNumber) - 1].Enabled;

        }

        private double CalculateGrades() // function for calculating marks needed
        {
            List<TextBox> textList = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5
            };

            double score = 0;
            foreach (var texts in textList)
            { 
                if (texts.Enabled)
                {
                    double result;
                    // deal with fractions
                    if (texts.Text.Contains("/"))
                    {
                        Console.Write("Fraction");
                        string[] words = texts.Text.Split('/');
                        double.TryParse(words[0], out double word1);
                        double.TryParse(words[1], out double word2);
                        result = word1 / word2;

                        if (texts.Equals(textBox1))
                        {
                            score += result * (double)weightageItems[0].Value;
                        }
                        else if (texts.Equals(textBox2))
                        {
                            score += result * (double)weightageItems[1].Value;
                        }
                        else if (texts.Equals(textBox3))
                        {
                            score += result * (double)weightageItems[2].Value;
                        }
                        else if (texts.Equals(textBox4))
                        {
                            score += result * (double)weightageItems[3].Value;
                        }
                        else if (texts.Equals(textBox5))
                        {
                            score += result * (double)weightageItems[4].Value;
                        }
                    }
                    else double.TryParse(texts.Text, out result);

                    score += result;
                    
                }
            }
            Console.WriteLine(score);
            return score;
        }


        private void UpdateWeightage()
        {
            decimal totalWeight = 0;
            for (int i = 0; i<5; i++)
            {
                if (weightageItems[i].Enabled)
                {
                    totalWeight += weightageItems[i].Value;
                }
            }

            if (totalWeight != 100)
            {
                string message = string.Format("Your assignments' weightage does not add up to 100%.\nCurrent weightage is {0}%.", totalWeight);
                errorMessage.Visible = true;
                errorMessage.Text = message;
                MessageBox.Show(message, "Invalid Weightage");
            }
            else
            {
                errorMessage.Visible = false;
            }
             
        }


        private List<NumericUpDown> weightageItems = new List<NumericUpDown>();
        // initialise array with NumericUpDown
        private void WeightArray()
        {
            weightageItems.Add(weightUpDown1);
            weightageItems.Add(weightUpDown2);
            weightageItems.Add(weightUpDown3);
            weightageItems.Add(weightUpDown4);
            weightageItems.Add(weightUpDown5);
        }
        

        /* Extra method to remove Windows sound
         * when enter is pressed
         *  
         */
        private void RemoveSound(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
