using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerJoinManager : MonoBehaviour
{
    [SerializeField]
    private Sprite playerSprite;

    private bool[] joinedPlayers = { false, false, false, false };
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
            }

            if (Input.GetButtonDown("Fire2") && !joinedPlayers[1])
            {
                playerCount++;
                joinedPlayers[1] = true;
            }

            if (Input.GetButtonDown("Fire3") && !joinedPlayers[2])
            {
                playerCount++;
                joinedPlayers[2] = true;
            }

            if (Input.GetButtonDown("Fire4") && !joinedPlayers[3])
            {
                playerCount++;
                joinedPlayers[3] = true;
            }

            if (playerCount > 1)
            {
                if (Input.GetButtonDown("Submit")) ;
            }
        }
    }

    private void EnablePlayers()
    {

    }
}
