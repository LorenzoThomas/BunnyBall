using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;//false, true 
    public GameObject winnerUI;
    public GameObject player;

    
    //PascalCase
    private void Update()

    {
        if (gameOver == true) {
            GameOver();
        }
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
