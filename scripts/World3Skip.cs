using UnityEngine;
using UnityEngine.SceneManagement;

public class World3Skip : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}