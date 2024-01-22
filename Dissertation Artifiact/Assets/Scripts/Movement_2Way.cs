using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Movement_2Way : MonoBehaviour
{
    public float Speed = 2;
    public float Jump = 1;
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;
    public bool flipX;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Speed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f)
        {
            _rb.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A) )
        {
            _sprite.flipX = true;
        }
        else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            _sprite.flipX = false;
        }
    }

  
}
