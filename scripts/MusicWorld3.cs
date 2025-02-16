using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicWorld3 : MonoBehaviour
{
    private static MusicWorld3 instance;
    private AudioSource audioSource;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded; // Suscribirse al evento de carga de escenas
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Menu")
        {
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Desuscribirse del evento para evitar referencias inválidas
    }
}
