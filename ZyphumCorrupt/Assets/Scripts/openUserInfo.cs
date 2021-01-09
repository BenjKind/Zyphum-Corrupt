using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openUserInfo : MonoBehaviour
{
    private void Awake()
    {
        HideUserInfo();
    }

    // show user info window
    public void ShowUserInfo()
    {
        gameObject.SetActive(true);
    }

    // hide user info window
    public void HideUserInfo()
    {
        gameObject.SetActive(false);
    }
}