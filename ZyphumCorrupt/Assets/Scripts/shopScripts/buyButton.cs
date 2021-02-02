using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyButton : MonoBehaviour
{
    public void buy()
    {
        itemSelection iS = GameObject.Find("ItemStats").GetComponent<itemSelection>();
        if (iS.boughtItem != null)
        {
            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.currency -= iS.boughtItem.price;

            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.items.Add(iS.boughtItem);
        }
        if (iS.boughtEquip != null)
        {
            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.currency -= iS.boughtEquip.price;

            GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.equipment.Add(iS.boughtEquip);
        }
        Debug.Log(GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser.currency.ToString());
    }
}