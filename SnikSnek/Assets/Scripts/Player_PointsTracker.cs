using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_PointsTracker : MonoBehaviour
{
    public float totalPoints;

    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Text>().text = totalPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
