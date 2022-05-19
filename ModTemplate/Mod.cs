using ModTemplate;
/*
 *  welcome to the Unity Mod Template
 * 
 *  to get started, replace ModTemplate by the name of your mod
 *  it's very important because two mods with the same name won't
 *  do any good for you, or the players.
 * 
 *  change the namespace and the class name to the name of your mod.
 *  With most modern IDE, you can replace the occurance of a word
 *  in every class of your solution easely, just do that.
 * 
 *  dont forget to rename the folders.
 * 
 *  the next step will be to go in the MainClass class
 *  and edit the DEFAULT_CONFIG variable.
 * 
 *  after that, import the assembly-csharp.dll of the game
 *  you want to mod. under ModTemplate/Mod/Scenes, 
 *  create folder with the scene's name (not mandatory, just good practice)
 * 
 *  And now, create a new class (see ModTemplate/Mod/Scenes/MainMenu/MainMenu.cs for an exemple)
 * 
 * 
 */
namespace Loader
{
    public static class ModTemplate
    {
        public static void Init()
        {
            MainClass.Init();
        }
    }
}