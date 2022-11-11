using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerscript : MonoBehaviour
{
    public GameObject player;
    private Health healthPlayer;
    public GameObject mainCanvas;
   
    public GameObject gameOverCanvas;
    
    // Start is called before the first frame update
    public enum Gamestates
    {
        Playing,
        GameOver
    }
    public Gamestates gameState = Gamestates.Playing;
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case Gamestates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = Gamestates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                    
                    
                }
                
                break;
            
        }
    }
}
