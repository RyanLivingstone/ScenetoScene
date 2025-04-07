using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class PlayerController : MonoBehaviour
=======
public class PlayerMovement : MonoBehaviour
>>>>>>> Natalie
{
    public float speed = 5f;
    private Vector2 movement;

<<<<<<< HEAD
    void Update()
    {
       float input = Input.GetAxisRaw("Horizontal");
       movement.x = input * speed * Time.deltaTime;
       transform.Translate(movement);
    }
}
=======

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
    }

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
>>>>>>> Natalie
