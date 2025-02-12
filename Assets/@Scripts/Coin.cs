using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -4.0f)
        {
            Destroy(gameObject);
        }
    }
}
