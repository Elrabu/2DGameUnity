using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTextScript : MonoBehaviour
{
    Text text;
    public static int lifeAmount = 4;
    public static int maxHealth = 4;

    public HealthBar healthBar;

    void Start()
    {

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
