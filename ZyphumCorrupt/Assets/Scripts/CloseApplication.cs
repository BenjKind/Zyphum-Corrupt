using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApplication : MonoBehaviour
{
    // This is where logic will be done to close the game, save everything before it completely closes out and syncs with a server when possible
    public void CloseGame()
    {
        Debug.Log("Saving game...");
        Debug.Log("Closing Application...");
        Application.Quit();
    }
}