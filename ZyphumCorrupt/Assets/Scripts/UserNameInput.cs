using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using TMPro;

public class UserNameInput : MonoBehaviour
{
    private Button_UI ConfirmNewUser;
    private Button_UI CancelNewUser;
    private TextMeshProUGUI displayUserName;
    private TMP_InputField newUserFieldText;

    private void Awake()
    {
        ConfirmNewUser = transform.Find("ConfirmNewUser").GetComponent<Button_UI>();
        CancelNewUser = transform.Find("CancelNewUser").GetComponent<Button_UI>();
        displayUserName = transform.Find("displayUserName").GetComponent<TextMeshProUGUI>();
        newUserFieldText = transform.Find("newUserFieldText").GetComponent<TMP_InputField>();

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