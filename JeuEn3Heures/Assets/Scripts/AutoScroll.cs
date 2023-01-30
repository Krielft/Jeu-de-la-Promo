using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    public float scrollSpeed = 10.0f;

    void Update()
    {
        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;
    }
}
