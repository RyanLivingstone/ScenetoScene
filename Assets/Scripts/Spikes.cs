using UnityEngine;

public class Spikes : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }
    public void Reset_obj(){
        transform.position = initialPosition;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
