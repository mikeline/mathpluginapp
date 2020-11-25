using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public class MultiplicationPlugin : ArithmeticOperation, IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "Multiplication Plugin";

        /// <summary>
        ///     Returns version of plugin
        /// </summary>
        /// <returns>
        ///     Version of plugin
        /// </returns>
        public string Version => "1.0";

        /// <summary>
        ///     Returns icon of plugin
        /// </summary>
        /// <returns>
        ///     Icon of plugin
        /// </returns>
        public Image Image => Properties.Resources.MultiplicationIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin will calculate the product of two numbers";

        /// <summary>
        ///     Multiplies two integers and returns the result
        /// </summary>
        /// <returns>
        ///     The product of two integers
        /// </returns>
        /// <exception cref="System.OverflowException">
        ///    Thrown when the product of two integers exceeds <see cref="Int32.MaxValue"/> or is inferior to <see cref="Int32.MinValue"/>
        /// </exception>
        /// <param name="input1">An integer number</param>
        /// <param name="input2">An integer number</param>
        public int Run(int input1, int input2)
        {
            checked
            {
                try
                {
                    int product = input1 * input2;
                    return product;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(String.Format("The prodict of two input values is greater than {0:E} or less than {1:E}", Int32.MaxValue, Int32.MinValue));
                }
            }
        }
    }
}
