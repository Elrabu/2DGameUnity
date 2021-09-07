using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount = 0;
    public static int maxgem = 10;

    public GemBar gemBar;

    void Start()
    {
        gemBar.SetMaxGem(maxgem);
    }


    void Update()
    {

    }
}
