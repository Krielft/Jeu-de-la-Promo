using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ClickedButton;
    public string Url;
    public void ButtonClick(string s)
    {
        audioSource.PlayOneShot(ClickedButton);
        if (s == "play")
        {
            SceneManager.LoadScene("Level1");
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
