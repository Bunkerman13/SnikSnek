using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartUp : MonoBehaviour
{
    public GameObject[] selCanvas;
    public GameObject currMPNumber;
    public string gameSceneName;

    int noPlayers = 2;
    Text currMPNumberText;

    // Start is called before the first frame update
    void Start()
    {
        ToggleSelCanvas(false);
        currMPNumberText = currMPNumber.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMultiPlayer()
    {
        ToggleSelCanvas(true);
        ToggleCurrMPNumber(false);
    }

    void ToggleSelCanvas(bool b)
    {
        foreach (GameObject c in selCanvas)
        {
            c.SetActive(b);
        }
    }

    public void SelectMP2()
    {
        noPlayers = 2;
        ToggleCurrMPNumber(true);
        ToggleSelCanvas(false);
    }

    public void SelectMP3()
    {
        noPlayers = 3;
        ToggleCurrMPNumber(true);
        ToggleSelCanvas(false);
    }

    public void SelectMP4()
    {
        noPlayers = 4;
        ToggleCurrMPNumber(true);
        ToggleSelCanvas(false);
    }

    void ToggleCurrMPNumber(bool b)
    {
        currMPNumberText.text = noPlayers.ToString();
        currMPNumber.SetActive(b);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("MPCount", noPlayers);
        SceneManager.LoadScene(gameSceneName);
    }
}
