using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class scrap : MonoBehaviour
{
    // THIS WILL WRITE TO AN XML
    public static User user = new User();

    public void userUpdate()
    {
        user.Name = "user2 Test";

        Serializer sz = new Serializer("Users/user2.xml");
        sz.SerializeUser(user);
    }
}