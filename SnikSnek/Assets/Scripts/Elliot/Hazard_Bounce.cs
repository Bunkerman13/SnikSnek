using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Bounce : MonoBehaviour
{

    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(transform.up.normalized.x * .1f, transform.up.normalized.y * .1f, 0);
        transform.up = direction;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //direction = -2 * (Vector3.Dot(direction, collision.gameObject.transform.up.normalized)) * collision.gameObject.transform.up.normalized + direction;
        // Really basic bouncing mechanic
        direction = new Vector3(collision.transform.up.normalized.x * .1f, collision.transform.up.normalized.y * .1f, 0);
    }
}
