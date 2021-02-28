using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class equipInvDisplay : MonoBehaviour
{
    public void Populate()
    {
        User current = GameObject.Find("Zyphum").GetComponent<ZyphumScript>().currentUser;
        GameObject IList = GameObject.Find("Equipment List");
        Transform tran = IList.transform;
        Transform Viewport = tran.Find("Viewport");
        Transform content = Viewport.Find("Content");
        Transform transform = content.transform;
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Text txt = child.Find("equipmentTitle").GetComponent<UnityEngine.UI.Text>();
            txt.text = current.equipment[i].Name;
            child.gameObject.GetComponent<iventoryItemButtons>().InventoryEquipment = current.equipment[i];
            if (i == current.equipment.Count)
            {
                break;
            }
            Debug.Log(txt.text);
        }
    }
}
