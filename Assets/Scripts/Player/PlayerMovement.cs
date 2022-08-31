using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    float velocity = 5f;
    float movx, movy;
    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal");
        movy = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movx, movy) * velocity;
        Rotate();
        
    }

    void Rotate() => this.transform.rotation = movx < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.Euler(0, 0, 0);

}

