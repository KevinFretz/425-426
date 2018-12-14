using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using System.Windows.Input;
using System.Text;
using System.IO;
using Windows.UI;
//using System.Drawing;








// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _425_426
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Show_TxtBox.Visibility = Visibility.Collapsed;
            ReturnButton.Visibility = Visibility.Collapsed;
        }

        

        private void BTN_Submit_Click(object sender, RoutedEventArgs e)
        {
            Show_TxtBox.Visibility = Visibility.Visible;
            Show_TxtBox.IsEnabled = false;
            Show_TxtBox.AcceptsReturn = true;
            Show_TxtBox.Text = string.Empty;
            Show_TxtBox.TextAlignment = TextAlignment.DetectFromContent;
            Show_TxtBox.IsColorFontEnabled = true;

            
            int timeSteps = Convert.ToInt32(TimeStepsTextBox.Text);
            int arraySize = (2 * timeSteps) + (2 * Convert.ToInt32(HowManyStatesTextBox.Text));

            if (Convert.ToInt32(ChangedStatesTextBox.Text.Length) > Convert.ToInt32(HowManyStatesTextBox.Text) || Convert.ToInt32(ChangedStatesTextBox.Text.Length) < Convert.ToInt32(HowManyStatesTextBox.Text))
            {
                Show_TxtBox.Text += "Error. The string length must equal how many states you wanted to change.";
                return;
            }

            // Determining font size
            if (ChangedStatesTextBox.Text.Length <= 2)
            {
                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.FontSize = 26;
                }
                if (timeSteps > 7 && timeSteps <= 12)
                {
                    Show_TxtBox.FontSize = 16;
                }
                if (timeSteps > 12 && timeSteps <= 17)
                {
                    Show_TxtBox.FontSize = 11.6;
                }
                if (timeSteps > 17 && timeSteps <= 28)
                {
                    Show_TxtBox.FontSize = 7;
                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.FontSize = 6.5;
                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.FontSize = 5;
                }
                if (timeSteps > 41 && timeSteps <= 50)
                {
                    Show_TxtBox.FontSize = 4;
                }
                if (timeSteps > 51 && timeSteps <= 68)
                {
                    Show_TxtBox.FontSize = 3;
                }
                if (timeSteps > 68 && timeSteps <= 100)
                {
                    Show_TxtBox.FontSize = 2;
                }
            }
            else if (ChangedStatesTextBox.Text.Length > 2 && ChangedStatesTextBox.Text.Length <= 4)
            {
                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.FontSize = 20;
                }
                if (timeSteps > 7 && timeSteps <= 12)
                {
                    Show_TxtBox.FontSize = 12;
                }
                if (timeSteps > 12 && timeSteps <= 17)
                {
                    Show_TxtBox.FontSize = 8;
                }
                if (timeSteps > 17 && timeSteps <= 22)
                {
                    Show_TxtBox.FontSize = 6;
                }
                if (timeSteps > 22 && timeSteps <= 28)
                {
                    Show_TxtBox.FontSize = 4;
                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.FontSize = 3;
                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.FontSize = 2.5;
                }
                if (timeSteps > 41 && timeSteps <= 50)
                {
                    Show_TxtBox.FontSize = 2;
                }
                if (timeSteps > 51 && timeSteps <= 100)
                {
                    Show_TxtBox.FontSize = 1.5;
                }
            }
            else if (ChangedStatesTextBox.Text.Length > 2 && ChangedStatesTextBox.Text.Length <= 4)
            {
                if (timeSteps >= 0 && timeSteps <= 7)
                {
                    Show_TxtBox.FontSize = 18;
                }
                if (timeSteps > 7 && timeSteps < 12)
                {
                    Show_TxtBox.FontSize = 10;
                }
                if (timeSteps >= 12 && timeSteps <= 17)
                {
                    Show_TxtBox.FontSize = 8;
                }
                if (timeSteps > 17 && timeSteps <= 22)
                {
                    Show_TxtBox.FontSize = 5.5;
                }
                if (timeSteps > 22 && timeSteps <= 28)
                {
                    Show_TxtBox.FontSize = 5;
                }
                if (timeSteps > 28 && timeSteps <= 31)
                {
                    Show_TxtBox.FontSize = 4;
                }
                if (timeSteps > 31 && timeSteps <= 40)
                {
                    Show_TxtBox.FontSize = 3;
                }
                if (timeSteps > 41 && timeSteps <= 50)
                {
                    Show_TxtBox.FontSize = 2;
                }
                if (timeSteps > 51 && timeSteps <= 100)
                {
                    Show_TxtBox.FontSize = 1.5;
                }
            }

            
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

            Show_TxtBox.HorizontalAlignment = HorizontalAlignment.Center;

            string s = null;

            for (int i = 0; i < arraySize; i++)
            {
                if (presentState[i] == 0)
                {
                    s += "     ";
                    
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
                        s += "     ";
                        
                        //Show_TxtBox.Text += "    ";
                    }
                    else
                    {
                       s += "\uD83D\uDD34";                     
                       
                       //Show_TxtBox.Text += "\uD83D\uDD34";
                    }
                }
                //Show_TxtBox.Text += "\r\n";
                s+= "\r\n";


                time++;

            }

            Show_TxtBox.Text += s;

                       

            TimeStepsLabel.Visibility = Visibility.Collapsed;
            TimeStepsTextBox.Visibility = Visibility.Collapsed;
            ChangedStatesLabel.Visibility = Visibility.Collapsed;
            ChangedStatesTextBox.Visibility = Visibility.Collapsed;
            HowManyStatesLabel.Visibility = Visibility.Collapsed;
            HowManyStatesTextBox.Visibility = Visibility.Collapsed;
            RuleLabel.Visibility = Visibility.Collapsed;
            NumRule_Txt.Visibility = Visibility.Collapsed;
            BTN_Submit.Visibility = Visibility.Collapsed;
            ReturnButton.Visibility = Visibility.Visible;

            
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            TimeStepsLabel.Visibility = Visibility.Visible;
            TimeStepsTextBox.Visibility = Visibility.Visible;
            ChangedStatesLabel.Visibility = Visibility.Visible;
            ChangedStatesTextBox.Visibility = Visibility.Visible;
            HowManyStatesLabel.Visibility = Visibility.Visible;
            HowManyStatesTextBox.Visibility = Visibility.Visible;
            RuleLabel.Visibility = Visibility.Visible;
            NumRule_Txt.Visibility = Visibility.Visible;
            BTN_Submit.Visibility = Visibility.Visible;
            Show_TxtBox.Visibility = Visibility.Collapsed;
            ReturnButton.Visibility = Visibility.Collapsed;

            return;
        }

        
    }
}