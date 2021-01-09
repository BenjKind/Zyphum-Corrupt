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
        Arachnae.characters.Add(charlot);
        Item thing = new Item();
        Equipment another = new Equipment();
        Arachnae.equipment.Add(another);
        Arachnae.items.Add(thing);
    }

    public void dothisthing()
    {
        userUpdate();
        Serializer Szr = new Serializer("Dump.xml");
        Szr.SerializeUser(Arachnae);
        User ArachCopy = new User();
        Szr.DeserializeUser(out ArachCopy);
        Debug.Log(ArachCopy.Name);
        Debug.Log(ArachCopy.items[0].Name);
        Debug.Log(ArachCopy.equipment[0].Name);
        Debug.Log(ArachCopy.characters[0].Name);


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
