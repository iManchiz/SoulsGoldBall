using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World2Intro : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadWorld2", 3); // Exactamente el mismo nombre que el public void LoadMainMenu, invoca el método creado abajo a los 3 segundos

    }

    public void LoadWorld2()
    {
        SceneManager.LoadScene("Level 2-1"); // El nombre de vuestra escena de menú, a los 3 segundos vuelve a la pantalla de inicio
    }

}
