using UnityEngine;
using UnityEngine.UI;  // Required for accessing UI elements

public class WinScreen : MonoBehaviour
{
    // Reference to the You Win Canvas or Panel
    public GameObject winScreen;


    // Detect player collision with the trophy
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding is the player
        if (other.CompareTag("Player"))
        {
            // Show the You Win screen
            winScreen.SetActive(true);

            // Optionally, disable the player movement or other gameplay elements
            Time.timeScale = 0f; // Stops the game (pause)
        }
    }
}
