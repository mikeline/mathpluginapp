using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public class RemainderPlugin : ArithmeticOperation, IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "Remainder Plugin";

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
        public Image Image => Properties.Resources.RemainderIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin will calculate the remainder after dividing first number by the second one";

        /// <summary>
        ///     Finds remainder after dividing first number by the second one and returns the result
        /// </summary>
        /// <returns>
        ///     Remainder after dividing first number by the second one
        /// </returns>
        /// <exception cref="System.ArithmeticException">
        ///    Thrown when the second number equals zero
        /// </exception>
        /// <param name="input1">An integer number</param>
        /// <param name="input2">An integer number</param>
        public int Run(int input1, int input2)
        {
            try
            {
                return input1 % input2;
            }
            catch(ArithmeticException)
            {
                throw new ArithmeticException("Second number can't be zero");
            }
        }
    }
}
