using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;         

    void Start()
    {   //transform.position gets position of camera
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate() // waits after all items have been updated
    {   // as movement done, it will act as if it was a child of the player object
        transform.position = player.transform.position + offset;
    }
}
