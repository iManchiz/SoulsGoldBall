using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Transform playerTransform;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        playerTransform = FindAnyObjectByType<Jugador>().transform;
        navMeshAgent.speed = 30f;
        navMeshAgent.acceleration = 30f;
        navMeshAgent.angularSpeed = 1000f;

    }

    void Update()
    {
        navMeshAgent.destination = playerTransform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }