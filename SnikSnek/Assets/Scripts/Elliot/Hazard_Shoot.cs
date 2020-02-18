using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard_Shoot : MonoBehaviour
{

    public float shootPeriod;
    public float startDelay;
    public GameObject shot;
    public float probability;

    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = shootPeriod - startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        //*
        time += Time.deltaTime;

        if (time > shootPeriod)
        {
            time = 0;
        /*/
        // when the modular of total time and designated number is between these values, spawn a hazard
        if (Time.time % shootPeriod > 3f && Time.time % shootPeriod < 3.01f)
        {
        //*/
            // random value that determines if an absorber ball is shot
            float willShoot = Random.Range(0, 1f);
            if (willShoot < probability)
            {
                GameObject ball = Instantiate(shot, transform.position, Quaternion.identity);
                if (ball.GetComponent<Hazard_Activate>()) {
                    ball.GetComponent<Hazard_Activate>().direction = transform.up;
                }
                else
                {
                    ball.GetComponent<Absorber_Movement>().direction = transform.up;
                }
            }
        }
    }
}
