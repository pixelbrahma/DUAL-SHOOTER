using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartionPositioning : MonoBehaviour {

    private void Start()
    {
        transform.localScale = new Vector3(0.5f, Camera.main.orthographicSize * 2, 1);
    }
}
