using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public class EscapeVelocityPlugin : IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "Escape Velocity Plugin";

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
        public Image Image => Properties.Resources.EscapeVelocityIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin will help you calculate the rounded escape velocity for any planet";

        /// <summary>
        ///     Calculates rounded escape velocity for a certain planet based on its mass and radius
        /// </summary>
        /// <returns>
        ///     The rounded escape velocity for a certain planet in km/s
        /// </returns>
        /// <exception cref="System.ArithmeticException">
        ///    Thrown if planet mass or planet radius is 0 or negative
        /// </exception>
        /// <param name="input1">Planet mass as an integer representing how many masses of the Moon it can fit</param>
        /// <param name="input2">Planet radius as an integer in kilometers</param>
        public int Run(int input1, int input2)
        {
            const double gravity = 6.67e-11;
            double planetMass = input1 > 0 ? input1 : throw new ArithmeticException("Planet mass should be greater than 0");
            double planetRadius = input2 > 0 ? input2 : throw new ArithmeticException("Planet radius should be greater than 0");

            checked
            { 
                try
                {
                    // Convert planet mass unit to kilograms from number of Moon masses
                    planetMass = 7.3477e22 * planetMass;

                    // Convert planet radius unit to meters from kilometers
                    planetRadius = 1000 * planetRadius;
                }
                catch (OverflowException)
                {
                    throw new OverflowException("Sorry, this plugin can't work with such big numbers");
                }
                try
                {
                    int result = (int)Math.Round(Math.Sqrt(2 * gravity * planetMass / planetRadius));
                    return result / 1000;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(String.Format("Sorry, your input values give a number greater than {0:E}", Int32.MaxValue));
                }
            }
        }
    }
}
