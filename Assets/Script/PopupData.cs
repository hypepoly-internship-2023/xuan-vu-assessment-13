using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupData : MonoBehaviour
{
    public static int heatFlus = 0;
    public void closePopup()
    {
        SceneManager.LoadScene("Home");
    }  
    public void MoreHeat()
    {
        heatFlus = 5;
        SceneManager.LoadScene("Home");
    }    
}
