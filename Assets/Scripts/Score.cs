using UnityEngine;
using UnityEngine.UI; // For UI elements

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score;

    public Text scoreText; // Reference to the UI Text element to display score

    private void Awake()
    {
        // Ensure only one instance of the ScoreManager exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // This method is used to add score when a collectible is collected
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    // Update the score display on the UI
    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}