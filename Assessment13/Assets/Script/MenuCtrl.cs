using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    [SerializeField] private Transform menu;
    [SerializeField] private Transform levelSelect;
    [SerializeField] private Transform setting;
    [SerializeField] private Transform popupVote;
    public void OnPlay()
    {
        menu.gameObject.SetActive(false);
        levelSelect.gameObject.SetActive(true);
    }
    public void OffPlay()
    {
        levelSelect.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }
    public void OnSetting()
    {
        setting.gameObject.SetActive(true);
    }
    public void OffSetting()
    {
        setting.gameObject.SetActive(false);
    }
    public void OnVote()
    {
        popupVote.gameObject.SetActive(true);
    }
    public void OffVote()
    {
        popupVote.gameObject.SetActive(false);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }    
}
