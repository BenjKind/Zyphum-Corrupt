using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApplication : MonoBehaviour
{
    // This is where logic will be done to close the game, save everything before it completely closes out and syncs with a server when possible
    public void CloseGame()
    {
        // TODO: Save current user as the last save so you can quick load data to update your save incase user gets off quickly.
        Debug.Log("Saving game...");
        Debug.Log("Closing Application...");
        Application.Quit();
    }
}