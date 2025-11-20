using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float theTime;
    public float speed = 1;
    TMP_Text TimerText;
    public bool playing;
        
       
    void Start()
    {
        TimerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {
            theTime += 1 * Time.deltaTime * speed;
            string hours = Mathf.Floor((theTime % 2160000) / 3600).ToString("00");
            string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
            string seconds = (theTime % 60).ToString("00");
            TimerText.text = hours + ":" + minutes + ":" + seconds;
        }
    }

  

}
