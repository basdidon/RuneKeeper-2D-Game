using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedProjectiles : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    public Rigidbody2D rb;
    public GameObject target;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        direction = (target.transform.position - transform.position).normalized;
        rb.velocity = direction*speed*Time.deltaTime;
    }
}
