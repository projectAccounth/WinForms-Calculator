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
        public Form1()
        {
            InitializeComponent();
        }

        bool onAdding = false;

        bool onSubtract = false;

        bool onMultiply = false;

        bool onDivide = false;

        double previousInput = 0;

        private void stopAllAction()
        {
            onAdding = false;

            onSubtract = false;

            onMultiply = false;

            onDivide = false;
        }

        

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
                    if (btn.Name != BUTTON_AC.Name)
                        btn.Enabled = false; ;
        }

        private void enableAllButton()
        {
            mainTextBox.Text = "";
            stopAllAndUpdate();
            foreach (Control control in this.Controls)
                if (control is Button btn)
                    btn.Enabled = true; ;
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
            if (onSubtract || onMultiply || onDivide)
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
            if (onAdding || onMultiply || onDivide)
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
            if (onAdding || onMultiply || onSubtract)
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
            if (onAdding || onMultiply || onSubtract)
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
            }
        }

        private void BUTTON_EQUAL_Click(object sender, EventArgs e)
        {
            if (previousInput == 0)
                return;
            if (mainTextBox.Text == "")
                return;
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
            if (onAdding)
            {
                double output = 0;
                output = previousInput + double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            if (onMultiply)
            {
                double output = 0;

                output = previousInput * double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
            if (onSubtract)
            {
                double output = 0;
                output = previousInput - double.Parse(mainTextBox.Text, CultureInfo.InvariantCulture);
                mainTextBox.Text = output.ToString(CultureInfo.InvariantCulture);
                stopAllAndUpdate();
                clearTextBox(prevInputBox);
            }
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
        }

        
    }
}
