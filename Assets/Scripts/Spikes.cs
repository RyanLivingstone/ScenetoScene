using UnityEngine;

public class Spikes : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    public void Reset_obj(){
        transform.position = initialPosition;
    }
    public void ResetVelocity(){
        rb.linearVelocity = Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
