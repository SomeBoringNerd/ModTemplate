using System;
using System.Collections.Generic;
using System.IO;

namespace ModTemplate.Utility
{
    public class ConfigUtility
    {

        MainClass mc;

        /// <summary>
        ///     config file in a dictionary for easier read.
        /// </summary>
        /// <remarks>
        ///     the first string is the name of the option in the config file
        ///     the second string is it's value. Check MainClass::Default_Config for more info
        /// </remarks>
        public Dictionary<string, string> entries = new Dictionary<string, string>();

        /// <summary>
        ///     Initialize the class
        /// </summary>
        /// <param name="mc">Instance of the main ckass</param>
        public ConfigUtility(MainClass mc)
        {
            // try to read the config file
            try
            {
                if (File.Exists(FileUtility.getConfig()))
                {

                    // load the config into the dictionary
                    loadConfig();

                    // check for each entry ...
                    foreach(KeyValuePair<string, string> entry in entries)
                    {
                        // ... for a version check
                        if(entry.Key == "version" && entry.Value != MainClass.MOD_VERS)
                        {
                            resetConfig();
                        }
                    }
                }
                else
                {
                    resetConfig();
                }
            }
            catch { }
        }

        /// <summary>
        ///     Reset the config if the version is missmatched or innexistant
        /// </summary>
        private void resetConfig()
        {
            // clear dictionary
            entries.Clear();

            // delete the file if it existed
            if (File.Exists(FileUtility.getConfig()))
            {
                File.Delete(FileUtility.getConfig());
            }

            // new writer
            StreamWriter writer = new StreamWriter(FileUtility.getConfig());

            // write de default config of the mod
            foreach(string line in MainClass.DEFAULT_CONFIG)
            {
                writer.WriteLine(line);
            }

            // close the file
            writer.Close();

            // reload the config
            loadConfig();
        }

        private void loadConfig()
        {
            // open the config file
            StreamReader reader = new StreamReader(FileUtility.getConfig());
            bool isFinished = false;

            // that way, the first line dont get skipped
            while (!isFinished)
            {
                // read the current line
                string txt = reader.ReadLine();

                // check if it's it empty or not (it mean we are out of the file)
                if (string.IsNullOrEmpty(txt))
                {
                    isFinished = true;
                }
                else
                {
                    // split the line
                    string[] entry = txt.Split(' ');

                    // the name of the entry is the first word found
                    string name = entry[0];
                    string value = "";

                    // make the name and = sign empty
                    entry[0] = "";
                    entry[1] = "";

                    // put back together the string
                    foreach (string text in entry)
                    {
                        value += text + " ";
                    }

                    // trim it and put it in the dictionary
                    value = value.Trim();

                    entries.Add(name, value);
                }
            }

            // close the reader
            reader.Close();
        }
    }
}
