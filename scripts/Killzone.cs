using UnityEngine;
using UnityEngine.SceneManagement; //Para cargar escenas, resetear escenas etc...

public class Killzone : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Volver a cargar la escena
        }

    }
}
