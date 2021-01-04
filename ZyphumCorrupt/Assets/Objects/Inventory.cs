using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{

    #region Members

    int maxCount;

    public List<BaseObject> ObjectList;

    #endregion


    public Inventory(int max)
    {
        maxCount = max;
        ObjectList = new List<BaseObject>(maxCount);
    }
}
