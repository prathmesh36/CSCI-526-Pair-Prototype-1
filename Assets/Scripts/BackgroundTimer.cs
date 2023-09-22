using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTimer : MonoBehaviour
{
    public Material[] backgroundMaterials; // An array of different background materials.
    public float scrollSpeed = 1.0f; // Adjust the scrolling speed.
    public float gameTimeInSeconds = 28.0f; // Set the total game time in seconds.
    private Renderer backgroundRenderer; // Reference to the Renderer component of the background object.
    private int currentMaterialIndex = 0; // Index of the current background material.
    private float backgroundLength;
    private bool backgroundChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
        backgroundLength = backgroundRenderer.bounds.size.x;

        // Set the initial background material.
        SetBackgroundMaterial(currentMaterialIndex);
    }

    // Update is called once per frame
    void Update()
    {
        //MoveBackgrounds();

        if (!backgroundChanged)
        {
            float remainingTime = gameTimeInSeconds - Time.time;
            if (remainingTime <= 10.0f)
            {
                // Change the background 10 seconds before the game ends.
                ChangeBackground();
                backgroundChanged = true;
            }
        }
    }

    //private void MoveBackgrounds()
    //{
    //    Vector3 newPos = transform.position - Vector3.right * scrollSpeed * Time.deltaTime;
    //    transform.position = newPos;

    //    if (transform.position.x < -backgroundLength)
    //    {
    //        RepositionBackground();
    //    }
    //}

    private void RepositionBackground()
    {
        Vector3 newPos = transform.position + Vector3.right * backgroundLength * 2;
        transform.position = newPos;
    }

    public void ChangeBackground()
    {
        // Increment the material index to switch to the next background.
        currentMaterialIndex = (currentMaterialIndex + 1) % backgroundMaterials.Length;

        // Set the new background material.
        SetBackgroundMaterial(currentMaterialIndex);
    }

    private void SetBackgroundMaterial(int materialIndex)
    {
        if (materialIndex >= 0 && materialIndex < backgroundMaterials.Length)
        {
            backgroundRenderer.material = backgroundMaterials[materialIndex];
        }
        else
        {
            Debug.LogError("Invalid material index.");
        }
    }


}
