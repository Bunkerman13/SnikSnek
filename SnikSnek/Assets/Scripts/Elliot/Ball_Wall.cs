using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Wall : MonoBehaviour
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
        if (collision.gameObject.tag == "Bullet")
        {
            //collision.gameObject.GetComponent<Ball_Activate>().player.GetComponent<Player_PointsTracker>().totalPoints--;

            Destroy(collision.gameObject);
        }
    }
}
