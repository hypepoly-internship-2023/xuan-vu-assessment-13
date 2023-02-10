using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ScreenGameCrtl : MonoBehaviour
{
    [SerializeField] private GameObject PausePopup;
    [SerializeField] private GameObject ResultPopup;
    [SerializeField] private GameObject popupVote;
    public void onPause()
    {
        PausePopup.SetActive(true);
    }
    public void onResume()
    {
        PausePopup.SetActive(false);
    }
    public void OnVote()
    {
        popupVote.SetActive(true);
    }
    public void OffVote()
    {
        popupVote.SetActive(false);
    }
    public void BackHome()
    {
        SceneManager.LoadScene("Home");
    }
}
