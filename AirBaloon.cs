using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
    

public class AirBaloon : MonoBehaviour
{
    public Airplus Airplus;
    Image timerBar;
    public float time = 200f;
    float timeLeft;

    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = time;
    }

    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            //timeLeft -= 1f * Time.deltaTime;
            timerBar.fillAmount = timeLeft / time;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
