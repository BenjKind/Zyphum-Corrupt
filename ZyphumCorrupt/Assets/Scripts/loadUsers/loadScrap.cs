using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadScrap : MonoBehaviour
{
    // THIS WILL LOAD FROM AN XML
    public void loadScrapStuff()
    {
        Serializer sz = new Serializer("Users/user0.xml");
        User user = new User();
        sz.DeserializeUser(out user);
    }
}