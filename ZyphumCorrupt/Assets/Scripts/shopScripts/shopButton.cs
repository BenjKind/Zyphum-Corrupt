using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showDetails()
    {
        GameObject obj = gameObject;
        Transform tra = obj.transform;
        Transform itemName = tra.Find("ItemTitle");
        string name = itemName.GetComponent<UnityEngine.UI.Text>().text;
        ZyphumScript zy = GameObject.Find("Zyphum").GetComponent<ZyphumScript>();
        GameObject detail = GameObject.Find("ItemStats");
        Transform transformDetail = detail.transform;
        Transform nameOfItem = transformDetail.Find("itemName");
        Transform itemType = transformDetail.Find("itemType");
        Transform itemBoostType = transformDetail.Find("itemBoostType");
        Transform itemPrice = transformDetail.Find("itemPrice");
        foreach(Equipment e in zy.equip)
        {
            if(name == e.Name)
            {
                nameOfItem.GetComponent<UnityEngine.UI.Text>().text = name;
                itemType.GetComponent<UnityEngine.UI.Text>().text = "Equipment";
                itemBoostType.GetComponent<UnityEngine.UI.Text>().text = e.boostType.ToString() + " +" + e.boost.ToString();
                itemPrice.GetComponent<UnityEngine.UI.Text>().text = "Price " + e.price.ToString();
                detail.GetComponent<itemSelection>().boughtEquip = e;
            }
        }
        foreach (Item i in zy.items)
        {
            if (name == i.Name)
            {
                nameOfItem.GetComponent<UnityEngine.UI.Text>().text = name;
                itemType.GetComponent<UnityEngine.UI.Text>().text = "Consumable";
                itemBoostType.GetComponent<UnityEngine.UI.Text>().text = i.Points.ToString() + " points of " + i.Type;
                itemPrice.GetComponent<UnityEngine.UI.Text>().text = "Price " + i.price.ToString();
                detail.GetComponent<itemSelection>().boughtItem = i;
            }
        }
    }
}
