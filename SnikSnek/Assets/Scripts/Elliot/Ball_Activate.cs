using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Activate : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 direction;
    public Player_PointsTracker pointTracker;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        direction.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        // sets the direction and movement of bullet based on player direction/position
        Vector3 currentPosition = new Vector3(transform.position.x + (direction.x * .08f), transform.position.y + (direction.y * .08f), 0);
        transform.position = currentPosition;

        // destroys gameobject after it reaches a certain distance
        if (Vector3.Magnitude(startPosition - currentPosition) > 5)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If it collides with a different player, increment them and decrement the local players' points
        if(collision.transform.tag == "Player" && collision.gameObject != player)
        {
            pointTracker.TotalPoints--;
            collision.gameObject.GetComponent<Player_PointsTracker>().TotalPoints++;
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        pointTracker.BullletCount--;
    }
}
