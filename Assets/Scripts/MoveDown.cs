using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float yDestroy = -1.0f;

    void Update()
    {

        if (transform.position.y < yDestroy)
        {
            Destroy(gameObject);
        }
    }
}
