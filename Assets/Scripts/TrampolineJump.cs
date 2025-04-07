using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private float bounceForce = 6f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // Reset Y velocity
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}