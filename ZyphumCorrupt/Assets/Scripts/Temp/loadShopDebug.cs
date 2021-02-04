using UnityEngine;
using UnityEngine.SceneManagement;

public class loadShopDebug : MonoBehaviour
{
    public void loadShopDebugFunc()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
}