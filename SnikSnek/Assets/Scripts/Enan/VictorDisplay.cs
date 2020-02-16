using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictorDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text t = GetComponent<Text>();
        string victor = PlayerPrefs.GetString("Victor");
        if (victor == "")
        {
            t.text = "Y'alll lost ya bufffooons";
        }
        else
        {
            t.text = "Player " + victor + " won.";
        }
        t.text += "\nPresss Enter to continue";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Multiplayer");
        }
    }
}
