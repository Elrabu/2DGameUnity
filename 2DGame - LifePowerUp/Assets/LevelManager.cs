using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void StartGame()
    {
        LifeTextScript.lifeAmount = 3;
        SceneManager.LoadScene ("SampleScene");
    }
    

    public void QuitGame()
    {
        Application.Quit ();
    }
}
