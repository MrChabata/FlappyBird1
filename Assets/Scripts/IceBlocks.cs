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
        if (Global.isPause) return;
        if (!Global.isAlive)
        {
            rb.velocity = Vector3.zero;
            return;
        }

        rb.velocity = -transform.right * speed;
    }
}
