using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    Player_PointsTracker totalPoints;
    public GameObject pointBall;

    // Start is called before the first frame update
    void Start()
    {
        totalPoints = GetComponent<Player_PointsTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire2"))
        {
            GameObject ball = Instantiate(pointBall, transform.position, Quaternion.identity);
            ball.GetComponent<Ball_Activate>().direction = gameObject.transform.position;
        }
    }
}
