using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WolframRules
{
    public partial class Form2 : Form
    {       
        
        public Form2()
        {
            InitializeComponent();

            DisplayVScroll.Minimum = 0;
            DisplayVScroll.Maximum = Form1.HowManyTimeSteps;

            DisplayVScroll.Hide();
            DisplayHScroll.Hide();
            
           
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            /*
            //e.Graphics.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);

            //bool infinite = Form1.isInfinite;
            int timeSteps = Form1.HowManyTimeSteps;
            int arraySize = Form1.sizeOfArray;
            int cts = Form1.currentTimeStep;
            int length = Form1.lengthOfChangedStates;
            int ruleNum = Form1.ruleNumber;

            int[] presentState = new int[arraySize];
            int[] previousState = new int[arraySize];

            int changedStates = Convert.ToInt32(Form1.stringOfChangedStates);
            int numOfChangedStates = Form1.numberOfChangedStates;
            int middleOfArray = (arraySize - numOfChangedStates) / 2;


            if (Form1.isInfinite)
            {
                infinite(arraySize, timeSteps, length, changedStates, ruleNum);
            }
            else if (Form1.isFinite)
            {
                finite(arraySize, timeSteps, length, changedStates, ruleNum);
            }
            
            */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            


        }

        private void ReturnBTNForm2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            
        }

        private void ShowBTNForm2_Click(object sender, EventArgs e)
        {
            
        }

        private void finite(int arraySize, int timeSteps, int length, int[] changedstates, int ruleNumb)
        {

            if (length > changedstates.ToString().Length && length < changedstates.ToString().Length)
            {
                MessageBox.Show("The length of the string must match the number of changed states.");
            }
            else
            {
                //scaling(timeSteps);

                int[] presentState = new int[arraySize];
                int[] previousState = new int[arraySize];
                int[] changedStates = new int[Form1.numberOfChangedStates];

                for (int i = 0; i < Form1.numberOfChangedStates; i++)
                    changedStates[i] = changedstates[i];

                int numOfChangedStates = length;
                int startIndex = (arraySize - numOfChangedStates) / 2;

                Graphics graphics = panel1.CreateGraphics();


                for (int i = 0; i < arraySize; i++)
                {
                    if (i < startIndex)
                    {
                        presentState[i] = 0;
                    }
                    else if (i >= startIndex && i < (numOfChangedStates + startIndex))
                    {
                        presentState[i] = changedStates[i - startIndex];
                        
                    }
                    else if (i > (startIndex + numOfChangedStates))
                    {
                        presentState[i] = 0;
                    }
                }

                Array.Reverse(presentState);


                int time = 0;
                int p, n, caseNum = 0;
                //char choice;
                int[] rule = new int[8];

                int ruleNumber = Convert.ToInt32(ruleNumb);

                int ruleNum = Convert.ToInt32(Convert.ToString(ruleNumber, 2).PadLeft(8, '0'));

                // Setting the rule array to contain a single digit of the string of the binary number that the user enters.
                for (int i = rule.Length - 1; i >= 0; i--)
                {
                    rule[i] = ruleNum % 10;
                    ruleNum /= 10;
                }

                
                drawCircle(timeSteps, arraySize, time, presentState, graphics);

                int[] randomOrder = new int[arraySize];
                if (Form1.isRandom)
                {
                    
                    Random r = new Random();
                    int rint;
                    bool dup;
                    for (int i = 0; i < arraySize; i++)
                    {
                        randomOrder[i] = -1;
                        do
                        {
                            rint = r.Next(0, arraySize);
                            dup = false;
                            for (int j = 0; j <= i-1; j++)
                            {
                                if (rint == randomOrder[j])
                                  dup = true;
                            }

                            if (dup !=true)                            
                                randomOrder[i] = rint;  

                        } while (dup==true);
                    } 
                    
                }

                

                while (time < timeSteps)
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
                        if (Form1.isParallel)
                        {
                            if (Form1.isNB)
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
                            }
                            else if (Form1.isPB)
                            {
                                if (p == -1)
                                {
                                    caseNum += 4 * previousState[arraySize - 1] + 2 * previousState[i] + 1 * previousState[n];
                                }
                                else if (n == arraySize)
                                {
                                    caseNum += 4 * previousState[p] + 2 * previousState[i] + 1 * previousState[0];
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
                        else if (Form1.isSequential)
                        {
                            // Left to Right
                            if (Form1.isLTR)
                            {
                                if (Form1.isNB)
                                {
                                    if (p == -1)
                                    {
                                        caseNum += 2 * previousState[i] + 1 * previousState[n];
                                    }
                                    else if (n == arraySize)
                                    {
                                        caseNum += 4 * presentState[p] + 2 * previousState[i];
                                    }
                                    else
                                    {
                                        caseNum += 4 * presentState[p] + 2 * previousState[i] + 1 * previousState[n];
                                    }
                                }
                                else if (Form1.isPB)
                                {
                                    if (p == -1)
                                    {
                                        caseNum += 4 * previousState[arraySize - 1] + 2 * previousState[i] + 1 * previousState[n];
                                    }
                                    else if (n == arraySize)
                                    {
                                        caseNum += 4 * presentState[p] + 2 * previousState[i] + 1 * presentState[0];
                                    }
                                    else
                                    {
                                        caseNum += 4 * presentState[p] + 2 * previousState[i] + 1 * previousState[n];
                                    }

                                }
                            }
                            // Right To Left
                            else if (Form1.isRTL)
                            {
                                if (Form1.isNB)
                                {
                                    if (p == -1)
                                    {
                                        caseNum += 4 * previousState[arraySize - 2] + 2 * previousState[arraySize - 1];
                                    }
                                    else if (n == arraySize)
                                    {
                                        caseNum += 2 * previousState[arraySize - 1 - i] + 1 * presentState[arraySize - 1 - p];
                                    }
                                    else
                                    {
                                        caseNum += 4 * previousState[arraySize - 1 - n] + 2 * previousState[arraySize - 1 - i] + 1 * presentState[arraySize - 1 - p];
                                    }
                                }
                                else if (Form1.isPB)
                                {
                                    if (p == -1)
                                    {
                                        caseNum += 4 * previousState[arraySize - 1 - n] + 2 * previousState[arraySize - 1 - i] + 1 * previousState[0];
                                    }
                                    else if (n == arraySize)
                                    {
                                        caseNum += 4 * previousState[arraySize - 1] + 2 * previousState[arraySize - 1 - i] + 1 * presentState[arraySize - 1 - p];
                                    }
                                    else
                                    {
                                        caseNum += 4 * previousState[arraySize - 1 - n] + 2 * previousState[arraySize - 1 - i] + 1 * presentState[arraySize - 1 - p];
                                    }
                                }
                               
                            }
                            else if (Form1.isRandom)
                            {
                                if (randomOrder[i] == 0 && Form1.isNB )
                                {
                                    caseNum += 2 * previousState[randomOrder[i]] + 1 * previousState[randomOrder[i]+1];
                                }
                                else if(randomOrder[i]==0 && Form1.isPB)
                                {
                                    caseNum +=4*previousState[arraySize-1]+ 2 * previousState[randomOrder[i]] + 1 * previousState[randomOrder[i] + 1];

                                }
                                else if (randomOrder[i] == arraySize-1 && Form1.isPB )
                                {
                                    caseNum += 4 * previousState[randomOrder[i]-1] + 2 * previousState[randomOrder[i]] + previousState[0];
                                }
                                else if(randomOrder[i]==arraySize-1 && Form1.isNB)
                                {
                                    caseNum += 4 * previousState[randomOrder[i] - 1] + 2 * previousState[randomOrder[i]];

                                }
                                else
                                {
                                    caseNum += 4 * previousState[randomOrder[i]-1] + 2 * previousState[randomOrder[i]] + 1 * previousState[randomOrder[i]+1];
                                }
                       
                            }
                            if (Form1.isLTR)
                            {
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
                            else if (Form1.isRTL)
                            {
                                switch (caseNum)
                                {
                                    case 0:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 1:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 2:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 3:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 4:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 5:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 6:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }
                                    case 7:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[arraySize - 1 - i] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[arraySize - 1 - i] = 1;
                                            break;
                                        }

                                }
                            }
                            else if (Form1.isRandom)
                            {
                                switch (caseNum)
                                {
                                    case 0:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 1:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 2:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 3:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 4:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 5:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 6:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }
                                    case 7:
                                        if (rule[7 - caseNum] == 0)
                                        {
                                            presentState[randomOrder[i]] = 0;
                                            break;
                                        }
                                        else
                                        {
                                            presentState[randomOrder[i]] = 1;
                                            break;
                                        }

                                }
                            }
                        }




                    }

                    // Call drawCircles                   
                    drawCircle(timeSteps, arraySize, time + 1, presentState, graphics);
                    

                    time++;

                    
                }
               

            }
        }

        private void infinite(int arraySize, int timeSteps, int length, int[] changedstates, int ruleNumb)
        {            
            if (length > changedstates.ToString().Length && length < changedstates.ToString().Length)
            {               
                MessageBox.Show("The length of the number of changed states must match the length of the string of changed states.");
            }
            
            else
            {
                //scaling(timeSteps);

                int[] presentState = new int[arraySize];
                int[] previousState = new int[arraySize]; 
                int[] changedStates = new int[Form1.numberOfChangedStates];

                for (int i = 0; i < Form1.numberOfChangedStates; i++)
                    changedStates[i] = changedstates[i];

                int numOfChangedStates = length;
                int startIndex = (arraySize - numOfChangedStates) / 2;

                Graphics graphics = panel1.CreateGraphics();

                for (int i = 0; i < arraySize; i++)
                {
                    if (i < startIndex)
                    {
                        presentState[i] = 0;
                    }
                    else if (i >= startIndex && i < (numOfChangedStates + startIndex))
                    {
                        presentState[i] = changedStates[i- startIndex];
                        //changedStates /= 10;
                    }
                    else if (i > (startIndex + numOfChangedStates))
                    {
                        presentState[i] = 0;
                    }
                }

                Array.Reverse(presentState);


                int time = 0;
                int p, n, caseNum = 0;
                //char choice;
                int[] rule = new int[8];

                int ruleNumber = Convert.ToInt32(ruleNumb);

                int ruleNum = Convert.ToInt32(Convert.ToString(ruleNumber, 2).PadLeft(8, '0'));

                // Setting the rule array to contain a single digit of the string of the binary number that the user enters.
                for (int i = rule.Length - 1; i >= 0; i--)
                {
                    rule[i] = ruleNum % 10;
                    ruleNum /= 10;
                }
                
                
                drawCircle(timeSteps, arraySize, time, presentState, graphics);
                

                while (time < timeSteps)
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

                    
                    
                    drawCircle(timeSteps, arraySize, time + 1, presentState, graphics);

                    
                    time++;
                    
                }
                

            }


        }

        
        private void drawCircle(int timesteps, int arraysize, int currentTimeStep, int[] presentstate, Graphics g)
        {
            g = panel1.CreateGraphics();


            int height = 0;
            int width = 0;
            

            if (Form1.isInfinite)
            {
                height = Screen.PrimaryScreen.Bounds.Height / timesteps;
                width = Screen.PrimaryScreen.Bounds.Width / arraysize;                
            }
            else if (Form1.isFinite)
            {
                height = (Screen.PrimaryScreen.Bounds.Height / timesteps);
                width = (Screen.PrimaryScreen.Bounds.Width / arraysize);
            }
            /*
            if (Form1.isFinite)
            {
                if (timesteps >= 0 && timesteps <= 10)
                {
                    if (Form1.isInfinite)
                    {
                        height = 650 / timesteps;
                        width = 650 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 650 / timesteps;
                        width = 650 / arraysize;
                    }
                }
                else if (timesteps >= 11 && timesteps <= 20)
                {
                    if (Form1.isInfinite)
                    {
                        height = 600 / timesteps;
                        width = 600 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 600 / timesteps;
                        width = 600 / arraysize;
                    }
                }
                else if (timesteps >= 21 && timesteps <= 30)
                {
                    if (Form1.isInfinite)
                    {
                        height = 650 / timesteps;
                        width = 650 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 600 / timesteps * 2;
                        width = 600 / arraysize * 2;
                    }
                }
                else if (timesteps >= 31 && timesteps <= 50)
                {
                    if (Form1.isInfinite)
                    {
                        height = 700 / timesteps;
                        width = 700 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 625 / timesteps * 2;
                        width = 625 / arraysize * 2;
                    }
                }
                else if (timesteps >= 51 && timesteps <= 70)
                {
                    if (Form1.isInfinite)
                    {
                        height = 750 / timesteps;
                        width = 750 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 640 / timesteps * 2;
                        width = 640 / arraysize * 2;
                    }
                }
                else if (timesteps >= 71 && timesteps <= 90)
                {
                    if (Form1.isInfinite)
                    {
                        height = 800 / timesteps;
                        width = 800 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 658 / timesteps * 3;
                        width = 658 / arraysize * 3;
                    }
                }
                else if (timesteps >= 91 && timesteps <= 110)
                {
                    if (Form1.isInfinite)
                    {
                        height = 850 / timesteps;
                        width = 850 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 665 / timesteps * 3;
                        width = 665 / arraysize * 3;
                    }
                }
                else if (timesteps >= 111 && timesteps <= 130)
                {
                    if (Form1.isInfinite)
                    {
                        height = 875 / timesteps;
                        width = 875 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 685 / timesteps * 3;
                        width = 685 / arraysize * 3;
                    }
                }
                else if (timesteps >= 131 && timesteps <= 150)
                {
                    if (Form1.isInfinite)
                    {
                        height = 900 / timesteps;
                        width = 900 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 700 / timesteps * 3;
                        width = 700 / arraysize * 3;
                    }
                }
            }
            else
            {
                if (timesteps >= 0 && timesteps <= 10)
                {
                    if (Form1.isInfinite)
                    {
                        height = 650 / timesteps;
                        width = 650 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 350 / timesteps;
                        width = 350 / arraysize;
                    }
                }
                else if (timesteps >= 11 && timesteps <= 20)
                {
                    if (Form1.isInfinite)
                    {
                        height = 600 / timesteps;
                        width = 600 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 400 / timesteps;
                        width = 400 / arraysize;
                    }
                }
                else if (timesteps >= 21 && timesteps <= 30)
                {
                    if (Form1.isInfinite)
                    {
                        height = 650 / timesteps;
                        width = 650 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 400 / timesteps;
                        width = 400 / arraysize;
                    }
                }
                else if (timesteps >= 31 && timesteps <= 50)
                {
                    if (Form1.isInfinite)
                    {
                        height = 700 / timesteps;
                        width = 700 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 425 / timesteps;
                        width = 425 / arraysize;
                    }
                }
                else if (timesteps >= 51 && timesteps <= 70)
                {
                    if (Form1.isInfinite)
                    {
                        height = 750 / timesteps;
                        width = 750 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 440 / timesteps;
                        width = 440 / arraysize;
                    }
                }
                else if (timesteps >= 71 && timesteps <= 90)
                {
                    if (Form1.isInfinite)
                    {
                        height = 800 / timesteps;
                        width = 800 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 458 / timesteps;
                        width = 458 / arraysize;
                    }
                }
                else if (timesteps >= 91 && timesteps <= 110)
                {
                    if (Form1.isInfinite)
                    {
                        height = 850 / timesteps;
                        width = 850 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 465 / timesteps;
                        width = 465 / arraysize;
                    }
                }
                else if (timesteps >= 111 && timesteps <= 130)
                {
                    if (Form1.isInfinite)
                    {
                        height = 875 / timesteps;
                        width = 875 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 485 / timesteps;
                        width = 485 / arraysize;
                    }
                }
                else if (timesteps >= 131 && timesteps <= 150)
                {
                    if (Form1.isInfinite)
                    {
                        height = 900 / timesteps;
                        width = 900 / arraysize;
                    }
                    else if (Form1.isFinite)
                    {
                        height = 500 / timesteps;
                        width = 500 / arraysize;
                    }
                }
            }
            */

            if (height > width)
            {
                height = width;
            }
            else
            {
                width = height;
            }

            

            if (height < 2)
            {
                height = 2;
                width = 2;
            }

            float xcord = 0;
            float ycord = 0;
            float distanceFromMid = 0;

            float middleOfText = (Screen.PrimaryScreen.Bounds.Width / 2) - 10;
            

            if (WindowState == FormWindowState.Maximized)
            {                
                //middleOfText = 1200 / 2;
            }
           

            for (int i = 0; i < arraysize; i++)
            {
                distanceFromMid = i - ((arraysize / 2) - 1);
                xcord = middleOfText + distanceFromMid * width;
                ycord = (currentTimeStep * height - height / 2) + 15;

                if (presentstate[i] == 1)
                    g.FillEllipse(Brushes.Black, xcord, ycord, width, height);
            }

        }

        private void sizing(int ts, int ars)
        {
            
        }

        

        private void Form2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y);

            //bool infinite = Form1.isInfinite;
            int timeSteps = Form1.HowManyTimeSteps;
            int arraySize = Form1.sizeOfArray;
            int cts = Form1.currentTimeStep;
            int length = Form1.lengthOfChangedStates;
            int ruleNum = Form1.ruleNumber;

            int[] presentState = new int[arraySize];
            int[] previousState = new int[arraySize];
            int[] changedStates = new int[Form1.numberOfChangedStates];

            //MessageBox.Show(Form1.numberOfChangedStates.ToString());

            for (int i = 0; i < Form1.numberOfChangedStates; i++)
            {
                changedStates[i] = Form1.stringOfChangedStates[i];               
            }

            
            //Convert.ToInt64(Form1.stringOfChangedStates);
            
            int numOfChangedStates = Form1.numberOfChangedStates;
            int middleOfArray = (arraySize - numOfChangedStates) / 2;


            if (Form1.isInfinite)
            {
                infinite(arraySize, timeSteps, length, changedStates, ruleNum);
            }
            else if (Form1.isFinite)
            {
                finite(arraySize, timeSteps, length, changedStates, ruleNum);
            }
        }

        private void DisplayVScroll_Scroll(object sender, ScrollEventArgs e)
        {
            //panel1.Location = new Point(DisplayHScroll.Value, DisplayVScroll.Value);
        }

        private void DisplayHScroll_Scroll(object sender, ScrollEventArgs e)
        {
            //panel1.Location = new Point(DisplayHScroll.Value, DisplayVScroll.Value);
        }
    }
}
