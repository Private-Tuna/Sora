using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    void onCollisionEnter(Collision col) {
        if (col.GameObject.tag == "Player") {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
