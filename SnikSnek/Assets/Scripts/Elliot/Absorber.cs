using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            // decrements players points
            Player_PointsTracker pointTracker = collision.gameObject.GetComponent<Ball_Activate>().player.GetComponent<Player_PointsTracker>();
            
            if (pointTracker) pointTracker.TotalPoints--;

            Destroy(collision.gameObject);
        }
    }
}
