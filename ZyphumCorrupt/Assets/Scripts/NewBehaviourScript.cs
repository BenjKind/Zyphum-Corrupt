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
        Character Noir = new Character();
        Noir.Name = "Noir";
        Noir.Class = "Red Mage";
        Noir.ElementalAffinity = "Ice";
        Noir.MaxHealth = 20;
        Noir.Speed = 44;
        Noir.Attack = 53;
        Noir.Defense = 13;
        Noir.Magic = 70;
        Noir.MagicDefense = 68;
        Serializer sz = new Serializer();
        sz.SerializeCharacter(Noir);
    }
}