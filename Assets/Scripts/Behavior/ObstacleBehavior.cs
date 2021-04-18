using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    float speed = 0.1f;

    void FixedUpdate()
    {
        transform.position += new Vector3(-speed, 0,0);

        if (transform.position.x <= -3.56f)
        {
            Destroy(gameObject);
        }
    }
}
