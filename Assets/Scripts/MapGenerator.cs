using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapGenerator : MonoBehaviour
{

    private int floor = 1;
    private int wall = 2;
    private int hole = 3;
    public GameObject floorPrefab;
    public GameObject wallPrefab;
    public GameObject holePrefab;

    private int[,] map = new int[5, 5] {
    {1, 1, 2, 1, 3},
    {1, 2, 3, 1, 1 },
    {1, 3, 2, 2, 1 },
    {1, 2, 2, 2, 2 },
    {1, 1, 1, 3, 1 }
    };
    private int generated = 0;

    void Awake() {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        /*for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Debug.Log("Element " + i + ":" + j + " is " + map[i, j]);
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)&& generated == 0) {
            Debug.Log("D");
            for (int i = 0; i < map.GetLength(0); i++) {
                for (int j = 0; j < map.GetLength(1); j++) {
                    Debug.Log("Element " + i + ":" + j + " is " + map[i, j]);
                    if (map[i, j] == floor)
                    {
                        Instantiate(floorPrefab, new Vector3(i, 0, j), Quaternion.identity);
                    }
                    else if (map[i, j] == wall)
                    {
                        Instantiate(wallPrefab, new Vector3(i, 0.5f, j), Quaternion.identity);
                    }
                    else if (map[i, j] == hole) {
                        Instantiate(holePrefab, new Vector3(i, 0, j), Quaternion.identity);
                    }
                }
            }
            generated = 1;
        }

    }
}
