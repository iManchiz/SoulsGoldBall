using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public GameObject Enemigo; // Prefab del enemigo que quieres generar

    public GameObject Ghost;

    public GameObject Spider;

    public float speed = 5f;
  
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (SceneManager.GetActiveScene().name == "Nivel 12")
        {
            speed = 27f;

        }
        if (SceneManager.GetActiveScene().name == "Level 2-4")
        {
            speed = 20f;

        }
        if (SceneManager.GetActiveScene().name == "Level 2-6")
        {
            speed = 30f;
        }
        if (SceneManager.GetActiveScene().name == "Level 2-9")
        {
            speed = 20f;
        }
        if (SceneManager.GetActiveScene().name == "Level 2-10")
        {
            speed = 30f;
        }

        if (SceneManager.GetActiveScene().name == "Level 3-2")
        {
            speed = 22f;


        }

        if (SceneManager.GetActiveScene().name == "Level 3-3")
        {
            speed = 22f;


        }

        if (SceneManager.GetActiveScene().name == "Level 3-4")
        {
            speed = 22f;


        }

        if (SceneManager.GetActiveScene().name == "Level 3-10")
        {
            speed = 22f;

        }
        if (SceneManager.GetActiveScene().name == "demo")
        {
            speed = 7f;
            transform.localScale = Vector3.one;

        }

    }
    private void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); // Declarar en una variable el movimento horizontal

        float moveVertical = Input.GetAxis("Vertical"); // Declarar en una variable el movimento vertical

        Vector3 movement = new Vector3(moveHorizontal * speed, rb.linearVelocity.y, moveVertical*speed); // Vector se refiere a X, Y y Z

        rb.linearVelocity = movement; // Asignar el vector de movimiento creado al personaje

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        // Verificar si la colisión ocurrió en el "Nivel 6"
        if (SceneManager.GetActiveScene().name == "Nivel 6")
        {
            speed = 20f;
            if (collision.gameObject.CompareTag("Collectible"))
            {
                // Aumentar la escala del personaje en 1 en cada eje
                transform.localScale = new Vector3(transform.localScale.x + 0.5f, transform.localScale.y + 0.5f, transform.localScale.z + 0.5f);
            }
        }
        if (SceneManager.GetActiveScene().name == "Nivel 8")
        {
            if (collision.gameObject.CompareTag("Collectible"))
            {
                transform.localScale = Vector3.one;
                speed += 5f;
            }
        }
        if (SceneManager.GetActiveScene().name == "Nivel 10" && collision.transform.CompareTag("Collectible"))
        {
            speed += 2.5f;
            GenerateEnemy();
        }

        if (SceneManager.GetActiveScene().name == "Nivel 11"){
            transform.localScale = new Vector3(6, 6, 6);

            if (collision.transform.CompareTag("Collectible")){
                speed += 2.5f;
                generateBigEnemy();
            }

        }

        if (SceneManager.GetActiveScene().name == "Level 2-5")
        {
            if (collision.transform.CompareTag("Collectible"))
            {
                generateGhost();
            }

        }


        void GenerateEnemy()
        {
            // Genera una posición aleatoria en el plano XY
            Vector3 randomPosition = new Vector3(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));

            // Instancia un nuevo enemigo en la posición aleatoria
            GameObject nuevoEnemigo = Instantiate(Enemigo, randomPosition, Quaternion.identity); // Instantiate para generar un el enemigo
        }

        void generateBigEnemy()
        {
            Vector3 randomPosition = new Vector3(Random.Range(0,1), Random.Range(0, 1), Random.Range(0, 1));
            GameObject nuevoEnemigo = Instantiate(Enemigo, randomPosition, Quaternion.identity);
            nuevoEnemigo.transform.localScale = new Vector3(5, 5, 5);
        }

        void generateBigEnemy2()
        {
            Vector3 randomPosition = new Vector3(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
            GameObject nuevoEnemigo = Instantiate(Enemigo, randomPosition, Quaternion.identity);
            nuevoEnemigo.transform.localScale = new Vector3(5, 5, 5);
        }

        void generateGhost()
        {
            Vector3 randomPosition = new Vector3(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
            GameObject Ghosst = Instantiate(Ghost, randomPosition, Quaternion.identity);
        }

    }




}