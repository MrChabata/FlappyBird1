using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float jumpStrenght;
    private Rigidbody2D rb;
    private Animator animator;
    public GameObject deathScreen;
    private int score;
    public Text text;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.isPause) return;
        if (!Global.isAlive) return;

        if (rb.simulated == false && Input.GetKeyDown(KeyCode.Space))
        {
            rb.simulated = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 1) * jumpStrenght, ForceMode2D.Impulse);
        }

        float speedY = rb.velocity.y;
        animator.SetFloat("SpeedY", speedY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ice")
        {
            Global.isAlive = false;
            Destroy(gameObject);
            deathScreen.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            score += 1;
            text.text = score.ToString();
        }
    }
}
