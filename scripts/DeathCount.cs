using NUnit.Framework.Internal;
using System;
using TMPro;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    // Contador de muertes totales
    private int deathNumber;

    private void Awake()
    {
        deathNumber = PlayerPrefs.GetInt("DeathNumber", 0);
        updateDeaths();
    }

    // Método llamado cuando ocurre una colisión
    private void OnCollisionEnter(Collision collision)
    {

        
        // Verificar si el objeto con el que se colisionó tiene el tag "Jugador"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Aumentar el contador de muertes totales en 1
            deathNumber++;
            updateDeaths();
        }
    }
    private void ResetDeathCounter()
    {
        deathNumber = 0;
        PlayerPrefs.SetInt("DeathNumber", deathNumber);
        PlayerPrefs.Save();
        updateDeaths();
    }

    private void updateDeaths()
    {
        GameObject deathText = GameObject.FindGameObjectWithTag("DeathCount");
        TMP_Text test = deathText.GetComponent<TMP_Text>();
        test.text = deathNumber.ToString();
        PlayerPrefs.SetInt("DeathNumber", deathNumber);
        PlayerPrefs.Save();
    }
}
