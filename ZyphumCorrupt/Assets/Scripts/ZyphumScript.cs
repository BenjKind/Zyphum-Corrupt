using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZyphumScript : MonoBehaviour
{
    public User currentUser = new User();
    private void Awake()
    {
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
