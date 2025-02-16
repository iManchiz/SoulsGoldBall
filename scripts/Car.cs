using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    // Este método se llama cuando el collider de este objeto entra en contacto con otro collider
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que ha colisionado se llama "Jugador"
        if (other.gameObject.CompareTag("Jugador"))
        {
            // Reinicia la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
