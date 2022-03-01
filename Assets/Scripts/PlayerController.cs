using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 10.0f;
    private float jumpForce = 200.0f;
    private float xBound = 12.0f;
    private bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    // Move player side-to-side (with arrow keys) within boundary and jump (with spacebar)
    void MovePlayer()
    {
        // Make player move side-to-side within boundary
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        } 
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        } 
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        }

        // Make player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Chocolate"))
        {
            Destroy(other.gameObject);
        } else if (other.gameObject.CompareTag("Vegetable"))
        {
            Destroy(other.gameObject);
        } else if (other.gameObject.CompareTag("Power up"))
        {
            Destroy(other.gameObject);
        }
    }
}
