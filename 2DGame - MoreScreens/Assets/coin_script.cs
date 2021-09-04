using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coin_script : MonoBehaviour
{

    public GemBar gemBar;


    void OnTriggerEnter2D(Collider2D col)
    {

        ScoreTextScript.coinAmount += 1;

        gemBar.SetGem(ScoreTextScript.coinAmount);
        if(ScoreTextScript.coinAmount == 10)
        {
          SceneManager.LoadScene("WinScreen");
        }
        Destroy (gameObject);
    }

}
