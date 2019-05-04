using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePosition : MonoBehaviour {

    private void Awake()
    {
        float y = Camera.main.orthographicSize;
        float x = Camera.main.aspect * y;
        if(transform.gameObject.name == "LeftTurret")
            transform.position = new Vector3(-x + transform.localScale.x / 2, -y + y / 2, 0);
        else if (transform.gameObject.name == "RightTurret")
            transform.position = new Vector3(x - transform.localScale.x / 2, -y + y / 2, 0);
    }

}
