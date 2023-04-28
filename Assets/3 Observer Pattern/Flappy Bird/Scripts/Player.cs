using CommandPatterns.Calculator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public int jumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    //Make the bird jump
    public void Jump()
    {
        rigidbody.velocity = new Vector2(0, jumpForce);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Score")
        {
            Debug.Log("Score");
            //GameManager.Instance.ScoreIncrement();
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Kill")
        {
            Debug.Log("Kill");
            //GameManager.Instance.GameOver();
        }
    }
}
