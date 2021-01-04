using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    string msg = "this is a notification";
    public User Arachnae = new User();
    public void userUpdate()
    {
        Arachnae.SetName("Arachnae");
        Character charlot = new Character();
        Arachnae.characters.ObjectList.Add(charlot);
    }
    public void dothisthing()
    {
        userUpdate();
        Debug.Log(Arachnae.GetName());
        Character temp = (Character)Arachnae.characters.ObjectList[0];
        Debug.Log(temp.GetMHP());
        //user>inventory>objectlist<baseobject>>character
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
