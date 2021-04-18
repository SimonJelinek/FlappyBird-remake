using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    bool jump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            rb.velocity = new Vector2(0, 5);
            jump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Void")
        {           
            App.gameManager.GameOver();
            Destroy(gameObject);
        }
    }
}
