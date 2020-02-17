using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float gameTime;

    public float currTime;

    Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
        currTime = gameTime;
        timerText.text = string.Format("{0:00}:{1:00}", (int)gameTime / 60, 0);
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;

        if(currTime <= 0)
        {
            Player_PointsTracker.TimeUp();
        }
        int minutes = (int)currTime / 60;
        int seconds = (int)currTime - 60 * minutes;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds );
    }
}
