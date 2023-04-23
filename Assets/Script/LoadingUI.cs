using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LoadingUI : MonoBehaviour
{
    public GameObject loadingUI;
    public Slider progressSlider;


    public void LoadScene(int index)
    {
        StartCoroutine(loadingScene_CorouLine(index));
    }

    public IEnumerator loadingScene_CorouLine(int index)
    {
        progressSlider.value = 0;
        loadingUI.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        float progress = 0; 
        while(!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime); ;
            progressSlider.value = progress;    
            if(progress>=0.88f)
            {
                progressSlider.value = 1;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
            
        }
    }
}
