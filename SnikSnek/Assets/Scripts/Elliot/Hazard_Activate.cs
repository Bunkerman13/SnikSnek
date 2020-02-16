using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Activate : MonoBehaviour
{
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newDirection = new Vector3(transform.position.x + (direction.normalized.x * .08f), transform.position.y + (direction.normalized.y * .08f), 0);
        transform.position = newDirection;

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if collides with player, increment player points
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_PointsTracker>().totalPoints++;

            Destroy(gameObject);
        }
    }
}
