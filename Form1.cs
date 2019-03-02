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
        public Form1()
        {
            InitializeComponent();

            Show_TxtBox.Hide();
            ReturnButton.Hide();
            PeriodicCB.Hide();
            NullCB.Hide();
            ArraySizeLabel.Hide();
            ArraySizeTB.Hide();  
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Beige, 5);
            Graphics g = Show_TxtBox.CreateGraphics();

            
            Show_TxtBox.Visible = Visible;
            TimeStepsLabel.Hide();
            TimeStepsTextBox.Hide();
            ChangedStatesLabel.Hide();
            ChangedStatesTextBox.Hide();
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
            //createGraph();
            g.DrawEllipse(p, 1, 1, 10, 10);
        }

        private void createGraph()
        {
            Show_TxtBox.Visible = Visible;
            Show_TxtBox.Enabled = false;
            Show_TxtBox.AcceptsReturn = true;
            Show_TxtBox.Text = string.Empty;
            //Show_TxtBox.TextAlignment = TextAlignment.DetectFromContent;
            //Show_TxtBox.IsColorFontEnabled = true;

            int arraySize = 0;
            int timeSteps = Convert.ToInt32(TimeStepsTextBox.Text);

            if(InfiniteCB.Checked)
            {
                arraySize = (2 * timeSteps) + (2 * Convert.ToInt32(HowManyStatesTextBox.Text));
            }
            else if (FiniteCB.Checked)
            {
                arraySize = Convert.ToInt32(ArraySizeTB.Text);
            }          

           
            if (InfiniteCB.Checked)
            {
                infinite(arraySize, timeSteps);
            }
            else if (FiniteCB.Checked)
            {
                finite(arraySize, timeSteps);
            }

            

            TimeStepsLabel.Hide();
            TimeStepsTextBox.Hide();
            ChangedStatesLabel.Hide();
            ChangedStatesTextBox.Hide();
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
            //Show_TxtBox.Visible = Visible;
            ReturnButton.Visible = Visible;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            TimeStepsLabel.Visible = Visible;
            TimeStepsTextBox.Visible = Visible;
            ChangedStatesLabel.Visible = Visible;
            ChangedStatesTextBox.Visible = Visible;
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
            Show_TxtBox.Hide();
            ReturnButton.Hide();

            
        }
        
        private void Show_TxtBox_TextChanged(object sender, EventArgs e)
        {
            /*
            if (Show_TxtBox.Text.Length == 0)
            {
                return;
            }

            float height = Show_TxtBox.Height * 0.99f;
            float width = Show_TxtBox.Width * 0.99f;

            Show_TxtBox.SuspendLayout();

            Font tryFont = Show_TxtBox.Font;
            Size tempSize = TextRenderer.MeasureText(Show_TxtBox.Text, tryFont);

            float heightRatio = height / tempSize.Height;
            float widthRatio = width / tempSize.Width;

            tryFont = new Font(tryFont.FontFamily, tryFont.Size * Math.Min(widthRatio, heightRatio), tryFont.Style);

            Show_TxtBox.Font = tryFont;
            Show_TxtBox.ResumeLayout();
            
            
            Size size = TextRenderer.MeasureText(Show_TxtBox.Text, Show_TxtBox.Font);
            Show_TxtBox.Width = size.Width;
            Show_TxtBox.Height = size.Height;
            */

            Graphics g = Show_TxtBox.CreateGraphics();
            Pen p = new Pen(Brushes.Black, 1);


        }               

        private void scaling(int timeSteps)
        {
            // Determining font size

            if (ChangedStatesTextBox.Text.Length <= 2)
            {

                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 25);
                }
                if (timeSteps > 7 && timeSteps <= 12)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 12);
                }
                if (timeSteps > 12 && timeSteps <= 25)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 8);
                }
                if (timeSteps > 25 && timeSteps <= 28)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 6);

                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 5);

                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 4.5f);

                }
                if (timeSteps > 40 && timeSteps <= 45)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 4.5f);

                }
                if (timeSteps > 45 && timeSteps <= 68)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 3);

                }
                if (timeSteps > 68 && timeSteps <= 80)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 2);

                }
                if (timeSteps > 80 && timeSteps <= 100)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 2);

                }
                if (timeSteps > 100 && timeSteps <= 127)
                {
                    Show_TxtBox.Font = new Font("Microsoft Sans Serif", 2);

                }
            }
            /*
            else if (ChangedStatesTextBox.Text.Length > 2 && ChangedStatesTextBox.Text.Length <= 4)
            {
                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.FontSize = 37;
                }
                if (timeSteps > 7 && timeSteps <= 12)
                {
                    Show_TxtBox.FontSize = 23;
                }
                if (timeSteps > 12 && timeSteps <= 17)
                {
                    Show_TxtBox.FontSize = 17;
                }
                if (timeSteps > 17 && timeSteps <= 28)
                {
                    Show_TxtBox.FontSize = 13;
                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.FontSize = 11;
                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.FontSize = 9;
                }
                if (timeSteps > 41 && timeSteps <= 50)
                {
                    Show_TxtBox.FontSize = 7;
                }
                if (timeSteps > 51 && timeSteps <= 68)
                {
                    Show_TxtBox.FontSize = 6;
                }
                if (timeSteps > 68 && timeSteps <= 80)
                {
                    Show_TxtBox.FontSize = 5;
                }
                if (timeSteps > 80 && timeSteps <= 100)
                {
                    Show_TxtBox.FontSize = 4;
                }
            }
            else if (ChangedStatesTextBox.Text.Length > 4 && ChangedStatesTextBox.Text.Length <= 6)
            {
                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.FontSize = 36;
                }
                if (timeSteps > 7 && timeSteps <= 12)
                {
                    Show_TxtBox.FontSize = 24;
                }
                if (timeSteps > 12 && timeSteps <= 17)
                {
                    Show_TxtBox.FontSize = 18;
                }
                if (timeSteps > 17 && timeSteps <= 28)
                {
                    Show_TxtBox.FontSize = 13;
                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.FontSize = 11.5;
                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.FontSize = 9;
                }
                if (timeSteps > 41 && timeSteps <= 50)
                {
                    Show_TxtBox.FontSize = 8;
                }
                if (timeSteps > 51 && timeSteps <= 68)
                {
                    Show_TxtBox.FontSize = 6;
                }
                if (timeSteps > 68 && timeSteps <= 80)
                {
                    Show_TxtBox.FontSize = 5;
                }
                if (timeSteps > 80 && timeSteps <= 100)
                {
                    Show_TxtBox.FontSize = 4;
                }
            }
            */
        }

        private void finite(int arraySize, int timeSteps)
        {
            if (Convert.ToInt32(ChangedStatesTextBox.Text.Length) > Convert.ToInt32(HowManyStatesTextBox.Text) || Convert.ToInt32(ChangedStatesTextBox.Text.Length) < Convert.ToInt32(HowManyStatesTextBox.Text))
            {
                //Show_TxtBox.FontSize = 36;
                Show_TxtBox.Text += "Error. The string length must equal how many states you wanted to change.";

                TimeStepsLabel.Hide();
                TimeStepsTextBox.Hide();
                ChangedStatesLabel.Hide();
                ChangedStatesTextBox.Hide();
                HowManyStatesLabel.Hide();
                HowManyStatesTextBox.Hide();
                RuleLabel.Hide();
                NumRule_Txt.Hide();
                BTN_Submit.Hide();
                Show_TxtBox.Visible = Visible;
                ReturnButton.Visible = Visible;
            }
            else
            {
                scaling(timeSteps);

                int[] presentState = new int[arraySize];
                int[] previousState = new int[arraySize];

                int changedStates = Convert.ToInt32(ChangedStatesTextBox.Text);
                int numOfChangedStates = Convert.ToInt32(ChangedStatesTextBox.Text.Length);
                int middleOfArray = (arraySize - numOfChangedStates) / 2;


                for (int i = 0; i < arraySize; i++)
                {
                    if (i < middleOfArray)
                    {
                        presentState[i] = 0;
                    }
                    else if (i >= middleOfArray && i <= numOfChangedStates + middleOfArray)
                    {
                        presentState[i] = changedStates % 10;
                        changedStates /= 10;
                    }
                    else if (i > middleOfArray + changedStates)
                    {
                        presentState[i] = 0;
                    }
                }

                Array.Reverse(presentState);


                int time = 0;
                int p, n, caseNum = 0;
                //char choice;
                int[] rule = new int[8];

                int ruleNumber = Convert.ToInt32(NumRule_Txt.Text);

                int ruleNum = Convert.ToInt32(Convert.ToString(ruleNumber, 2).PadLeft(8, '0'));

                // Setting the rule array to contain a single digit of the string of the binary number that the user enters.
                for (int i = rule.Length - 1; i >= 0; i--)
                {
                    rule[i] = ruleNum % 10;
                    ruleNum /= 10;
                }

                //Show_TxtBox.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;

                string s = null;

                for (int i = 0; i < arraySize; i++)
                {
                    if (presentState[i] == 0)
                    {
                        s += "   ";

                        //Show_TxtBox.Text += "    ";
                    }
                    else
                    {
                        //Show_TxtBox.Text += "\uD83D\uDD34";
                        s += "\uD83D\uDD34";
                    }

                }

                s += "\r\n";

                while (time < Convert.ToInt32(TimeStepsTextBox.Text))
                {
                    for (int i = 0; i < arraySize; i++)
                    {
                        previousState[i] = presentState[i];
                    }
                    for (int i = 0; i < arraySize; i++)
                    {
                        p = i - 1;
                        n = i + 1;
                        caseNum = 0;

                        // *****************************************************************************************************
                        if (NullCB.Checked)
                        {
                            if (p == -1)
                            {
                                caseNum += 2 * previousState[i] + 1 * previousState[n];
                            }
                            else if (n == arraySize)
                            {
                                caseNum += 4 * previousState[p] + 2 * previousState[i];
                            }
                            else
                            {
                                caseNum += 4 * previousState[p] + 2 * previousState[i] + 1 * previousState[n];
                            }
                        } else if(PeriodicCB.Checked)
                        {
                            if (p == -1)
                            {
                                caseNum += 4* previousState[arraySize-1] + 2 * previousState[i] + 1 * previousState[n];
                            }
                            else if (n == arraySize)
                            {
                                caseNum += 4 * previousState[p] + 2 * previousState[i] + 1 *previousState[0];
                            }
                            else
                            {
                                caseNum += 4 * previousState[p] + 2 * previousState[i] + 1 * previousState[n];
                            }

                        }
                        switch (caseNum)
                        {
                            case 0:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 1:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 2:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 3:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 4:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 5:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 6:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 7:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }

                        }
                    }
                    for (int i = 0; i < arraySize; i++)
                    {
                        if (presentState[i] == 0)
                        {
                            s += "   ";

                            //Show_TxtBox.Text += "    ";
                        }
                        else
                        {
                            s += "\uD83D\uDD34";

                            //Show_TxtBox.Text += "\uD83D\uDD34";
                        }
                    }
                    //Show_TxtBox.Text += "\r\n";
                    s += "\r\n";


                    time++;

                }

                Show_TxtBox.Text += s;

                Show_TxtBox.Text += "\r\n";
            }
        }

        private void infinite(int arraySize, int timeSteps)
        {
            Pen pen = new Pen(Brushes.Black);
            Graphics g = Show_TxtBox.CreateGraphics();

            g.DrawEllipse(pen, 1, 1, 10, 10);
            
            if (Convert.ToInt32(ChangedStatesTextBox.Text.Length) > Convert.ToInt32(HowManyStatesTextBox.Text) || Convert.ToInt32(ChangedStatesTextBox.Text.Length) < Convert.ToInt32(HowManyStatesTextBox.Text))
            {
                //Show_TxtBox.FontSize = 36;
                Show_TxtBox.Text += "Error. The string length must equal how many states you wanted to change.";

                TimeStepsLabel.Hide();
                TimeStepsTextBox.Hide();
                ChangedStatesLabel.Hide();
                ChangedStatesTextBox.Hide();
                HowManyStatesLabel.Hide();
                HowManyStatesTextBox.Hide();
                RuleLabel.Hide();
                NumRule_Txt.Hide();
                BTN_Submit.Hide();
                Show_TxtBox.Visible = Visible;
                ReturnButton.Visible = Visible;
            }
            else
            {
                scaling(timeSteps);

                int[] presentState = new int[arraySize];
                int[] previousState = new int[arraySize];

                int changedStates = Convert.ToInt32(ChangedStatesTextBox.Text);
                int numOfChangedStates = Convert.ToInt32(ChangedStatesTextBox.Text.Length);
                int middleOfArray = (arraySize - numOfChangedStates) / 2;


                for (int i = 0; i < arraySize; i++)
                {
                    if (i < middleOfArray)
                    {
                        presentState[i] = 0;
                    }
                    else if (i >= middleOfArray && i <= numOfChangedStates + middleOfArray)
                    {
                        presentState[i] = changedStates % 10;
                        changedStates /= 10;
                    }
                    else if (i > middleOfArray + changedStates)
                    {
                        presentState[i] = 0;
                    }
                }

                Array.Reverse(presentState);


                int time = 0;
                int p, n, caseNum = 0;
                //char choice;
                int[] rule = new int[8];

                int ruleNumber = Convert.ToInt32(NumRule_Txt.Text);

                int ruleNum = Convert.ToInt32(Convert.ToString(ruleNumber, 2).PadLeft(8, '0'));

                // Setting the rule array to contain a single digit of the string of the binary number that the user enters.
                for (int i = rule.Length - 1; i >= 0; i--)
                {
                    rule[i] = ruleNum % 10;
                    ruleNum /= 10;
                }

                //Show_TxtBox.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;

                int midOfArray = arraySize / 2;
                int distanceFromMid = 0;
                Graphics text;

                string s = null;
                //Form1_Paint(sender, e, timeSteps, 9);

                for (int i = 0; i < arraySize; i++)
                {
                    if (presentState[i] == 0)
                    {
                        s += "   ";

                        //Show_TxtBox.Text += "    ";
                    }
                    else
                    {
                        //Show_TxtBox.Text += "\uD83D\uDD34";
                        
                        distanceFromMid = presentState[i] - middleOfArray;
                        drawCircle(timeSteps, distanceFromMid, g);
                        //s += "\uD83D\uDD34";
                    }

                }

                s += "\r\n";

                while (time < Convert.ToInt32(TimeStepsTextBox.Text))
                {
                    for (int i = 0; i < arraySize; i++)
                    {
                        previousState[i] = presentState[i];
                    }
                    for (int i = 0; i < arraySize; i++)
                    {
                        p = i - 1;
                        n = i + 1;
                        caseNum = 0;

                        // *****************************************************************************************************

                        if (p == -1)
                        {
                            caseNum += 2 * previousState[i] + 1 * previousState[n];
                        }
                        else if (n == arraySize)
                        {
                            caseNum += 4 * previousState[p] + 2 * previousState[i];
                        }
                        else
                        {
                            caseNum += 4 * previousState[p] + 2 * previousState[i] + 1 * previousState[n];
                        }

                        switch (caseNum)
                        {
                            case 0:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 1:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 2:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 3:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 4:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 5:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 6:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }
                            case 7:
                                if (rule[7 - caseNum] == 0)
                                {
                                    presentState[i] = 0;
                                    break;
                                }
                                else
                                {
                                    presentState[i] = 1;
                                    break;
                                }

                        }
                    }
                    for (int i = 0; i < arraySize; i++)
                    {
                        if (presentState[i] == 0)
                        {
                            s += "   ";

                            //Show_TxtBox.Text += "    ";
                        }
                        else
                        {
                            //s += "\uD83D\uDD34";
                            distanceFromMid = presentState[i] - middleOfArray;
                            drawCircle(timeSteps, distanceFromMid, g);
                            //Show_TxtBox.Text += "\uD83D\uDD34";
                        }
                    }
                    //Show_TxtBox.Text += "\r\n";
                    s += "\r\n";


                    time++;

                }

                //Show_TxtBox.Text += s;

                Show_TxtBox.Text += "\r\n";
                
            }


        }

        private void InfiniteCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FiniteCB.Checked)
            {
                PeriodicCB.Visible = Visible;
                NullCB.Visible = Visible;
                ArraySizeLabel.Visible = Visible;
                ArraySizeTB.Visible = Visible;
                InfiniteCB.Checked = false;
            }
            if (InfiniteCB.Checked)
            {
                PeriodicCB.Hide();
                NullCB.Hide();
                ArraySizeLabel.Hide();
                ArraySizeTB.Hide();
                FiniteCB.Checked = false;
            }
        }

        private void FiniteCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FiniteCB.Checked)
            {
                PeriodicCB.Visible = Visible;
                NullCB.Visible = Visible;
                ArraySizeLabel.Visible = Visible;
                ArraySizeTB.Visible = Visible;
                InfiniteCB.Checked = false;
            }
            if (InfiniteCB.Checked)
            {
                PeriodicCB.Hide();
                NullCB.Hide();
                ArraySizeLabel.Hide();
                ArraySizeTB.Hide();
                FiniteCB.Checked = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<Point> points = new List<Point>();
            Graphics g;
            g = e.Graphics;    // only ever use this one for persistent graphics!!
            
            g.FillEllipse(Brushes.Red, 1, 1, 10, 10);
            g.FillEllipse(Brushes.Red, 11, 11, 10, 10);
        }

        private Graphics drawCircle(int timesteps, int numFromMid, Graphics graphic)
        {
            float TBheight = 512;
            float TBwidth = 1057;
            float CircHeight = TBheight / timesteps;
            float CircWidth = CircHeight;

            float midOfTB = (TBwidth / 2);

            float xCord = midOfTB + (CircWidth * numFromMid);
            float yCord = timesteps * (CircHeight / 2);

            Pen pen = new Pen(Brushes.Black, 1);            

            graphic.DrawEllipse(pen, xCord, yCord, CircWidth, CircHeight);

            graphic.FillEllipse(Brushes.Red, 1, 1, 10, 10);
            graphic.FillEllipse(Brushes.Red, 11, 11, 10, 10);
            return graphic;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            Graphics g;
        }
    }
}
