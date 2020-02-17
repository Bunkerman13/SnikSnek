using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerJoinManager : MonoBehaviour
{
    [SerializeField]
    private Image[] playerImages;

    private bool[] joinedPlayers = { false, false, false, false, false };
    private int playerCount = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "PlayerJoin")
        {
            if (Input.GetButtonDown("Fire1") && !joinedPlayers[0])
            {
                playerCount++;
                joinedPlayers[0] = true;
                playerImages[0].enabled = true;
            }

            if (Input.GetButtonDown("Fire2") && !joinedPlayers[1])
            {
                playerCount++;
                joinedPlayers[1] = true;
                playerImages[1].enabled = true;
            }

            if (Input.GetButtonDown("Fire3") && !joinedPlayers[2])
            {
                playerCount++;
                joinedPlayers[2] = true;
                playerImages[2].enabled = true;
            }

            if (Input.GetButtonDown("Fire4") && !joinedPlayers[3])
            {
                playerCount++;
                joinedPlayers[3] = true;
                playerImages[3].enabled = true;
            }

            if (Input.GetButtonDown("Fire") && !joinedPlayers[4])
            {
                playerCount++;
                joinedPlayers[4] = true;
                playerImages[4].enabled = true;
            }

            if (playerCount > 1)
            {
                GameObject.Find("Ready").GetComponent<Text>().enabled = true;

                if (Input.GetButtonDown("Submit"))
                    SceneManager.LoadScene("Multiplayer");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Multiplayer")
        {
            EnablePlayers();
        }
    }

    private void EnablePlayers()
    {
        for (int i = 0; i < joinedPlayers.Length; i++)
            GameObject.Find("Player" + (i + 1)).SetActive(joinedPlayers[i]);
        
        Destroy(gameObject);
    }
}
