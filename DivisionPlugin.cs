using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public class DivisionPlugin : ArithmeticOperation, IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "Division Plugin";

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
        public Image Image => Properties.Resources.DivisionIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin will calculate the division of two numbers cast to an integer";

        /// <summary>
        ///     Divides first integer by the second one and returns the result cast to an integer
        /// </summary>
        /// <returns>
        ///     The division of first integer by the second one cast to an integer
        /// </returns>
        /// <exception cref="System.ArithmeticException">
        ///    Thrown when divider equals zero
        /// </exception>
        /// <param name="input1">An integer number</param>
        /// <param name="input2">An integer number</param>
        public int Run(int input1, int input2)
        {
            try
            {
                int division = input1 / input2;
                return division;
            }
            catch (ArithmeticException)
            {
                throw new ArithmeticException("Division by 0 is not allowed");
            }
        }
    }
}
