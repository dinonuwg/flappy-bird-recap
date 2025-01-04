using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    public AudioClip scoreSFX;
    public AudioClip gameOverSFX;

    public BirdScript bird;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {   
        if (bird.birdIsAlive)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
            audioSource.PlayOneShot(scoreSFX);
        }
    }

    // Scenes
    public void mainMenu()
    {
        // Load scene with build index 0
        SceneManager.LoadScene(0);
    }
    public void startGame()
    {
        // Load scene with build index 1
        SceneManager.LoadScene(1);
    }
    public void gameOver()
    {
        if (bird.birdIsAlive)
        {
            gameOverScreen.SetActive(true);
            audioSource.PlayOneShot(gameOverSFX);
        }
    }
}
