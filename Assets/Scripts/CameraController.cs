using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform PlayerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = PlayerTransform.position.x;
        float y = transform.position.y;

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
