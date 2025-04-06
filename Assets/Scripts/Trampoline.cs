using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceForce = 10f; // The amount of bounce applied to the player

    // This method is triggered when another collider enters the trampoline's collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object that collided with the trampoline is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the Rigidbody2D component of the player
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRb != null)
            {
                // Apply an upward force to the player's Rigidbody2D
                playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, bounceForce);
            }
        }
    }
}
