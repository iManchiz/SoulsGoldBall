using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public TMP_Text collectiblesNumbersText;
    private int collectiblesNumber;
    public TMP_Text totalCollectiblesNumersText;
    private int totalCollectiblesNumers;

    void Start()
    {
        totalCollectiblesNumers = transform.childCount;
        totalCollectiblesNumersText.text = totalCollectiblesNumers.ToString();

    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {

        collectiblesNumber++;
        collectiblesNumbersText.text = collectiblesNumber.ToString();
        audioSource.Play();
    }
}