using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlocks : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -transform.right * speed;
    }
}
