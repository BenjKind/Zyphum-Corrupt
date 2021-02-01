using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class ZyphumScript : MonoBehaviour
{
    public User currentUser = new User();

    List<Equipment> equip = new List<Equipment>();
    List<Item> items = new List<Item>();




    private void Awake()
    {
        string[] equipFiles;
        string[] itemFiles;
        equipFiles = Directory.GetFiles("Equipment", "*.xml");
        itemFiles = Directory.GetFiles("Items", "*.xml");
        Serializer sz = new Serializer();
        foreach(string str in equipFiles)
        {
            Equipment equipment = new Equipment();
            sz.DeserializeEquioment(str, out equipment);
            equip.Add(equipment);
        }
        foreach (string str in itemFiles)
        {
            Item item = new Item();
            sz.DeserializeItem(str, out item);
            items.Add(item);
        }


        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public User GetUser()
    {
        return currentUser;
    }
    public void SetUser(User user)
    {
        currentUser = user;
    }
}
