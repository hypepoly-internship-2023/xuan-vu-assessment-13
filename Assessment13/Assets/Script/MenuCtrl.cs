using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    [SerializeField] private Transform menu;
    [SerializeField] private TextMeshProUGUI numberHeat;
    [SerializeField] private Transform setting;
    [SerializeField] private Transform popupVote;
    [SerializeField] private GameObject moreHeat;
    public static PopupData instance;
    string heatPrefs = "NumberOfHeat";
    private void Start()
    {
        PlayerPrefs.SetInt(heatPrefs, PopupData.heatFlus);
        numberHeat.text = PlayerPrefs.GetInt(heatPrefs).ToString();
    }
    public void OnPlay()
    {
        int heat = int.Parse(numberHeat.text);
        if (heat > 0)
        {
            LoadGame();
        }
        else
            SceneManager.LoadScene("Popup");
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
    public void OffMoreHeat()
    {
        moreHeat.gameObject.SetActive(false);
    } 
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }    
}
