using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneIntIn : MonoBehaviour
{
    public void LoadSceneByInt(int input)
    {
        SceneManager.LoadScene(input, LoadSceneMode.Single);
    }
}