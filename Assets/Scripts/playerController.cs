using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    [SerializeField] float score = 0f;
    public float hscore = 0f;
    [SerializeField] Text scoreText;
    Rigidbody2D rgBody;
    public colorManager colorManager;
    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        scoreText.text = score + "";
    }
    private void Awake()
    {
        ChangeColor();
        scoreText.text = score + "";
    }
    private void ChangeColor() {
        GetComponent<SpriteRenderer>().color = colorManager.GetRandomColor();
    }
    private void Jump()
    {
        if (Input.GetMouseButton(0))
        {
            rgBody.velocity = transform.up * jumpForce;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Color Changer") {
            ChangeColor();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Star") {
            score++;
            Destroy(collision.gameObject);
        }
    }
}
