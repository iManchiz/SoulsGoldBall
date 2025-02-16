using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBossIntro : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadFinalLevel", 3); // Exactamente el mismo nombre que el public void LoadMainMenu, invoca el método creado abajo a los 3 segundos

    }

    public void LoadFinalLevel()
    {
        SceneManager.LoadScene("Level 2-10"); // El nombre de vuestra escena de menú, a los 3 segundos vuelve a la pantalla de inicio
    }
}
