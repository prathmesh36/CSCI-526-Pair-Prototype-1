using UnityEngine;

public class LoopingBackgroundControl : MonoBehaviour
{
    public Renderer backgroundRenderer;
    private float backgroundSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
