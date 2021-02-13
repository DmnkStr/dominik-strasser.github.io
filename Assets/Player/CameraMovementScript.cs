using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    private GameObject player;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + originalPosition;
    }
}
