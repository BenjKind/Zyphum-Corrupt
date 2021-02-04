using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGold : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Text txt = gameObject.GetComponent<UnityEngine.UI.Text>();
        txt.text = GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.currency.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Text txt = gameObject.GetComponent<UnityEngine.UI.Text>();
        txt.text = GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.currency.ToString();
    }

}
