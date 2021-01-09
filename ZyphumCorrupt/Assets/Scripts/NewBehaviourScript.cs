using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

    public User Arachnae = new User();
    public void userUpdate()
    {
        Arachnae.SetName("Arachnae");
        Character charlot = new Character();
        Arachnae.characters.ObjectList.Add(charlot);
        Item thing = new Item();
        Equipment another = new Equipment();
        Arachnae.items.ObjectList.Add(thing);
        Arachnae.items.ObjectList.Add(another);
    }

    public void dothisthing()
    {
        userUpdate();
        Serializer Szr = new Serializer("Dump.txt");
        Szr.SerializeUser(Arachnae);
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
