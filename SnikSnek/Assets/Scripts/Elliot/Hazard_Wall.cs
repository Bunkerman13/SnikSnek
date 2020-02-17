using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // determines if a bullet hits the wall and deletes it
    //    if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Absorber")
    //        Destroy(collision.gameObject);
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet" || other.gameObject.tag == "Absorber")
        {
            Destroy(other.gameObject);
        }
    }
}
