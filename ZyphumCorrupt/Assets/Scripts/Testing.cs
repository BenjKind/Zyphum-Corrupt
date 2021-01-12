using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    public void Tester()
    {
        Debug.Log(GameObject.Find("Button").GetComponent<NewBehaviourScript>().Arachnae.Name);
        Debug.Log(GameObject.Find("Button").GetComponent<NewBehaviourScript>().Arachnae.characters[0].Name);


    }
}
