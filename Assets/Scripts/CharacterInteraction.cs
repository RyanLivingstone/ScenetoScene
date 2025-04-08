using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterInteraction : MonoBehaviour
{
    private Rigidbody2D rb;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Spike")) 
            {
                other.gameObject.SetActive(false);
                Debug.Log("GameObject collided with " + other.name);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
