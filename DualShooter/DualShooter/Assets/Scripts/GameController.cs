using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] private Transform shotPrefab;
    public static bool left = false, right = false;
    public static int score = 0;
    public static int lives = 3;

    private void Update()
    {
        if(lives == 0)
        {
            Destroy(GameObject.Find("Partition").GetComponent<SpawnController>());
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!left && !right)
            {
                Vector3 position = GameObject.Find("LeftTurretGun").transform.position;
                Transform shot = Instantiate(shotPrefab, new Vector3(position.x + 1.2f, position.y, 0),
                    Quaternion.identity);
                shot.gameObject.GetComponent<MeshRenderer>().material.color =
                    GameObject.Find("LeftTurret").GetComponent<MeshRenderer>().material.color;
                left = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (!right && !left)
            {
                Vector3 position = GameObject.Find("RightTurretGun").transform.position;
                Transform shot = Instantiate(shotPrefab, new Vector3(position.x - 1.2f, position.y, 0),
                    Quaternion.identity);
                shot.gameObject.GetComponent<MeshRenderer>().material.color =
                    GameObject.Find("RightTurret").GetComponent<MeshRenderer>().material.color;
                right = true;
            }
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "SCORE : " + score.ToString());
        GUI.Label(new Rect(10, 30, 100, 100), "LIVES : " + lives.ToString());
        if (lives == 0)
        {
            GUI.Label(new Rect(Screen.width/2 - 50, Screen.height/2, 100, 100), "GAME OVER !!!!");
        }
    }
}
