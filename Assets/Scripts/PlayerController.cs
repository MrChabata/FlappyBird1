using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpStrenght;
    private Rigidbody2D rb;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.simulated == false && Input.GetKeyDown(KeyCode.Space))
        {
            rb.simulated = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 1) * jumpStrenght, ForceMode2D.Impulse);
        }

        float speedY = rb.velocity.y;
        animator.SetFloat("SpeedY", speedY);
    }
}
