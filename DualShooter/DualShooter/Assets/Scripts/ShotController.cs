using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour {
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(gameObject.GetComponent<MeshRenderer>().material.color == 
            GameObject.Find("LeftTurret").GetComponent<MeshRenderer>().material.color)
        {
            rb.velocity = Vector2.right * moveSpeed;
        }
        else if (gameObject.GetComponent<MeshRenderer>().material.color ==
            GameObject.Find("RightTurret").GetComponent<MeshRenderer>().material.color)
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.GetComponent<MeshRenderer>().material.color ==
            GameObject.Find("LeftTurret").GetComponent<MeshRenderer>().material.color)
        {
            GameController.left = false;
            Destroy(this.gameObject);
        }
        else if (gameObject.GetComponent<MeshRenderer>().material.color ==
            GameObject.Find("RightTurret").GetComponent<MeshRenderer>().material.color)
        {
            GameController.right = false;
            Destroy(this.gameObject);
        }

        if(collision.collider.gameObject.tag == "Block")
        {
            if(GameController.lives != 0)
                GameController.score += 10;
        }
    }
}
