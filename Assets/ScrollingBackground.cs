using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Transform player;          // Referensi ke objek karakter
    public float scrollSpeed = 0.1f;   // Kecepatan scroll background

    private Vector3 startPosition;

    void Start()
    {
        // Simpan posisi awal background
        startPosition = transform.position;
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogError("Player reference is not assigned in the ScrollingBackground script.");
            return; // Prevent further errors if player is not assigned
        }

        // Geser background berdasarkan pergerakan karakter
        float newPositionX = startPosition.x + (player.position.x * scrollSpeed);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
