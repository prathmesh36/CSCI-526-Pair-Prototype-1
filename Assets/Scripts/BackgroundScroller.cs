using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-10f, 10f)]
    public float scrollSpeed = 10f;
    private float offset;
    private Material mat;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed);
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
