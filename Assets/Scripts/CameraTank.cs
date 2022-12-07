using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTank : MonoBehaviour
{
    public float smoothCam;
    public float smoothRotCam;
    public Transform tank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, tank.position, smoothCam);
        transform.rotation = Quaternion.Slerp(transform.rotation, tank.rotation, smoothRotCam);
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
    }
}
