using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeToPlay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI RunTime;
    private float TimeLeft = 90f;
    public bool OnTime = true;
    private void Update()
    {
        if(OnTime)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                FormatTime(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                RunTime.text = "Game Over";
                OnTime = false;
            }
        }     
    }
    void FormatTime(float TimeLeft)
    {
        TimeLeft += 1;
        float minutes = Mathf.FloorToInt(TimeLeft / 60);
        float seconds = Mathf.FloorToInt(TimeLeft % 60);
        RunTime.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    private void OnTriggerEnter(Collider other)
    {
        OnTime = false ;
        RunTime.text = "Win";
    }
    public void GameOver()
    {
        OnTime = false;
        RunTime.text = "Game Over";
    }    
}
