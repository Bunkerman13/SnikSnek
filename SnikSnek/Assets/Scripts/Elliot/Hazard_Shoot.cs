using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Shoot : MonoBehaviour
{

    public float number;
    public GameObject pointBall;
    public GameObject absorber;
    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(5f, 11f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time % number);
        // when the modular of total time and designated number is between these values, spawn a hazard
        if (Time.time % number > 3f && Time.time % number < 3.01f)
        {
            // random value that determines if an absorber ball is shot
            int shootAbsorber = Random.Range(1, 11);
            if (shootAbsorber != 10)
            {
                GameObject ball = Instantiate(pointBall, transform.position, Quaternion.identity);
                ball.GetComponent<Hazard_Activate>().direction = Vector3.zero - transform.position;
            }
            else
            {
                GameObject absorb = Instantiate(absorber, transform.position, Quaternion.identity);
                absorb.GetComponent<Absorber_Movement>().direction = Vector3.zero - transform.position;
            }
        }
    }
}
