using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    Player_PointsTracker pointTracker;
    public GameObject pointBall;
    [SerializeField] string fireInputAxis;

    // Start is called before the first frame update
    void Start()
    {
        pointTracker = GetComponent<Player_PointsTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(fireInputAxis) && pointTracker.ShoootWorthy())
        {
            GameObject ball = Instantiate(pointBall, transform.position, Quaternion.identity);
            Ball_Activate bulletScript = ball.GetComponent<Ball_Activate>();

            bulletScript.startPosition = transform.position;
            bulletScript.direction = transform.up;//gameObject.GetComponent<Player_Movement>().direction;
            bulletScript.player = gameObject;
            bulletScript.pointTracker = pointTracker;

            pointTracker.BullletCount++;
        }
    }
}
