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
        Item thing = new Item();
        Equipment another = new Equipment();
        Arachnae.items.ObjectList.Add(thing);
        Arachnae.items.ObjectList.Add(another);
    }
    public void dothisthing()
    {
        userUpdate();
        Debug.Log(Arachnae.GetName());
        Character temp = (Character)Arachnae.characters.ObjectList[0];
        Debug.Log(temp.GetMHP());
        for(int i = 0; i < 2; i++)
        {
            switch(Arachnae.items.ObjectList[i].ObjectType)
            {
                case Identiy.Item:
                    Item temp2 = (Item)Arachnae.items.ObjectList[i];
                    Debug.Log(temp2.Name);
                    break;
                case Identiy.Equipment:
                    Equipment temp3 = (Equipment)Arachnae.items.ObjectList[i];
                    Debug.Log(temp3.Name);
                    break;
                default:
                    Debug.LogError("Something dun did a fuck up");
                    break;
            }
        }
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
