using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed *  Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);//What are you spanning in, where, rotation
            Destroy(collision.gameObject);//destroying the object it collides with
            Destroy(gameObject);//destroying the projectile
        }

        if(collision.gameObject.tag == "Boundry")
        {
            Destroy(gameObject);
        }
    }
}
