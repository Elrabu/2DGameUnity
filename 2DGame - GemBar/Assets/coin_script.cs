using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{

    public GemBar gemBar;


    void OnTriggerEnter2D(Collider2D col)
    {

        ScoreTextScript.coinAmount += 1;

        gemBar.SetGem(ScoreTextScript.coinAmount);
        
        Destroy (gameObject);
    }

}
