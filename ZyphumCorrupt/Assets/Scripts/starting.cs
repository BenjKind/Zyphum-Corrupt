using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class starting 
{
    Serializer sz = new Serializer("Dump.xml");
    public User user = new User();
    static starting()
    {
        Serializer sz = new Serializer("Dump.xml");
        User us = new User();
        sz.DeserializeUser(out us);
         
        
    }
    public starting()
    {

    }
    public void SetUser(User it)
    {
        user = it;
    }
}
