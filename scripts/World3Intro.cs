using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World3Intro : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadWorld3", 3); // Exactamente el mismo nombre que el public void LoadMainMenu, invoca el método creado abajo a los 3 segundos

    }

    public void LoadWorld3()
    {
        SceneManager.LoadScene("Level 3-1"); // El nombre de vuestra escena de menú, a los 3 segundos vuelve a la pantalla de inicio
    }

}
