using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{

    public bool isRunning = true;
    public Slider slider;
    public float speed = 0.1f;
    float time = 0f;
    public GameObject btnStart;
    public GameObject panelTransition;
  


    void Start()
    {
        slider.gameObject.SetActive(true);
        btnStart.SetActive(false);
       
        isRunning = true;
    }
   
    void Update()
    {
        if (isRunning)
        {
            UpdateSliderValue();
            CheckSliderCompletion();
        }
    }

    void UpdateSliderValue()
    {
        time += Time.deltaTime * speed;
        slider.value = time;
    }



    void CheckSliderCompletion()
    {
        if (time >= 1)
        {
            CompleteSlider();


        }
    }

    void CompleteSlider()
    {
        btnStart.SetActive(true);
        slider.gameObject.SetActive(false);
    }

}