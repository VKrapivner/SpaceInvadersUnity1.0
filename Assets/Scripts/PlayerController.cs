using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    void Start()
    {
        
    }

    void Update()//Runs once per frame(about 60 times per second)
    {
        //Accessing the Trasform window
        hInput = Input.GetAxisRaw("Horizontal");//Looks at the horizontal input

        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }
}
