using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = true;

    void Start()
    {
        Time.timeScale = 0f; // Pausa el juego al iniciar la escena
    }

    void Update()
    {
        if (isPaused && Input.anyKeyDown)
        {
            Time.timeScale = 1f; // Reanuda el juego al presionar cualquier tecla
            isPaused = false;
        }
    }
}