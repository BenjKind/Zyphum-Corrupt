using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayUsername : MonoBehaviour
{
    private void Awake()
    {
        string newUser = "No User";
        if (GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name == "new"
            || GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name == "0"
            || GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name == "1"
            || GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.Name == "2")
            gameObject.GetComponent<TextMeshProUGUI>().SetText(newUser);
        else
            gameObject.GetComponent<TextMeshProUGUI>().SetText(GameObject.Find(
            "Zyphum").GetComponent<ZyphumScript>().currentUser.Name);
    }
}