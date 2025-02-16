using UnityEngine;

public class Collectibles : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player")) // Si un objeto colisiona con otro objeto con tag "Player"...
        {

            FindAnyObjectByType<GameManager>().AddCollectible(); // Entrar al script de GameManager y llamar al método de AddCollectible

            Destroy(gameObject); // Destruir el objeto por completo

        }


    }


}
