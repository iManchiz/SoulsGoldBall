using UnityEngine;

public class SeguimientoJugador : MonoBehaviour
{
    public Transform jugador; // Referencia al Transform del jugador

    public float suavizado = 5f; // Controla la suavidad del seguimiento

    private Vector3 desfase; // Variable para el desfase entre la c�mara y el jugador

    void Start()
    {
        // Calcula el desfase inicial entre la c�mara y el jugador
        desfase = transform.position - jugador.position;
    }

    void FixedUpdate()
    {
        // Calcula la posici�n a la que debe moverse la c�mara
        Vector3 objetivoPosicion = jugador.position + desfase;

        // Aplica un suavizado al movimiento de la c�mara
        Vector3 nuevaPosicion = Vector3.Lerp(transform.position, objetivoPosicion, suavizado * Time.deltaTime);

        // Asigna la nueva posici�n a la c�mara
        transform.position = new Vector3(nuevaPosicion.x, nuevaPosicion.y, nuevaPosicion.z);
    }
}
