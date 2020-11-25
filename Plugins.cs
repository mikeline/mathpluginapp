using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public static class Plugins
    {
        /// <summary>
        ///     Returns the number of all plugins
        /// </summary>
        /// <returns>
        ///     Number of plugins
        /// </returns>
        public static int PluginsCount()
        {
            var pluginInterface = typeof(IPlugin);
            var plugins = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => pluginInterface.IsAssignableFrom(p) && !p.IsInterface);
            return plugins.Count();

        }

        /// <summary>
        ///     Returns all plugin names s
        /// </summary>
        /// <returns>
        ///     
        /// </returns>
        public static string[] GetPluginNames()
        {
            var pluginInterface = typeof(IPlugin);
            var plugins = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => pluginInterface.IsAssignableFrom(p) && !p.IsInterface)
                .ToArray();
            return Array.ConvertAll(plugins, s => s.ToString());
        }

        /// <summary>
        ///     Returns object that implements IPlugin by its name
        /// </summary>
        /// <returns>
        ///     Object that implements IPlugin
        /// </returns>
        /// <param name="pluginName">Name of plugin</param>
        public static IPlugin GetPlugin(string pluginName)
        {
            Type t = Type.GetType(pluginName);
            return (IPlugin) Activator.CreateInstance(t);
        }
    }
}
