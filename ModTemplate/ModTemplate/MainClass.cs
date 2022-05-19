using System;
using System.IO;
using UnityEngine;
using ModTemplate.Utility;
using UnityEngine.SceneManagement;

namespace ModTemplate
{
    public class MainClass : MonoBehaviour
    {

        public ConfigUtility config;
        public FileUtility fileUtility;

        public static string MOD_NAME = "ModTemplate";
        public static string MOD_DESC = "Template for unity mods with a few utility";
        public static string MOD_VERS = "1.0.2";
        public static string[] MOD_AUTH = new string[]
        {
            "SomeBoringNerd"
        };

        /// <summary>
        ///     array that contain the default config file if none is found.
        /// </summary>
        /// <remarks>
        ///     while it's supposed to be changed, please DO NOT REMOVE THE VERSION FIELD
        ///     EDIT THAT OR EDIT ConfigUtility TO REMOVE THE VERSION CHECK !!!!
        /// </remarks>
        public static readonly string[] DEFAULT_CONFIG = new string[]
        {
            "version" + MOD_VERS,
            "string = this is a phrase exemple",
            "string2 = text",
            "int = 1234",
            "bool = true",
            "color = yellow"
        };

        public static void Init()
        {
            GameObject mainClassGameObject = new GameObject("Template Mod");
            mainClassGameObject.AddComponent<MainClass>(); 
            DontDestroyOnLoad(mainClassGameObject);
        }

        public void Start()
        {
            config = new ConfigUtility(this);
            fileUtility = new FileUtility(this);
        }


        /// <summary>
        /// Launched every time a scene is loaded
        /// use that to launch scene specific scripts
        /// </summary>
        public static void SceneLoaded(Scene scene, LoadSceneMode mode)
        {
            // if you don't know the name of a scene, just use that
            // (enable the ModLoader's logging)
            Debug.Log(scene.name + " was loaded at index " + scene.buildIndex);

            switch (scene.name)
            {
                case "MainMenu":

                    GameObject mainMenuScript = new GameObject("MainMenu");
                    mainMenuScript.AddComponent<MainMenu>();

                    break;
            }
        }
    }
}