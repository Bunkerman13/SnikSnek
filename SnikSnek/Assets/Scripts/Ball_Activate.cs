using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Activate : MonoBehaviour
{
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        //direction = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newDirection = new Vector3(transform.position.x + (direction.normalized.x * .08f), transform.position.y + (direction.normalized.y * .08f), 0);
        transform.position = newDirection;

        if (Vector3.Magnitude(direction - newDirection) > 5)
            Destroy(gameObject);
    }
}
