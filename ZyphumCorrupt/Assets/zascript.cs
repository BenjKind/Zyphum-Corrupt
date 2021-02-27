using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zascript : MonoBehaviour
{
    private User user = new User();

    // Start is called before the first frame update
    private void Start()
    {
        Serializer sz = new Serializer("Dump.xml");
        sz.DeserializeUser(out user);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}