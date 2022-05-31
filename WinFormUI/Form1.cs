using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text 
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>

        private void CEbutton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;
            FocusInputText();
        }
  
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();
            FocusInputText();
        }
       
        #endregion


        #region Operator Method

        private void Divide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }


        private void Number7Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void Number9Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void MultipleButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void Number4Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void Number1Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void Number2Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void DottButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }

        private void Number6Button_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        #endregion


        #region Private Helpers
        /// <summary>
        /// Focus the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        private void InsertTextValue(string number)
        {
            var selectionStart = this.UserInputText.SelectionStart;
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.Text.Length, number);
            this.UserInputText.SelectionStart = selectionStart + number.Length;
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>

        private void DeleteTextValue()
        {
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            var selectionStart = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            
            this.UserInputText.SelectionStart = selectionStart;            

            this.UserInputText.SelectionLength = 0;
        }


        #endregion


        #region Number Method
        /// <summary>
        /// Calculate the given equation and outputs the answer
        /// </summary>

        private void CalculateEquation()
        {
            var userInput = this.UserInputText.Text;

            this.CalculationText.Text = ParseOperation();

            FocusInputText();
        }
        /// <summary>
        /// Parse the users equation and calculates the result
        /// </summary>
        /// <returns></returns>

        private string ParseOperation()
        {
            try
            {
                //Get the users equation input
                var userInput = this.UserInputText.Text;

                //remove all spaces
                userInput = userInput.Replace(" ", "");

                //create a new top-level operation
                var operation = new Operation();

                var leftSide = true;              

                for (var i = 0; i < userInput.Length; i++)
                {
                    //check if the input is a number
                    var myStr = "0123456789.";

                    if (myStr.Any(c => c == userInput[i]))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, userInput[i]);
                        }
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, userInput[i]);
                    }

                    // Check if the entry is an operator ("+-*/") and set the operator type
                    else if ("+-*/".Any(c => c == userInput[i]))
                    {
                        //If we are on the right side already, we now need to calculate our own operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            //Get the operator type
                            var operatorType = GetOperationType(userInput[i]);
                        }
                        else
                        {
                            //get the operator type
                            var operatorType = GetOperationType(userInput[i]);

                            //Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                //check the operator is not a negative number
                                if(operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException("The operators used improperly. ");
                                }

                                //if - is not operator, then that is a negative value
                                operation.LeftSide += userInput[i];
                            }
                            else
                            {
                                //in this block, you have a left number and an operator and then we are trying to figure out the sight number
                                
                                //set the operation type
                                operation.OperationType = operatorType;

                                //move to the right number
                                leftSide = false;
                            }
                        }
                    }
                }

                //if we are done parsing and there were no exceptions, calculate the current operation
                return CalculateOperation(operation);
            }
            catch (Exception)
            {
                return $"Invalid equation"; 
            }
        }

        /// <summary>
        /// Calculatesa an <see cref="Operation"/> and returns a result
        /// </summary>
        /// <param name="operation"></param>
        private string CalculateOperation(Operation operation)
        {
            //store the number values of the string representation
            double left = 0;
            double right = 0;
            
            //check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
            {
                throw new InvalidOperationException("Left side of the operation was not a number.");
            }

            //check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException("Right side of the operation was not a number.");
            }

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException("Unknown operator type when calculating");
                }
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Failed to calculate operation");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentChar">The cew character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newChar)
        {
            //chech if there are multiple . contained in the current string
            if (newChar == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException("Number already contains a . and another cannot be added");
            }

            return currentNumber + newChar;
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="charactor">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char charactor)
        {
            switch(charactor)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException("Unknown operator type");
            }
        }
        #endregion
    }
}
