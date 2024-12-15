using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController 
{
    PlayerModel playerModel = new PlayerModel();
    public void HealthChenge(TextMeshProUGUI HPtext)
    {
        playerModel.OnHealthChange(HPtext);
    }
}
