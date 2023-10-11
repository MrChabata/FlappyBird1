using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private GameObject BG1;
    [SerializeField] private GameObject BG2;
    [SerializeField] private float speed;
    [SerializeField] private float breakpoint;
    private float initialpoint;
    private Rigidbody2D rb1;
    private Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = BG1.GetComponent<Rigidbody2D>();
        rb2 = BG2.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(speed != 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb1.velocity = new Vector2(-1, 0) * speed;
            rb2.velocity = -transform.right * speed;
        }
    }
}