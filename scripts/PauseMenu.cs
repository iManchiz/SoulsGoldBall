using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseBoton;
    [SerializeField] private GameObject pauseMenu;
    private bool pauseGame = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        pauseGame = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        pauseGame = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Restart()
    {
        pauseGame = false;
        Time.timeScale = 1f;
        Timer.ResetTimer(); // Reiniciar el temporizador

        // Reiniciar el contador de muertes
        PlayerPrefs.SetInt("DeathNumber", 0);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Nivel 1");
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        Timer.ResetTimer();
        PlayerPrefs.SetInt("DeathNumber", 0);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Menu");

    }

    public void Close()
    {
        Application.Quit();
    }
}
