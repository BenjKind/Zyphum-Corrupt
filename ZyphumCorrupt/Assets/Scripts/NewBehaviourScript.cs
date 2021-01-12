using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public static User Temp = new User();

    public void userUpdate()
    {
   
    }

    public void dothisthing()
    {
        Temp = GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser;
        Debug.Log(Temp.Name);
        Debug.Log(Temp.characters[0].Name);
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}