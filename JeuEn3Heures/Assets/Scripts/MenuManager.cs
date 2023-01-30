using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ClickedButton;
    public GameObject conceptPanel;
    public GameObject creditsPanel;
    public string Url;
    public void ButtonClick(string s)
    {
        audioSource.PlayOneShot(ClickedButton);
        if (s == "play")
        {
            SceneManager.LoadScene("Level1");
        }
        if(s == "credits")
        {
            conceptPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }        
        if(s == "returncredits")
        {
            conceptPanel.SetActive(true);
            creditsPanel.SetActive(false);
        }
    }
    public void Open()
    {
        Application.OpenURL(Url);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
