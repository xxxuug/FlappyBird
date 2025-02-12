using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdCtrl : MonoBehaviour
{
    public TMP_Text ScoreText;

    private Rigidbody2D rb;
    private int score = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * 250);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Pipe"))
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 50;
            Destroy(other.gameObject);
            ScoreText.text = $"Score : {score}";
        }
    }
}
