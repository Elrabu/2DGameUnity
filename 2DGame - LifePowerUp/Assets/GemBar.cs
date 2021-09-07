using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemBar : MonoBehaviour
{

    public Slider slider;
    public AudioSource audioData;

    public void SetMaxGem(int gem)
    {
      slider.maxValue = gem;
    //  slider.value = gem;
    }

    public void SetGem(int gem)
    {
      slider.value = gem;
      if(gem > 0)
      {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
      }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
