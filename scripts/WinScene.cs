using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu", 10); // Exactamente el mismo nombre que el public void LoadMainMenu, invoca el m�todo creado abajo a los 3 segundos

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu"); // El nombre de vuestra escena de men�, a los 3 segundos vuelve a la pantalla de inicio
    }

}
