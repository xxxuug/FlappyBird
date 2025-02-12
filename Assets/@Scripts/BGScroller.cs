using UnityEngine;

public class BGScroller : MonoBehaviour
{
    public float speed = 1.0f;
    float offset_x;
    private Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    void Update()
    {
        offset_x = speed * Time.deltaTime;
        rd.material.mainTextureOffset += Vector2.right * offset_x;
    }
}
