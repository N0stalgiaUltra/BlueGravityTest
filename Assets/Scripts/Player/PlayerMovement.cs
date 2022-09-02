using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator playerAnim;
    
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
        Move();
        Rotate();
        
    }
    private void Move()
    {
        rb.velocity = new Vector2(movx, movy) * velocity;

        if (Mathf.Abs(movx) > Mathf.Epsilon || Mathf.Abs(movy) > Mathf.Epsilon)
            playerAnim.SetInteger("move", 1);
        else
            playerAnim.SetInteger("move", 0);

    }
    void Rotate()
    {
        if (movx < 0)
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        else if(movx > 0)
            this.transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}

