using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorber_Movement : MonoBehaviour
{
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement script
        Vector3 newDirection = new Vector3(transform.position.x + (direction.normalized.x * .1f), transform.position.y + (direction.normalized.y * .1f), 0);
        transform.position = newDirection;
    }
}
