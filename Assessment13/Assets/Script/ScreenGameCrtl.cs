using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ScreenGameCrtl : MonoBehaviour
{
    [SerializeField] private GameObject PausePopup;
    [SerializeField] private GameObject ResultPopup;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.currentSelectedGameObject)
                return;
            else
                ResultPopup.gameObject.SetActive(true);
        }    
    }
    public void onPause()
    {
        PausePopup.SetActive(true);
    }
    public void onResume()
    {
        PausePopup.SetActive(false);
    }
    public void BackHome()
    {
        SceneManager.LoadScene("Home");
    }
}
