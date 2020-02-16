using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Activate : MonoBehaviour
{
    public Vector3 direction;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //direction = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        // sets the direction and movement of bullet based on player direction/position
        Vector3 newDirection = new Vector3(transform.position.x + (direction.normalized.x * .08f), transform.position.y + (direction.normalized.y * .08f), 0);
        transform.position = newDirection;

        // destroys gameobject after it reaches a certain distance
        if (Vector3.Magnitude(direction - newDirection) > 5)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If it collides with a different player, increment them and decrement the local players' points
        if(collision.transform.tag == "Player" && collision.gameObject != player)
        {
            player.GetComponent<Player_PointsTracker>().totalPoints--;
            collision.gameObject.GetComponent<Player_PointsTracker>().totalPoints++;
            Destroy(gameObject);
        }
    }

}
