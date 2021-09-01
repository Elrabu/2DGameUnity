using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 1;

        if (LifeTextScript.lifeAmount < 1)
        {
          SceneManager.LoadScene("GameOver");
        }
    }
}
