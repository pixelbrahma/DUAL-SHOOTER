using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    [SerializeField] private Transform spawnPrefabLeft;
    [SerializeField] private Transform spawnPrefabRight;
    private float time = 0.0f;
    [SerializeField] private float limit;
    private float y;

    private void Start()
    {
        y = Camera.main.orthographicSize;
    }

    private void Update()
    {
        time += 0.01f;
        if(time>=limit)
        {
            time = 0.0f;
            int choice = Random.Range(1, 3);
            if(choice == 1)
            {
                Vector3 position = new Vector3(-(transform.position.x -
                    GameObject.Find("LeftTurret").transform.position.x) / 3, y * 1.5f, 0);
                Instantiate(spawnPrefabLeft, position, Quaternion.identity);
            }
            else if (choice == 2)
            {
                Vector3 position = new Vector3((transform.position.x -
                    GameObject.Find("LeftTurret").transform.position.x) / 3, y * 1.5f, 0);
                Instantiate(spawnPrefabRight, position, Quaternion.identity);
            }
            if (limit > 0.45)
                limit -= 0.04f;
            else
                limit = 0.45f;
        }
    }
}
