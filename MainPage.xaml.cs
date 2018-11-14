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
        }

        

        private void BTN_Submit_Click(object sender, RoutedEventArgs e)
        {
            Show_TxtBox.IsEnabled = false;
            Show_TxtBox.AcceptsReturn = true;
            Show_TxtBox.Text = string.Empty;
            Show_TxtBox.TextAlignment = TextAlignment.DetectFromContent;

            int timeSteps = Convert.ToInt32(TimeStepsTextBox.Text);
            int arraySize = (2 * timeSteps) + (2 * Convert.ToInt32(HowManyStatesTextBox.Text));

            if (Convert.ToInt32(ChangedStatesTextBox.Text.Length) > Convert.ToInt32(HowManyStatesTextBox.Text) || Convert.ToInt32(ChangedStatesTextBox.Text.Length) < Convert.ToInt32(HowManyStatesTextBox.Text))
            {
                Show_TxtBox.Text += "Error. The string length must equal how many states you wanted to change.";
                return;
            }

            // Determining font size
            if (timeSteps >= 0 && timeSteps <= 7)
            {
                Show_TxtBox.FontSize = 46;
            }
            if (timeSteps > 7 && timeSteps < 12)
            {
                Show_TxtBox.FontSize = 30;
            }
            if (timeSteps >= 12 && timeSteps <= 17)
            {
                Show_TxtBox.FontSize = 20;
            }
            if (timeSteps > 17 && timeSteps <= 40)
            {
                Show_TxtBox.FontSize = 12;
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
            int p, n;
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

            for (int i = 0; i < arraySize; i++)
            {
                if (presentState[i] == 0)
                {
                    Show_TxtBox.Text += "   ";
                }
                else
                {
                    
                    Show_TxtBox.Text += "X ";
                }

            }
            
            Show_TxtBox.Text += "\r\n";

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


                    // *****************************************************************************************************
                    if (p == -1)
                    {
                        if (p == -1 && previousState[i] == 1 && previousState[n] == 1)
                        {
                            if (rule[4] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (p == -1 && previousState[i] == 1 && previousState[n] == 0)
                        {
                            if (rule[5] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (p == -1 && previousState[i] == 0 && previousState[n] == 1)
                        {
                            if (rule[6] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (p == -1 && previousState[i] == 0 && previousState[n] == 0)
                        {
                            if (rule[7] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                    }
                    //**************************************
                    if (n == arraySize)
                    {
                        if (previousState[p] == 1 && previousState[i] == 1 && n == arraySize)
                        {
                            if (rule[1] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 1 && previousState[i] == 0 && n == arraySize)
                        {
                            if (rule[3] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 1 && n == arraySize)
                        {
                            if (rule[5] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 0 && n == arraySize)
                        {
                            if (rule[7] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                    }
                    //**********************************
                    if (p != -1 && n != arraySize)
                    {
                        if (previousState[p] == 1 && previousState[i] == 1 && previousState[n] == 1)
                        {
                            if (rule[0] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 1 && previousState[i] == 1 && previousState[n] == 0)
                        {
                            if (rule[1] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 1 && previousState[i] == 0 && previousState[n] == 1)
                        {
                            if (rule[2] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 1 && previousState[i] == 0 && previousState[n] == 0)
                        {
                            if (rule[3] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 1 && previousState[n] == 1)
                        {
                            if (rule[4] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 1 && previousState[n] == 0)
                        {
                            if (rule[5] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 0 && previousState[n] == 1)
                        {
                            if (rule[6] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                        if (previousState[p] == 0 && previousState[i] == 0 && previousState[n] == 0)
                        {
                            if (rule[7] == 0)
                            {
                                presentState[i] = 0;
                            }
                            else
                            {
                                presentState[i] = 1;
                            }
                        }
                    }
                }

                for (int i = 0; i < arraySize; i++)
                {
                    if (presentState[i] == 0)
                    {
                        Show_TxtBox.Text += "   ";
                    }
                    else
                    {
                        
                        Show_TxtBox.Text += "X ";
                    }
                }
                Show_TxtBox.Text += "\r\n";

                

                time++;

            }

            

           
            
        }

       
    }
}


