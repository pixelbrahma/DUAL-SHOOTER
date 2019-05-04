using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour {

    private void Start()
    {
        transform.position = new Vector3(0, (GameObject.Find("LeftTurret").transform.position.y - 4f), 0);
        transform.localScale = new Vector3(Camera.main.orthographicSize * Camera.main.aspect * 2, 1, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GameController.lives != 0)
            GameController.lives--;
    }
}
