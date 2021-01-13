using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.characters[1].Name);
    }
}
