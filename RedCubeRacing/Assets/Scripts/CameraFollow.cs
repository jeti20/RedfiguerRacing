using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = new Vector3(0, 5.62f, -6.96f) + player.transform.position;
    }
}
