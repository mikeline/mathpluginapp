using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class GcdPlugin : IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "GCD Plugin";

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
        public Image Image => Properties.Resources.GcdIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin calculates greatest common divisor of two integers";

        /// <summary>
        ///     Finds greatest common divisor of two integers and returns the result
        /// </summary>
        /// <returns>
        ///     Greatest common divisor of two integers
        /// </returns>
        /// <exception cref="System.ArithmeticException">
        ///    Thrown when both numbers equal zero
        /// </exception>
        /// <param name="input1">An integer number</param>
        /// <param name="input2">An integer number</param>
        public int Run(int input1, int input2)
        {
            if(input1 == 0 && input2 == 0)
            {
                throw new ArithmeticException("The gcd(0,0) is not defined");
            }
            if(input1 == 0 || input2 == 0)
            {
                return input1 == 0 ? input1 : input2;
            }

            // If some of the numbers is negative, sign of the number is changed to positive
            input1 = (input1 > 0) ? input1 : -input1;
            input2 = (input2 > 0) ? input2 : -input2;
            while (input1 != input2)
            {
                if(input1 > input2)
                {
                    input1 -= input2;
                }
                else
                {
                    input2 -= input1;
                }
            }
            return input1;
        }
    }
}
