using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private GameObject BG1;
    [SerializeField] private GameObject BG2;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float breakpoint;
    private float initialpoint;
    private Rigidbody2D rb1;
    private Rigidbody2D rb2;
    private float currentSpeed;
    private SpriteRenderer bg1Renderer;
    private SpriteRenderer bg2Renderer;
    private float overlay;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 0;
        rb1 = BG1.GetComponent<Rigidbody2D>();
        rb2 = BG2.GetComponent<Rigidbody2D>();
        bg1Renderer = BG1.GetComponent<SpriteRenderer>();
        bg2Renderer = BG2.GetComponent<SpriteRenderer>();
        overlay = bg1Renderer.bounds.size.x - BG2.transform.position.x + BG1.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.isPause)
        {
            rb1.velocity = Vector3.zero;
            rb2.velocity = Vector3.zero;
            return;
        }
        if (!Global.isAlive)
        {
            rb1.velocity = Vector3.zero;
            rb2.velocity = Vector3.zero;
            return;
        }

        if (currentSpeed == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            currentSpeed = maxSpeed;
        }
            rb1.velocity = new Vector2(-1, 0) * currentSpeed;
            rb2.velocity = -transform.right * currentSpeed;

        if(rb1.transform.position.x <= breakpoint)
        {
            rb1.transform.position+= new Vector3(bg1Renderer.bounds.size.x * 2 - overlay, 0, 0);
        }

        if (rb2.transform.position.x <= breakpoint)
        {
            rb2.transform.position += new Vector3(bg2Renderer.bounds.size.x * 2 - overlay, 0, 0);
        }
    }
}