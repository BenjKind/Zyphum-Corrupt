using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemInvDisplay : MonoBehaviour
{
    public void Populate()
    {
        User current = GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser;
        GameObject IList = GameObject.Find("Item List");
        Transform tran = IList.transform;
        Transform Viewport = tran.Find("Viewport");
        Transform content = Viewport.Find("Content");
        Transform transform = content.transform;
        for(int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Text txt = child.Find("itemTitle").GetComponent<UnityEngine.UI.Text>();
            txt.text = current.items[i].Name;
            child.GetComponent<invData>().inter = i;
            child.gameObject.GetComponent<iventoryItemButtons>().InventoryItem = current.items[i];
            Debug.Log(child.gameObject.GetComponent<iventoryItemButtons>().InventoryItem.Type);
            if(i == current.items.Count)
            {
                break;
            }
            Debug.Log(txt.text);
        }
    }
}
