using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComponentArray();
        }

        private List<TextBox> textList = new List<TextBox>();
        private List<NumericUpDown> weightageItems = new List<NumericUpDown>();


        /* Initialise array with default components 
         * weightageItem == array of percentage of each task
         * textList == array of marks for each task
         */
        private void ComponentArray()
        {
            weightageItems.Add(weightUpDown1);
            weightageItems.Add(weightUpDown2);
            weightageItems.Add(weightUpDown3);
            weightageItems.Add(weightUpDown4);
            weightageItems.Add(weightUpDown5);
            textList.Add(textBox1);
            textList.Add(textBox2);
            textList.Add(textBox3);
            textList.Add(textBox4);
            textList.Add(textBox5);
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
            (double currentGrades, bool[] notTested) = CalculateGrades();
            double remainder = Math.Round(marksDictionary[(int)GPAUpDown1.Value] - currentGrades, 2);

            int ungradedNumber = notTested.Where(c => c).Count();
            if (ungradedNumber == 1) {
                for (int i = 0; i < notTested.Length; i++)
                {

                    if (notTested[i] == true) // not given marks
                    {
                        string message = string.Format("You need {0}% more.", remainder);
                        marksLabel.Text = message;
                    }
                }
            }
            //if (ungradedNumber > 1)
            //{

            //}
            else marksLabel.Text = string.Format("Marks left: {0}", remainder);

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

        private (double, bool[]) CalculateGrades() // function for calculating marks needed
        {
            bool[] notTested = new bool[]
            {
                false, false, false, false, false
            };

            double score = 0;

            int index = 0; // track index of foreach
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

                        if (word2 == 0) texts.Text = "Invalid Number"; // handles infinity

                        score += result * (double)weightageItems[index].Value;
                    }

                    // all else parse
                    else if (double.TryParse(texts.Text, out result)) score += result;

                    else if (texts.Text == "")
                    {
                        notTested[index] = true;
                    }

                    // fail all above
                    // else;

                    index++;
                }
            }
            return (score, notTested);
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

        /* Clears assignment marks and
         * percentage of task 
         * to default - 25% and empty
         * assignment names
         */
        private void ClearAll(object sender, MouseEventArgs e)
        {
            foreach (var weight in weightageItems)
            {
                weight.Value = 25;
            }
            foreach (var text in textList)
            {
                text.Text = "";
            }

            weightUpDown1.Value = 25;
            weightUpDown4.Value = 25;
        }

        /* Ability to save grades in a txt?
         * file that can be loaded
         * on start up next time.
         */
        private void SaveUnit(object sender, EventArgs e)
        {
            string unitName = tabPage1.Text;
            using (var tw = new StreamWriter("grades.txt", true))
            {
                tw.WriteLine(unitName);

                foreach (var val in weightageItems)
                {
                    Console.Write(val);
                    tw.WriteLine(val.Value);
                }

                foreach (var val in textList)
                {
                    Console.Write(val.Text);
                    tw.WriteLine(val.Text);
                }

                tw.Close();
            }

            // sets grades file as hidden
            string path = Environment.CurrentDirectory + @"\grades.txt";
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);

            

            
        }
    }
}
