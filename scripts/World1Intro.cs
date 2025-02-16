using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World1Intro : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadWorld1", 3); // Exactamente el mismo nombre que el public void LoadMainMenu, invoca el método creado abajo a los 3 segundos

    }

    public void LoadWorld1()
    {
        SceneManager.LoadScene("Nivel 1"); // El nombre de vuestra escena de menú, a los 3 segundos vuelve a la pantalla de inicio
    }

}
