using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Item : BaseObject
{

    #region Members
    //public Identiy ObjectType;
    public string Name;
    public string Type;
    public int Points;

    #endregion

    #region Getters Setters

    public string GetTypeA()
    {
        return Type;
    }

    public void SetType(string type)
    {
        Type = type;
    }

    public int GetPoints()
    {
        return Points;
    }

    public void SetPoints(int count)
    {
        Points = count;
    }

    #endregion

    public Item()
    {
        ObjectType = Identiy.Item;
        Name = "null";
    }
}
