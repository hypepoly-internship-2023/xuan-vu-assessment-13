using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI LoadPercent;
    [SerializeField] private Slider slider;
    public void Start()
    {
        StartCoroutine(LoadScene("Home"));
    }
    IEnumerator LoadScene(string SceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);
        while(!operation.isDone)
        {
            float process = Mathf.Clamp01(operation.progress/0.9f);
            slider.value = process;
            LoadPercent.text = process * 100f +"%";
            yield return null;
        }    
    }    
}
