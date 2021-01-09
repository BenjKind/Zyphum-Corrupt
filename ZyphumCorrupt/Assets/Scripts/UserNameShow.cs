using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class UserNameShow : MonoBehaviour
{
    [SerializeField] private UserNameInput inputWindow;

    private void Start()
    {
        transform.Find("changeUserBtn").GetComponent<Button_UI>().ClickFunc = () =>
        {
            inputWindow.ShowUserInfo("test1", "test2", () => { }, (string inputText) => { });
        };
    }
}