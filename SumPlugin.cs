﻿using System;
using System.Drawing;

namespace ds.test.impl
{
    public class SumPlugin : ArithmeticOperation, IPlugin
    {
        /// <summary>
        ///     Returns the name of plugin
        /// </summary>
        /// <returns>
        ///     Name of plugin
        /// </returns>
        public string PluginName => "Sum Plugin";

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
        public Image Image => Properties.Resources.SumIcon;

        /// <summary>
        ///     Returns description of plugin
        /// </summary>
        /// <returns>
        ///     Description of plugin
        /// </returns>
        public string Description => "This plugin will calculate the sum of two numbers";


        /// <summary>
        ///     Adds two integers and returns the result
        /// </summary>
        /// <returns>
        ///     The sum of two integers
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
                    int sum = input1 + input2;
                    return sum;
                }
                catch (OverflowException)
                {
                    throw new OverflowException(String.Format("The prodict of two input values is greater than {0:E} or less than {1:E}", Int32.MaxValue, Int32.MinValue));
                }
            }
        }
    }
}
