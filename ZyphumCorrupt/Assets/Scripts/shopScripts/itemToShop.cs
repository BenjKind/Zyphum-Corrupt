using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class itemToShop : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        int count = 0;

        foreach (Item item in GameObject.Find("Zyphum").GetComponent<ZyphumScript>().items)
        {
            string str = "Item";
            str += count.ToString();
            GameObject obj = GameObject.Find(str);
            Transform tran = obj.transform;
            Transform title = tran.Find("ItemTitle");
            Transform price = tran.Find("ItemPrice");
            Text text = title.GetComponent<UnityEngine.UI.Text>();
            text.text = item.Name;
            Text textPrice = price.GetComponent<UnityEngine.UI.Text>();
            textPrice.text = "Price: " + item.price;
            count++;
        }
        foreach (Equipment e in GameObject.Find("Zyphum").GetComponent<ZyphumScript>().equip)
        {
            string str = "Item";
            str += count.ToString();
            GameObject obj = GameObject.Find(str);
            Transform tran = obj.transform;
            Transform title = tran.Find("ItemTitle");
            Transform price = tran.Find("ItemPrice");
            Text text = title.GetComponent<UnityEngine.UI.Text>();
            text.text = e.Name;
            Text textPrice = price.GetComponent<UnityEngine.UI.Text>();
            textPrice.text = "Price: " + e.price;
            count++;
        }
        Debug.Log(count);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}