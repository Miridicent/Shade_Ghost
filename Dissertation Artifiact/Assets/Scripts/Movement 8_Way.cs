using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement8_Way : MonoBehaviour
{

    //Movement speed of the player
    public float movSpeed;
    float speedX, speedY;

    //Calls Rigidbody and the Sprite Renderer
    Rigidbody2D rb;
    private SpriteRenderer _sprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Does the same as the 2_Way movemnt script but also adds up and down (W, s and the arrows)
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector3(speedX, speedY);

        // Flips the sprite depending on the direction being moved 
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _sprite.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            _sprite.flipX = false;
        }
    }
}
