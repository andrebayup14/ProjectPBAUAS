using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTank : MonoBehaviour
{
    public Transform tower;
    public float towerSpeed;
    float towerAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        towerAngle += Input.GetAxis("Mouse X") * towerSpeed * Time.deltaTime;

        towerAngle = Mathf.Clamp(towerAngle, 0, 360);

        tower.localRotation = Quaternion.AngleAxis(towerAngle, Vector3.up);
    }
}
