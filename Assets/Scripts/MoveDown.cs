using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 0.1f;
    private float yDestroy = -1.0f;
    private Rigidbody objectRb;

    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        objectRb.AddForce(Vector3.down * speed);

        if (transform.position.y < yDestroy)
        {
            Destroy(gameObject);
        }
    }
}
