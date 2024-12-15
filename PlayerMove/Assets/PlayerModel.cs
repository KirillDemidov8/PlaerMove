using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerModel 
{
    int maxHp = 5;


    public void OnHealthChange(TextMeshProUGUI text)
    {
        maxHp--;
        text.text = maxHp.ToString();
        if (maxHp > 0)
        {
            Debug.Log(maxHp);
           
        }
        else if (maxHp == 0)
        {
            OnPlayerDeath();
        }
       
    }

    public void OnPlayerDeath()
    {
        Debug.Log("OnPlayerDeath");
    }


}
