using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerView : Player
{
    

    PlayerController playerController = new PlayerController(); 

    private TextMeshProUGUI HPtext;
    private void Start()
    {
        HPtext = GameObject.Find("TextHp").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        playerController.HealthChenge(HPtext);

    }
}
