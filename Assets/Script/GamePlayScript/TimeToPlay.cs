using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeToPlay : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI RunTime;
    [SerializeField] protected GameObject resuilt;
    [SerializeField] protected GameObject starbox;
    private float TimeLeft = 90f;
    private bool OnTime = true;
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
                GameOver();
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
        starbox.SetActive(true);
        resuilt.SetActive(true);
    }
    public void GameOver()
    {
        OnTime = false;
        starbox.SetActive(false);
        resuilt.SetActive(true);
    }    
}
