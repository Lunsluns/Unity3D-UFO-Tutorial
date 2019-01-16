using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    { //Rotate transform of game object this is attached to by 15 degrees; takes account time elapsed since last frame.
        transform.Rotate(new Vector3(0, 0, 15) * Time.deltaTime);
    }
}
