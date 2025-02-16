using UnityEngine;
using UnityEngine.SceneManagement;

public class World2Skip : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}