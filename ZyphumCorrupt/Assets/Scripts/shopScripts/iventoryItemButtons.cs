using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iventoryItemButtons : MonoBehaviour
{
    public Item InventoryItem = new Item();
    public Equipment InventoryEquipment = new Equipment();
    public void ItemInfo()
    {
        Debug.Log(gameObject.GetComponent<invData>().inter);
        GameObject selected = GameObject.Find("invWindow");
        Transform info = selected.transform.GetChild(5);
        Transform text = info.transform.GetChild(0);
        text.GetComponent<UnityEngine.UI.Text>().text = "Does " + gameObject.GetComponent<iventoryItemButtons>().InventoryItem.Type + " of " + gameObject.GetComponent<iventoryItemButtons>().InventoryItem.Points.ToString();
        GameObject TitleSelected = GameObject.Find("title_selected");
        Transform title = TitleSelected.transform.GetChild(0);
        title.GetComponent<UnityEngine.UI.Text>().text = InventoryItem.Name;
    }
    public void EquipmentInfo()
    {
        GameObject selected = GameObject.Find("Info_selected");
        Transform text = selected.transform;
        text.GetComponent<UnityEngine.UI.Text>().text = "Increases " + InventoryEquipment.boostType.ToString() + " by " + InventoryEquipment.boost.ToString();
        GameObject TitleSelected = GameObject.Find("title_selected");
        Transform title = TitleSelected.transform.GetChild(0);
        title.GetComponent<UnityEngine.UI.Text>().text = InventoryEquipment.Name;

    }
}
