using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeUpScript : MonoBehaviour
{

    public HealthBar healthBar;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
      LifeTextScript.lifeAmount += 1;

      healthBar.SetHealth(LifeTextScript.lifeAmount);
      healthBar.setSound(1);
      
      Destroy (gameObject);
    }
}
