using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    public HealthBar healthBar;

    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 1;

        healthBar.SetHealth(LifeTextScript.lifeAmount);

        if (LifeTextScript.lifeAmount < 1)
        {
          SceneManager.LoadScene("GameOver");
        }
    }
}
