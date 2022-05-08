using System;
using System.IO;
using UnityEngine;

namespace ModTemplate
{
    public class MainClass : MonoBehaviour
    {
        public static void Init()
        {
            GameObject mainClassGameObject = new GameObject("Template Mod");
            mainClassGameObject.AddComponent<MainClass>(); 
            DontDestroyOnLoad(mainClassGameObject);
        }

        public void Start()
        {
            Debug.Log("[ModTemplate] : WHO DARE TO SUMMON ME");
        }
    }
}