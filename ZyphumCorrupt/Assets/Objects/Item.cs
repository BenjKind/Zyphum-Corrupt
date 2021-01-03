using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Item : BaseObject
{

    #region Members

    string Name;
    private string Type;
    private int Points;

    #endregion

    #region Getters Setters

    public string GetType()
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

    }
}
