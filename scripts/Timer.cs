using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; // Necesario para acceder a la escena actual

public class Timer : MonoBehaviour
{
    // Variable estática para almacenar el temporizador entre escenas
    private static float timer = 0;

    // Referencia al objeto TextMeshProUGUI en el que se mostrará el temporizador
    public TextMeshProUGUI textoTimer;

    // Variable para saber si el temporizador está detenido
    private bool isTimerStopped = false;

    void Update()
    {
        // Verifica si la escena actual es "WinScene"
        if (SceneManager.GetActiveScene().name == "WinScene")
        {
            // Detiene el temporizador
            isTimerStopped = true;
        }

        // Si el temporizador está detenido, no lo incrementa
        if (!isTimerStopped)
        {
            // En cada frame, aumenta el temporizador por el tiempo que ha pasado desde el último frame
            timer += Time.deltaTime;
        }

        // Formatea el tiempo para mostrarlo en segundos, minutos o horas según corresponda
        if (timer < 60)
        {
            // Mostrar en segundos
            textoTimer.text = timer.ToString("f2") + " s";
        }
        else if (timer < 3600)
        {
            // Mostrar en minutos y segundos
            int minutes = Mathf.FloorToInt(timer / 60);
            float seconds = timer % 60;
            textoTimer.text = string.Format("{0:00}:{1:00.00} m", minutes, seconds);
        }
        else
        {
            // Mostrar en horas, minutos y segundos
            int hours = Mathf.FloorToInt(timer / 3600);
            int minutes = Mathf.FloorToInt((timer % 3600) / 60);
            float seconds = timer % 60;
            textoTimer.text = string.Format("{0:00}:{1:00}:{2:00.00} h", hours, minutes, seconds);
        }
    }

    // Método estático para obtener el valor del temporizador desde otros scripts
    public static float GetTimer()
    {
        return timer;
    }

    // Método estático para reiniciar el temporizador desde otros scripts
    public static void ResetTimer()
    {
        timer = 0;
    }
}
