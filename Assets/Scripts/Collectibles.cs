using UnityEngine;

public class Collectible : MonoBehaviour
{
    // You can customize the collectible type, points, or other attributes
    public int points = 10;

    // This function will be triggered when the player collides with the collectible
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the player has the tag "Player"
        {
            // Call a method to handle the collection logic (score, sound, etc.)
            Collect(other.gameObject);
        }
    }

    // Method that handles the logic after the collectible is collected
    private void Collect(GameObject player)
    {
        // You can modify this to add score or other game logic
        Debug.Log("Collected! Points: " + points);

        // Destroy the collectible object
        Destroy(gameObject);
    }
}

