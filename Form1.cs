using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public List<Button> functionButtons;

        public List<Button> operationButtons;
        public Form1()
        {
            InitializeComponent();

            functionButtons = new List<Button>{
                // BUTTON_NEGATE,
                BUTTON_TAN,
                BUTTON_ATAN,
                BUTTON_SINE,
                BUTTON_ASIN,
                BUTTON_ACOS,
                BUTTON_COS,
                BUTTON_SQRT,
                BUTTON_C,
                BUTTON_LOG,
                BUTTON_LN
            };

            operationButtons = new List<Button>
            {
                BUTTON_ADD,
                BUTTON_SUBTRACT,
                BUTTON_DIVIDE,
                BUTTON_MULTIPLY,
            };
        }

        private double logBaseN(double logBase, double input)
        {
            return Math.Log(input) / Math.Log(logBase);
        }

        

        string functionName = "None";

        const double pi = 3.14159265358979323846264338327;

        // I could've used a string named "operationName" but i fucked up
        // and ended up using these
        bool onAdding = false;

        bool onSubtract = false;

        bool onMultiply = false;

        bool onDivide = false;

        bool onPow = false;

        bool onFunctionUse = false;


        // indicates whether you use radian or not
        bool usesRad = true;


        // value to store the previous buffer
        double previousInput = 0;
        // ans != previousInput
        double ans = default(double);

        // set all values to False
        private void stopAllAction()
        {
            onAdding = false;

            onSubtract = false;

            onMultiply = false;

            onDivide = false;

            onPow = false;

            onFunctionUse = false;
        }
        // my laziness made me make this
        private bool invertBool(bool b)
        {
            if (b)
                return false;
            else
                return true;
        }

        private void updateCurrentAngleUnit()
        {
            if (usesRad)
                ANGLE_INDICATOR.Text = "Currently using: Radian";
            else
                ANGLE_INDICATOR.Text = "Currently using: Degree";
        }

        // update action text, indicating what operation we're using
        private void updateActionText()
        {
            if (onAdding)
                currentActionText.Text = "Current action: Addition";
            else if (onSubtract)
                currentActionText.Text = "Current action: Subtraction";
            else if (onMultiply)
                currentActionText.Text = "Current action: Multiplication";
            else if (onDivide)
                currentActionText.Text = "Current action: Division";
            else if (onPow)
                currentActionText.Text = "Current action: Power";
            else if (onFunctionUse)
                currentActionText.Text = "Current action: using Functions " + $"({functionName})";
            else currentActionText.Text = "Current action: None";
        }

        private void stopAllAndUpdate()
        {
            stopAllAction();
            updateActionText();
            previousInput = 0;
            prevInputBox.Text = "";
        }

        private void disableAllButton()
        {
            stopAllAndUpdate();
            foreach (Control control in this.Controls)
                if (control is Button btn)
                    if (btn != BUTTON_AC)
                        btn.Enabled = false; ;
        }

        private void disableButtonList(List<Button> list)
        {
            foreach (Button btn in list)
            {
                btn.Enabled = false;
            }
        }
        private void enableButtonList(List<Button> list)
        {
            foreach (Button btn in list)
            {
                btn.Enabled = true;
            }
        }

        private void enableAllButton()
        {
            mainTextBox.Text = "";
            stopAllAndUpdate();
            foreach (Control control in this.Controls)
                if (control is Button btn)
                    btn.Enabled = true;
        }


        private Boolean CanConvert(String value, System.Type type)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            return converter.IsValid(value);
        }

        private void clearTextBox(TextBox boxToClear)
        {
            boxToClear.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "0";
        }
        private void BUTTON_DOT_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += ".";
        }
        private void BUTTON_C_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }

        private void BUTTON_AC_Click(object sender, EventArgs e)
        {
            enableAllButton();
            ans = default;
        }

        private void BUTTON_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                // had to throw everything in a try catch because user input is unpredictable
                double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                // resets the calculator and throw a syntax error
                stopAllAndUpdate();
                mainTextBox.Text = "ERROR: Syntax error.";
                disableAllButton();
                return;
            }
            if (onSubtract || onMultiply || onDivide || onPow)
            {
                stopAllAction();
                onAdding = true;
                updateActionText();
            }
            if (mainTextBox.Text != "")
            {
                stopAllAction();
                onAdding = true;
                updateActionText();
                previousInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                prevInputBox.Text = previousInput.ToString(CultureInfo.InvariantCulture);
                mainTextBox.Text = "";
            }
        }

        private void BUTTON_SUBTRACT_Click(object sender, EventArgs e)
        {
            try
            {
                // had to throw everything in a try catch because user input is unpredictable
                double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                // resets the calculator and throw a syntax error
                stopAllAndUpdate();
                mainTextBox.Text = "ERROR: Syntax error.";
                disableAllButton();
                return;
            }
            if (onAdding || onMultiply || onDivide || onPow)
            {
                stopAllAction();
                onSubtract = true;
                updateActionText();
            }
            if (mainTextBox.Text != "")
            {
                stopAllAction();
                onSubtract = true;
                updateActionText();
                previousInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                prevInputBox.Text = previousInput.ToString(CultureInfo.InvariantCulture);
                mainTextBox.Text = "";
            }
        }

        private void BUTTON_MULTIPLY_Click(object sender, EventArgs e)
        {
            try
            {
                // had to throw everything in a try catch because user input is unpredictable
                double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                // resets the calculator and throw a syntax error
                stopAllAndUpdate();
                mainTextBox.Text = "ERROR: Syntax error.";
                disableAllButton();
                return;
            }
            if (onAdding || onMultiply || onSubtract || onPow)
            {
                stopAllAction();
                onMultiply = true;
                updateActionText();
            }
            if (mainTextBox.Text != "")
            {
                stopAllAction();
                onMultiply = true;
                updateActionText();
                previousInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                prevInputBox.Text = previousInput.ToString(CultureInfo.InvariantCulture);
                mainTextBox.Text = "";
            }
        }

        private void BUTTON_DIVIDE_Click(object sender, EventArgs e)
        {
            try
            {
                // had to throw everything in a try catch because user input is unpredictable
                double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                // resets the calculator and throw a syntax error
                stopAllAndUpdate();
                mainTextBox.Text = "ERROR: Syntax error.";
                disableAllButton();
                return;
            }
            if (onAdding || onMultiply || onSubtract || onPow)
            {
                stopAllAction();
                onDivide = true;
                updateActionText();
            }
            if (mainTextBox.Text != "")
            {
                stopAllAction();
                onDivide = true;
                updateActionText();
                previousInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture); ;
                prevInputBox.Text = previousInput.ToString(CultureInfo.InvariantCulture);
                mainTextBox.Text = "";
            }
        }

        private void BUTTON_NEGATE_Click(object sender, EventArgs e)
        {
            // logic handling on function use
            if (!onFunctionUse)
            {
                try
                {
                    // had to throw everything in a try catch because user input is unpredictable
                    double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    // resets the calculator and throw a syntax error
                    stopAllAndUpdate();
                    mainTextBox.Text = "ERROR: Syntax error.";
                    disableAllButton();
                    return;
                }
                if (mainTextBox.Text != "")
                {
                    double negatedInput = 0;
                    negatedInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                    negatedInput = -negatedInput;
                    mainTextBox.Text = negatedInput.ToString(CultureInfo.InvariantCulture);
                    return;
                }
            }
            mainTextBox.Text += "-";
            return;
        }

        private void BUTTON_EQUAL_Click(object sender, EventArgs e)
        {
            // check whether the previous input is empty and is not using a func
            if (previousInput == 0 && !onFunctionUse)
                return;
            // check if there's something in the main input box
            if (mainTextBox.Text == "")
                return;
            // try-catch to handle gibberish user input
            if (!onFunctionUse)
            {
                try
                {
                    // had to throw everything in a try catch because user input is unpredictable
                    double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    // resets the calculator and throw a syntax error
                    stopAllAndUpdate();
                    mainTextBox.Text = "ERROR: Syntax error.";
                    disableAllButton();
                    return;
                }
            }
            // handle adding operations
            if (onAdding)
            {
                double output = 0;
                output = previousInput + double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            // handle multiplications
            if (onMultiply)
            {
                double output = 0;

                output = previousInput * double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            // handle subtractions
            if (onSubtract)
            {
                double output = 0;
                output = previousInput - double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            // handle divisions
            if (onDivide)
            {
                double output = 0;

                if (double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture) == 0.0)
                {
                    stopAllAndUpdate();
                    clearTextBox(prevInputBox);
                    mainTextBox.Text = "ERROR: Division by zero.";
                    disableAllButton();
                    return;
                }

                output = previousInput / double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            // handle powers
            if (onPow)
            {
                if (double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture) == 0)
                {
                    stopAllAndUpdate();
                    clearTextBox(prevInputBox);
                    mainTextBox.Text = "ERROR: Undefined behaviour.";
                    disableAllButton();
                    return;
                }
                double output = 0;
                output = Math.Pow(previousInput, double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture));
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            // handle function uses (sqrt, tan, atan, etc...)
            if (onFunctionUse)
            {
                // used switch for less keystrokes
                switch (functionName)
                {
                    // i'll take case sqrt as the base; all other cases are basically the same
                    case "sqrt":
                        {
                            // the output after the operation
                            double finalOutput = 0;
                            // when the equal button is pressed, quickly omit sqrt to get the number needed to perform operations
                            // i was lazy so i did this
                            mainTextBox.Text = mainTextBox.Text.Replace("sqrt ", string.Empty);
                            // a tryparse to indicate whether the input number was gibberish (empty as well) or valid
                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                // resets the calculator and indicates an error
                                disableAllButton();
                                stopAllAndUpdate();
                                // useless function call btw
                                clearTextBox(prevInputBox);

                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // calculate the final output
                            finalOutput = Math.Sqrt(finalOutput);
                            // use toString with invariantCulture
                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);
                            // literally resets the state of the calculator
                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "tan":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("tan ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= pi / 180;
                            }

                            finalOutput = Math.Tan(finalOutput);



                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "atan":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("atan ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };


                            finalOutput = Math.Atan(finalOutput);

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= 180 / pi;
                            }

                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "sin":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("sin ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= finalOutput *= pi / 180;
                            }

                            finalOutput = Math.Sin(finalOutput);



                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "asin":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("asin ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };


                            finalOutput = Math.Asin(finalOutput);

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= 180 / pi;
                            }

                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "cos":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("cos ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= pi / 180;
                            }

                            finalOutput = Math.Cos(finalOutput);



                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "acos":
                        {
                            double finalOutput = 0;

                            mainTextBox.Text = mainTextBox.Text.Replace("acos ", string.Empty);

                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                disableAllButton();
                                stopAllAndUpdate();
                                clearTextBox(prevInputBox);
                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };


                            finalOutput = Math.Acos(finalOutput);

                            // check whether radian or degree is used
                            if (!usesRad)
                            {
                                finalOutput *= 180 / pi;
                            }

                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);

                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "log":
                        {
                            // the output after the operation
                            double finalOutput = 0;
                            // when the equal button is pressed, quickly omit sqrt to get the number needed to perform operations
                            // i was lazy so i did this
                            mainTextBox.Text = mainTextBox.Text.Replace("log ", string.Empty);
                            // a tryparse to indicate whether the input number was gibberish (empty as well) or valid
                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                // resets the calculator and indicates an error
                                disableAllButton();
                                stopAllAndUpdate();
                                // useless function call btw
                                clearTextBox(prevInputBox);

                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // calculate the final output
                            finalOutput = Math.Log10(finalOutput);
                            // use toString with invariantCulture
                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);
                            // literally resets the state of the calculator
                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                    case "ln":
                        {
                            // the output after the operation
                            double finalOutput = 0;
                            // when the equal button is pressed, quickly omit sqrt to get the number needed to perform operations
                            // i was lazy so i did this
                            mainTextBox.Text = mainTextBox.Text.Replace("ln ", string.Empty);
                            // a tryparse to indicate whether the input number was gibberish (empty as well) or valid
                            if (!double.TryParse(mainTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out finalOutput))
                            {
                                // resets the calculator and indicates an error
                                disableAllButton();
                                stopAllAndUpdate();
                                // useless function call btw
                                clearTextBox(prevInputBox);

                                mainTextBox.Text = "ERROR: Unknown error.";
                                break;
                            };

                            // calculate the final output
                            finalOutput = Math.Log(finalOutput);
                            // use toString with invariantCulture
                            mainTextBox.Text = finalOutput.ToString(CultureInfo.InvariantCulture);
                            // literally resets the state of the calculator
                            stopAllAndUpdate();
                            enableButtonList(functionButtons);

                            functionName = "None";

                            break;
                        }
                }
                onFunctionUse = false;
                return;
            }


            // check whether the output after calculating is infinity or not (to prevent unexpected user inputs, such as
            // adding more to the output text (like "Infinity1" or "Infinity4281" or just things like that).
            if (Double.IsInfinity(double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture)))
            {
                stopAllAndUpdate();
                disableAllButton();
                return;
            }
            if (Double.IsNaN(double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture)))
            {
                stopAllAndUpdate();
                disableAllButton();
                mainTextBox.Text = "ERROR: Math error.";
                return;
            }
            ans = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
        }

        private void BUTTON_POW_Click(object sender, EventArgs e)
        {
            try
            {
                // had to throw everything in a try catch because user input is unpredictable
                double result = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                // resets the calculator and throw a syntax error
                stopAllAndUpdate();
                mainTextBox.Text = "ERROR: Syntax error.";
                disableAllButton();
                return;
            }
            if (onAdding || onMultiply || onSubtract || onDivide)
            {
                stopAllAction();
                onPow = true;
                updateActionText();
            }
            if (mainTextBox.Text != "")
            {
                stopAllAction();
                onPow = true;
                updateActionText();
                previousInput = double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture); ;
                prevInputBox.Text = previousInput.ToString(CultureInfo.InvariantCulture);
                mainTextBox.Text = "";
            }
        }

        private void BUTTON_BKSP_Click(object sender, EventArgs e)
        {
            // check if something exists in the box (otherwise it'll throw a runtime error indicating
            // there's nothing to delete)
            if (mainTextBox.Text.Length > 0)
            {
                // handling in case you're using functions
                if (onFunctionUse)
                {
                    switch (functionName)
                    {
                        // handle functions with 4 letters
                        case "sqrt":
                        case "atan":
                        case "asin":
                        case "acos":
                            {
                                // this will check whether the user has entered something or not, if 
                                // the user entered something it will delete the last character that the user entered
                                if (mainTextBox.Text.Length != 5)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
                                    break;
                                }
                                // a for loop to delete the function name (with space, as the functions are written as
                                // "func "), and also to generalize btw
                                for (int i = 4; i >= 0; --i)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(i);
                                    // after deleting the function, resets the calculator and reenable all function buttons
                                    stopAllAndUpdate();
                                    enableButtonList(functionButtons);
                                }
                                break;
                            }
                        case "log":
                        case "sin":
                        case "cos":
                        case "tan":
                            {
                                // this will check whether the user has entered something or not, if 
                                // the user entered something it will delete the last character that the user entered
                                if (mainTextBox.Text.Length != 4)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
                                    break;
                                }
                                // a for loop to delete the function name (with space, as the functions are written as
                                // "func "), and also to generalize btw
                                for (int i = 3; i >= 0; --i)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(i);
                                    // after deleting the function, resets the calculator and reenable all function buttons
                                    stopAllAndUpdate();
                                    enableButtonList(functionButtons);
                                }
                                break;
                            }
                        case "ln":
                            {
                                // this will check whether the user has entered something or not, if 
                                // the user entered something it will delete the last character that the user entered
                                if (mainTextBox.Text.Length != 3)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
                                    break;
                                }
                                // a for loop to delete the function name (with space, as the functions are written as
                                // "func "), and also to generalize btw
                                for (int i = 2; i >= 0; --i)
                                {
                                    mainTextBox.Text = mainTextBox.Text.Remove(i);
                                    // after deleting the function, resets the calculator and reenable all function buttons
                                    stopAllAndUpdate();
                                    enableButtonList(functionButtons);
                                }
                                break;
                            }
                    }
                }
                else
                    // if you're not using a function then this will remove the last character you entered
                    mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
        }

        private void BUTTON_SQRT_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "sqrt";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "sqrt ";
        }

        private void BUTTON_TAN_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "tan";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "tan ";
        }

        private void BUTTON_ATAN_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "atan";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "atan ";
        }

        private void BUTTON_SINE_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "sin";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "sin ";
        }

        private void BUTTON_ASIN_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "asin";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "asin ";
        }

        private void BUTTON_COS_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "cos";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "cos ";
        }

        private void BUTTON_ACOS_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "acos";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "acos ";
        }

        private void DEG_RAD_TOGGLE_Click(object sender, EventArgs e)
        {
            usesRad = invertBool(usesRad);
            updateCurrentAngleUnit();
        }

        private void BUTTON_LOG_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "log";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "log ";
        }

        private void BUTTON_LN_Click(object sender, EventArgs e)
        {
            stopAllAndUpdate();
            onFunctionUse = true;
            functionName = "ln";
            updateActionText();
            disableButtonList(functionButtons);
            mainTextBox.Text = "ln ";
        }

        private void BUTTON_CONST_PI_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += pi.ToString(CultureInfo.InvariantCulture);
        }

        private void BUTTON_CONST_E_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += Math.E.ToString(CultureInfo.InvariantCulture);
        }

        private void BUTTON_ANS_Click(object sender, EventArgs e)
        {
            if (ans != default(double))
            {
                mainTextBox.Text += ans.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
