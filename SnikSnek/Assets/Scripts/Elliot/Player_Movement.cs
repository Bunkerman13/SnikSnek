using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        float horizontalRotation = h * rotationSpeed * Time.deltaTime;
        float verticalRotation = v * rotationSpeed * Time.deltaTime;

        float angle = Mathf.Atan2(horizontalRotation, verticalRotation) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angle));

        direction = new Vector3(transform.position.x + (h * speed), transform.position.y + (v * speed), 0);

        gameObject.transform.position = direction;
    }
}
