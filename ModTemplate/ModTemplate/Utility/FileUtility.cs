using System;
using UnityEngine;

namespace ModTemplate.Utility
{
    public class FileUtility
    {
        private MainClass main;

        public FileUtility(MainClass mc)
        {
            main = mc;
        }

        /// <summary>
        ///     Return a path that will work on Windows and Linux
        /// </summary>
        /// <param name="path">Path that the code will translate</param>
        /// <returns></returns>
        public static string returnUniversalPath(string path)
        {
            return path.Replace("\\", "/");
        }

        public static string getModPath()
        {
            return returnUniversalPath(Application.streamingAssetsPath + "/Mods/" + MainClass.MOD_NAME + "/");
        }

        public static string getConfig()
        {
            return returnUniversalPath(getModPath() + "config.cfg");
        }
    }
}
