using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormUI
{
    /// <summary>
    /// A type of operation the calculator on perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add, 

        /// <summary>
        /// Takes one value from another
        /// </summary>
        Minus,

        /// <summary>
        /// Divides one number by another
        /// </summary>
        Divide,

        /// <summary>
        /// Multiplies two numbers together
        /// </summary>
        Multiply
    }
}
