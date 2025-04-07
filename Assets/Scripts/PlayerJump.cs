<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> Natalie
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private SpriteRenderer spriteRenderer;
<<<<<<< HEAD
    [SerializeField] private float jumpForce = 8;
=======
    [SerializeField] private float jumpForce = 6;
>>>>>>> Natalie
    private float playerHalfHeight;

    private void Start()
    {
        playerHalfHeight = spriteRenderer.bounds.extents.y;
    }
<<<<<<< HEAD
    
=======

>>>>>>> Natalie
    void Update()
    {
        if (Input.GetButtonDown("Jump") && GetIsGrounded()){
            Jump();
        }
    }

<<<<<<< HEAD
private bool GetIsGrounded(){
    return Physics2D.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("Ground"));
}
    private void Jump(){
=======
    private bool GetIsGrounded(){
        return Physics2D.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("Ground"));
    }
    
    private void Jump() {
>>>>>>> Natalie
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
