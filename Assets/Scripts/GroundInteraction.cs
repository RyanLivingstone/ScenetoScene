using UnityEngine;

public class GroundInteraction : MonoBehaviour
{
    public Rigidbody2D rb;
        void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Spike")) 
            {
                other.gameObject.GetComponent<Spikes>().Reset_obj();
                other.gameObject.GetComponent<Spikes>().ResetVelocity();
                Debug.Log("GameObject collided with " + other.name);
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
