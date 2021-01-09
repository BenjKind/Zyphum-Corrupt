using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{

    #region Members

    private string Name;
    public Inventory characters;
    public Inventory items;

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
        characters = new Inventory(10);
        items = new Inventory(50);

    }


}
