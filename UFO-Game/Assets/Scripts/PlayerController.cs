using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int count;
    public float speed;
    private Rigidbody2D rb2d;

    //Text, public
    public Text count_Text;
    public Text win_Text;

    private void Start()
    {
        count = 0;
        rb2d = GetComponent<Rigidbody2D>();
        win_Text.text = "";
        SetCountText();
    }

    private void FixedUpdate()
    {
        float move_Horizontal = Input.GetAxis("Horizontal");
        float move_Vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(move_Horizontal, move_Vertical);
        rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    void SetCountText()
    {
        count_Text.text = "Count: " + count.ToString();
        if (count >= 12)
            win_Text.text = "You win!";
    }
}
