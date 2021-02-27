using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueGame : MonoBehaviour
{
    public void gameContinue()
    {
        if (GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name != "new"
            && GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name != "0"
            && GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name != "1"
            && GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name != "2")
            SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}