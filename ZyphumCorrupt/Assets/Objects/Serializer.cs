using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class Serializer
{
    public string filePath;

    public Serializer()
    {

    }
    public Serializer(string path)
    {
        filePath = path;
    }
    public void SerializeUser(User user)
    {
        
        StreamWriter sw = new StreamWriter(filePath);
        
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(user.GetType());
        x.Serialize(sw, user);
        
    }

}
