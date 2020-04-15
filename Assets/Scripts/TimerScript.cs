using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image BarTimer;
    public float maxTimer = 500f;
    float timerLeft;

    // Start is called before the first frame update
    void Start(){
        BarTimer = GetComponent<Image>();
        timerLeft = maxTimer;
    }

    // Update is called once per frame
    void Update(){
        if(timerLeft > 0){
            timerLeft -= Time.deltaTime;
            BarTimer.fillAmount = timerLeft / maxTimer;
        } else {
            // Time.timeScale = 0f;
        }
    }
}
