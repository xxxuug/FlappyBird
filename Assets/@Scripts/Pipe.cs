using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -4.0f)
        {
            Destroy(gameObject);
        }
    }
}
