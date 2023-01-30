using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    public float scrollSpeed = 10.0f;
    public Transform player;

    private Camera mainCamera;
    private bool playerIsDead = false;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (playerIsDead)
        {
            return;
        }

        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;

        Vector3 viewportPoint = mainCamera.WorldToViewportPoint(player.position);
        if (viewportPoint.x < 0 || viewportPoint.x > 1)
        {
            // player has gone off screen and should die
            playerIsDead = true;
            Destroy(player.gameObject);
        }
    }
}
