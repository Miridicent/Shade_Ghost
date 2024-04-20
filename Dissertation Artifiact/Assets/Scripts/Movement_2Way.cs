using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Tilemaps;
using UnityEngine;

public class Movement_2Way : MonoBehaviour
{
    //Speed and jump height 
    public float Speed = 2;
    public float Jump = 1;

    // Calls the Rigid body and the Sprite renderer 
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;
    public bool flipX;
    
    private void Start()
    {
        // Gets the Rigidbody and Sprite renderer components
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //Sets the controls so that if A and D are pressed the player can move left and right (also works for arrows)
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Speed;

        //Allows the player to jump
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f)
        {
            _rb.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
        }

        //Flips the sprite depending on the key pressed
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _sprite.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            _sprite.flipX = false;
        }
    }

  
}
