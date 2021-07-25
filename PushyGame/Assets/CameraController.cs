using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // private cause we set the value in script

    // Start is called before the first frame update
    void Start()
    {
        // offset calculated immediately but only needs to be done once
        offset = transform.position - player.transform.position;
    }

    // Change to late update so that the camera position only change after the player position
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
