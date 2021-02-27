using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueGame : MonoBehaviour
{
    public void gameContinue()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}