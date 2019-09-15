using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace WolframRules
{
    public partial class Form1 : Form
    {

        public static int HowManyTimeSteps = 0;
        public static int currentTimeStep = 0;
        public static int sizeOfArray = 0;
        public static int numberOfChangedStates = 0;
        public static int[] stringOfChangedStates;
        public static int ruleNumber = 0;
        public static int lengthOfChangedStates = 0;


        // check boxes
        public static bool isInfinite;
        public static bool isFinite;
        public static bool isParallel;
        public static bool isSequential;
        public static bool isLTR;
        public static bool isRTL;
        public static bool isRandom;
        public static bool isPB;
        public static bool isNB;
        public static bool isUser;
        

        public Form1()
        {
            InitializeComponent();


            
            InfiniteCB.Checked = true;
            PeriodicCB.Hide();
            NullCB.Hide();
            ArraySizeLabel.Hide();
            ArraySizeTB.Hide();
            ParallelCB.Hide();
            SequentialCB.Hide();
            RightToLeft.Hide();
            LeftToRight.Hide();
            Random.Hide();
            UserCB.Hide();
            ParallelCB.Checked = true;
            PeriodicCB.Checked = true;
            LeftToRight.Checked = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            bool isThereError = errorValidation();
            if (isThereError == true)
            {
                showError();
                return;
            }

            HowManyTimeSteps = Convert.ToInt32(TimeStepsTextBox.Text);

            if (InfiniteCB.Checked)
            {               
                sizeOfArray = (2 * HowManyTimeSteps) + (2 * Convert.ToInt32(HowManyStatesTextBox.Text));
            }
            else if (FiniteCB.Checked)
            {                
                sizeOfArray = Convert.ToInt32(ArraySizeTB.Text);
            }

            numberOfChangedStates = Convert.ToInt32(HowManyStatesTextBox.Text);
            stringOfChangedStates = new int[numberOfChangedStates];
            //int[] stringOfChangedStates = new int[numberOfChangedStates];          


            for (int i = 0; i < numberOfChangedStates; i++)
            {                
                if (ChangedStatesCLB.GetItemChecked(i))
                {
                    stringOfChangedStates[i] = 1;
                }
                else
                {
                    stringOfChangedStates[i] = 0;
                }

               
            }

            

            lengthOfChangedStates = Convert.ToInt32(stringOfChangedStates.Length);
            ruleNumber = Convert.ToInt32(NumRule_Txt.Text);

            // check boxes
            isInfinite = InfiniteCB.Checked;
            isFinite = FiniteCB.Checked;
            isParallel = ParallelCB.Checked;
            isSequential = SequentialCB.Checked;
            isLTR = LeftToRight.Checked;
            isRTL = RightToLeft.Checked;
            isRandom = Random.Checked;
            isPB = PeriodicCB.Checked;
            isNB = NullCB.Checked;
            isUser = UserCB.Checked;


            /*
            TimeStepsLabel.Hide();
            TimeStepsTextBox.Hide();

            HowManyStatesLabel.Hide();
            HowManyStatesTextBox.Hide();
            RuleLabel.Hide();
            NumRule_Txt.Hide();
            BTN_Submit.Hide();
            InfiniteCB.Hide();
            FiniteCB.Hide();
            NullCB.Hide();
            PeriodicCB.Hide();
            ArraySizeLabel.Hide();
            ArraySizeTB.Hide();
            ParallelCB.Hide();
            SequentialCB.Hide();
            ChangedStatesTB.Hide();
            ChangedStatesCLB.Hide();
            RightToLeft.Hide();
            LeftToRight.Hide();
            Random.Hide();
            //createGraph();
            */
            
            

            if (isThereError == false)
            {
                Form2 frm2 = new Form2();
                frm2.WindowState = FormWindowState.Maximized;
                frm2.Show();
            }
                     
            
            
        }

        

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            TimeStepsLabel.Visible = Visible;
            TimeStepsTextBox.Visible = Visible;

            HowManyStatesLabel.Visible = Visible;
            HowManyStatesTextBox.Visible = Visible;
            RuleLabel.Visible = Visible;
            NumRule_Txt.Visible = Visible;
            BTN_Submit.Visible = Visible;
            InfiniteCB.Visible = Visible;
            FiniteCB.Visible = Visible;
            PeriodicCB.Visible = Visible;
            NullCB.Visible = Visible;
            ArraySizeLabel.Visible = Visible;
            ArraySizeTB.Visible = Visible;
            ParallelCB.Visible = Visible;
            SequentialCB.Visible = Visible;
            ChangedStatesCLB.Visible = Visible;
            
            RightToLeft.Visible = Visible;
            LeftToRight.Visible = Visible;
            Random.Visible = Visible;
            


        }

        private void Show_TxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }    
        

            private void InfiniteCB_CheckedChanged(object sender, EventArgs e)
            {
                /*
                if (FiniteCB.Checked)
                {
                    PeriodicCB.Visible = Visible;
                    NullCB.Visible = Visible;
                    ArraySizeLabel.Visible = Visible;
                    ArraySizeTB.Visible = Visible;
                    InfiniteCB.Checked = false;
                }
                */
                if (InfiniteCB.Checked)
                {
                    PeriodicCB.Hide();
                    NullCB.Hide();
                    ArraySizeLabel.Hide();
                    ArraySizeTB.Hide();
                    ParallelCB.Hide();
                    SequentialCB.Hide();
                    LeftToRight.Hide();
                    RightToLeft.Hide();
                    Random.Hide();
                    UserCB.Hide();
                    FiniteCB.Checked = false;
                }
            }

            private void FiniteCB_CheckedChanged(object sender, EventArgs e)
            {
                if (FiniteCB.Checked)
                {
                    ParallelCB.Visible = Visible;
                    SequentialCB.Visible = Visible;
                    PeriodicCB.Visible = Visible;
                    NullCB.Visible = Visible;
                    ArraySizeLabel.Visible = Visible;
                    ArraySizeTB.Visible = Visible;
                    
                    InfiniteCB.Checked = false;
                }
                /*
                if (InfiniteCB.Checked)
                {
                    PeriodicCB.Hide();
                    NullCB.Hide();
                    ArraySizeLabel.Hide();
                    ArraySizeTB.Hide();
                    FiniteCB.Checked = false;
                }
                */
            }

            private void Form1_Paint(object sender, PaintEventArgs e)
            {
                


            }
           

            private void Form1_TextChanged(object sender, EventArgs e)
            {

            }

            private void HowManyStatesTextBox_TextChanged(object sender, EventArgs e)
            {            
                if (HowManyStatesTextBox.Text != String.Empty)
                {
                    howManyStatesChanged();
                }                
            }

            private void howManyStatesChanged()
            {
                ChangedStatesCLB.HorizontalScrollbar = true;
                var items = ChangedStatesCLB.Items;                

                ChangedStatesCLB.Items.Clear();

                for (int i = 0; i < Convert.ToInt32(HowManyStatesTextBox.Text); i++)
                {
                    items.Add(i+1);
                }
            }

            private void PeriodicCB_CheckedChanged(object sender, EventArgs e)
            {

                if (PeriodicCB.Checked)
                {
                    NullCB.Checked = false;
                }

            }

            private void NullCB_CheckedChanged(object sender, EventArgs e)
            {

                if (NullCB.Checked)
                {
                    PeriodicCB.Checked = false;
                }
            }

            private bool errorValidation()
            {
                bool isError = false;

                int num = 0;
                bool result = int.TryParse(TimeStepsTextBox.Text, out num);
                if (!int.TryParse(TimeStepsTextBox.Text, out num))
                {
                    MessageBox.Show("Time steps must be a number.");
                    return true;
                }

                if (ArraySizeTB.Text == "" && FiniteCB.Checked)
                {
                    isError = true;
                    //MessageBox.Show("You need to set the array size.");                    
                }

                if (TimeStepsTextBox.Text == "")
                {
                    isError = true;
                    return true;
                    //MessageBox.Show("You need to set the number of time steps.");                    
                }

                if (NumRule_Txt.Text == "")
                {
                isError = true;
                //MessageBox.Show("You need to set the number of time steps.");
                }

                if (Convert.ToInt32(TimeStepsTextBox.Text) < 0)
                {
                isError = true;
                //MessageBox.Show("Time Steps must be at least 0.");                    
                }

                if (isFinite == true)
                {
                    if (Convert.ToInt32(ArraySizeTB.Text) < 0)
                    {
                        isError = true;
                        //MessageBox.Show("Array size must be greater than 0.");
                    }
                }

                if (Convert.ToInt32(NumRule_Txt.Text) < 0 || Convert.ToInt32(NumRule_Txt.Text) > 256)
                {
                isError = true;
                //MessageBox.Show("The rule number must be between 0 and 255.");
                }

                /*
                int num;
                if (int.TryParse(TimeStepsTextBox.Text, out num))
                {

                }
                else
                {
                    MessageBox.Show("Time Steps must be an integer.");
                }
                */

                return isError; ;
            }

            private void showError()
            {             

                if (ArraySizeTB.Text == "" && FiniteCB.Checked)
                {
                    MessageBox.Show("You need to set the array size.");                    
                }

                if (TimeStepsTextBox.Text == "")
                {
                    MessageBox.Show("You need to set the number of time steps.");                    
                }

                if (NumRule_Txt.Text == "")
                {
                    MessageBox.Show("You need to set the number of time steps.");
                }

                if (Convert.ToInt32(TimeStepsTextBox.Text) < 0)
                {
                    MessageBox.Show("Time Steps must be at least 0.");                    
                }

            if (isFinite)
            {
                if (Convert.ToInt32(ArraySizeTB.Text) < 0 && isFinite)
                {
                    MessageBox.Show("Array size must be greater than 0.");
                }
            }

                if (Convert.ToInt32(NumRule_Txt.Text) < 0 || Convert.ToInt32(NumRule_Txt.Text) > 256)
                {
                    MessageBox.Show("The rule number must be between 0 and 255.");
                }

                int num;
                bool result = int.TryParse(TimeStepsTextBox.Text, out num);                
                if (!int.TryParse(TimeStepsTextBox.Text, out num))
                {
                    MessageBox.Show("Time steps must be a number.");
                    return;
                }
                
                
            }

        private void ParallelCB_CheckedChanged(object sender, EventArgs e)
            {
                if (ParallelCB.Checked == true)
                {
                    SequentialCB.Checked = false;
                    RightToLeft.Hide();
                    LeftToRight.Hide();
                    Random.Hide();
                    UserCB.Hide();
                }
            }

            private void SequentialCB_CheckedChanged(object sender, EventArgs e)
            {
                if (SequentialCB.Checked == true)
                {
                    ParallelCB.Checked = false;
                    RightToLeft.Visible = Visible;
                    LeftToRight.Visible = Visible;
                    Random.Visible = Visible;
                    //UserCB.Visible = Visible;
                }
            }

            private void LeftToRight_CheckedChanged(object sender, EventArgs e)
            {
                if (LeftToRight.Checked == true)
                {
                    RightToLeft.Checked = false;
                    Random.Checked = false;
                    UserCB.Checked = false;
                }
            }

            private void RightToLeft_CheckedChanged(object sender, EventArgs e)
            {
                if (RightToLeft.Checked == true)
                {
                    LeftToRight.Checked = false;
                    Random.Checked = false;
                    UserCB.Checked = false;
                }
            }

            private void Random_CheckedChanged(object sender, EventArgs e)
            {
                if (Random.Checked == true)
                {
                    LeftToRight.Checked = false;
                    RightToLeft.Checked = false;
                    UserCB.Checked = false;
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RandomizeSS_Click(object sender, EventArgs e)
        {
            if (HowManyStatesTextBox.Text != String.Empty)
            {
                randomSS();
            }
        }

        private void randomSS()
        {
            Random r = new Random();
            int[] randomArray = new int[Convert.ToInt32(HowManyStatesTextBox.Text)];

            for (int i = 0; i < Convert.ToInt32(HowManyStatesTextBox.Text); i++)
            {
                randomArray[i] = r.Next(0, 2);
            }
                       
            for (int j = 0; j < Convert.ToInt32(HowManyStatesTextBox.Text); j++)
            {
                if (randomArray[j] == 1)
                {
                    ChangedStatesCLB.SetItemCheckState(j, CheckState.Checked);
                }
                else
                {
                    ChangedStatesCLB.SetItemCheckState(j, CheckState.Unchecked);
                }
            }
        }

        private void UserCB_CheckedChanged(object sender, EventArgs e)
        {
            if (UserCB.Checked == true)
            {
                RightToLeft.Checked = false;
                LeftToRight.Checked = false;
                Random.Checked = false;
            }
        }

        private void ArraySizeTB_TextChanged(object sender, EventArgs e)
        {
            if (ArraySizeTB.Text != "")
            {
                userImplement();
            }
        }

        private void userImplement()
        {       
            /*
            Label[] user = new Label[Convert.ToInt32(ArraySizeTB.Text)];
            TextBox[] userTB = new TextBox[Convert.ToInt32(ArraySizeTB.Text)];

            for (int i = 0; i < Convert.ToInt32(ArraySizeTB.Text); i++)
            {
                this.Controls.Remove(user[i]);
                this.Controls.Remove(userTB[i]);
            }

            int yLoc = 350;

            for (int i = 0; i < Convert.ToInt32(ArraySizeTB.Text); i++)
            {
                
                user[i] = new Label();
                user[i].Text = "Cell: " + (i + 1);
                user[i].Location = new Point(30, yLoc);
                userTB[i] = new TextBox();                
                userTB[i].Location = new Point(130, yLoc);
                
                this.Controls.Add(user[i]);
                this.Controls.Add(userTB[i]);
                user[i].Update();
                userTB[i].Update();
                
                yLoc = yLoc + 30;      
                
            }
            */

        }
        
    }
} 
