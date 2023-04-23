using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject Content;
    [SerializeField] GameObject Shopbutton;

    public string ScenePlay;

    public void Show()
    {
        Content.SetActive(true);
    }

    public void Hide()
    {
        Content.SetActive(false);
        Shopbutton.SetActive(true);
        Time.timeScale = 1f;

    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(ScenePlay);
    }
}
