using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class LcmPlugin : IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "LCM Plugin";

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
        public Image Image => Properties.Resources.LcmIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin calculates least common multiple of two integers";

        /// <summary>
        ///     Finds least common multiple of two integers and returns the result
        /// </summary>
        /// <returns>
        ///     Least common multiple of two integers
        /// </returns>
        /// <exception cref="System.ArithmeticException">
        ///    Thrown when at least one of the numbers equals zero
        /// </exception>
        /// <param name="input1">An integer number</param>
        /// <param name="input2">An integer number</param>
        public int Run(int input1, int input2)
        {
            if (input1 == 0 || input2 == 0)
            {
                throw new ArithmeticException("LCM of zero doesn't exist");
            }

            // If some of the numbers is negative, sign of the number is changed to positive
            input1 = (input1 > 0) ? input1 : -input1;
            input2 = (input2 > 0) ? input2 : -input2;

            int a, b;
            if(input1 > input2)
            {
                a = input1;
                b = input2;
            }
            else
            {
                a = input2;
                b = input1;
            }
            for (int i = 1; i < b; i++)
            {
                int mult = a * i;
                if(mult % b == 0)
                {
                    return mult;
                }
            }
            return input1 * input2;

        }
    }
}
