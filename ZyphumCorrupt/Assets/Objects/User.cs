using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{

    #region Members

    public string Name;
    public List<Character> characters = new List<Character>();
    public List<Item> items = new List<Item>();
    public List<Equipment> equipment = new List<Equipment>();


    #endregion

    #region Getters Setters

    public string GetName()
    {
        return Name;
    }
    
    public void SetName(string input)
    {
        Name = input;
    }

    #endregion

    public User()
    {
        Name = "Null";
    }


}
