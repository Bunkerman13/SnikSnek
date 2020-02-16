using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    public Vector3 position;
    public float rotationSpeed = 5.0f;

    [SerializeField] string horiInputAxis, vertInputAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] Vector3 debug;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw(horiInputAxis);
        float v = Input.GetAxisRaw(vertInputAxis);

        float horizontalRotation = h * rotationSpeed * Time.deltaTime;
        float verticalRotation = v * rotationSpeed * Time.deltaTime;

        Vector3 direction = debug = new Vector3(h, v, 0);
        if (direction.sqrMagnitude > 0.1f) transform.up = direction;

        position = new Vector3(transform.position.x + (h * speed), transform.position.y + (v * speed), 0);

        gameObject.transform.position = position;
    }
}
