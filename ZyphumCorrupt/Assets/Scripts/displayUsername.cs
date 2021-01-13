using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayUsername : MonoBehaviour
{
    private void Awake()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText(GameObject.Find(
            "Zyphum").GetComponent<ZyphumScript>().currentUser.Name);
    }
}