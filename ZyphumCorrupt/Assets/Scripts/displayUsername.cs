using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayUsername : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameObject.Find("yay").GetComponent<NewBehaviourScript>().Arachnae.Name;
        //GameObject userNameImage = GameObject.Find("displayUserName");
        //User test = userNameImage.GetComponent<User>();
        //gameObject.GetComponent<UnityEngine.UI.Text>().text = userNameImage.Name;
    }
}