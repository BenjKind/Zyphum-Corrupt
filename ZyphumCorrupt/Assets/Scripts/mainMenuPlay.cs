using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuPlay : MonoBehaviour
{
    private void Awake()
    {
        HidePlayOptions();
    }

    // show user info window
    public void ShowPlayOptions()
    {
        gameObject.SetActive(true);
    }

    // hide user info window
    public void HidePlayOptions()
    {
        gameObject.SetActive(false);
    }
}