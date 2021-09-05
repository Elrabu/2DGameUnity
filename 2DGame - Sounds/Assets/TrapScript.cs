using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    public HealthBar healthBar;
    public AudioSource audioData;

    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 1;

        healthBar.SetHealth(LifeTextScript.lifeAmount);

        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        
        if (LifeTextScript.lifeAmount < 1)
        {
          SceneManager.LoadScene("GameOver");
        }
    }
}
