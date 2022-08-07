using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class GameLoad : MonoBehaviour
{
   public void OnLoadMenu()
    {
        Menu.Load();
    }

    public void OnLoadGame()
    {
        Game.Load();
    }
}
