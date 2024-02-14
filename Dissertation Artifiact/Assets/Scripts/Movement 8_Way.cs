using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement8_Way : MonoBehaviour
{

    public float movSpeed;
    float speedX, speedY;
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
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector3(speedX, speedY);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A))
        {
            _sprite.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            _sprite.flipX = false;
        }
    }
}
