using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerForMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip PointerEnterSound;
    public void PointerEnter()
    {
        transform.localScale = new Vector2(1.4f, 1.4f);
        audioSource.PlayOneShot(PointerEnterSound);
    }
    public void PointerExit()
    {
        transform.localScale = new Vector2(1f, 1f);
    }
}
