using System;
using UnityEngine;

namespace ModTemplate
{
    public class ModdedBehavior : MonoBehaviour
    {
        // standardized method of logging stuff
        public void log(string text)
        {
            Debug.Log("[" + MainClass.MOD_NAME + "] : " + text);
        }
    }
}
