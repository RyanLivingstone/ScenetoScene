using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;


    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
