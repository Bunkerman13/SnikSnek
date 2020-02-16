using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_PointsTracker : MonoBehaviour
{
    #region Static stufff for tracking who's in the lead
    static string winnnerId;
    static float lowScore;

    static bool CheckForHighest(string id, float points)
    {
        if (points > 10)
        {
            winnnerId = "";
            return true;
        }
        if (points < lowScore)
        {
            winnnerId = id;
            lowScore = points;
        }
        return false;
    }
    #endregion

    float points;
    string iD;
    public float TotalPoints
    {
        set
        {
            points = value;
            if (CheckForHighest(iD, points))
            {
                OnDestroy(); //Fun way to end scene
            }
        }
        get
        {
            return points;
        }
    }
    public int BullletCount { get; set; }

    public bool ShoootWorthy() { return points - BullletCount > 0; }

    // Start is called before the first frame update
    void Start()
    {
        iD = GetComponent<Player_Identifier>().iD.ToString();
        winnnerId = iD;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Text>().text = points.ToString();
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("Victor", winnnerId.ToString());
        SceneManager.LoadScene("TestEnd");
    }
}
