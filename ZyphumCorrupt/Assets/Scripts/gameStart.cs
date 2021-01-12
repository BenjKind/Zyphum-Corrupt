using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    private void Awake()
    {
        
        Serializer sz = new Serializer();
        User temp =  new User();
        sz.DeserializeLast(out temp);
        GameObject.Find("Zyphum").GetComponent<ZyphumScript>().SetUser(temp);

    }
    public void startGame()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
