using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayUsername : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        User nameStuff = new User();
        Serializer serialize = new Serializer("Dump.xml");
        serialize.DeserializeUser(out nameStuff);
        GameObject.Find("displayUserName").GetComponent<TextMeshProUGUI>().SetText(nameStuff.Name);
    }
}