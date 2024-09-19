using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    float moveSpeed = 1.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        rb.velocity = Vector2.right * moveSpeed; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boundry")
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y -1, transform.position.z);//x and z stay at the same position while y moves down
            rb.MovePosition(newPosition);
            moveSpeed *= -1;
        }
    }
}
