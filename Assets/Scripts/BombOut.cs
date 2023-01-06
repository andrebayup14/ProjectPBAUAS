using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class BombOut : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform SpawnPoint;
    Vector3 targetPos;
    Rigidbody rb;
    public float bombSpeed = 5f;
    bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            isClicked = true;
        }
        else
        {
            isClicked = false;
        }
    }

    private void FixedUpdate()
    {
        if (isClicked)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            //if (Physics.Raycast(ray, out hit))
            //{
            //    targetPos = hit.point;

            GameObject ball = Instantiate(ProjectilePrefab, SpawnPoint.transform.position, SpawnPoint.rotation);
            rb = ball.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(0f, 1200f * ProjectilePrefab.GetComponent<Rigidbody>().mass, 0f));
            
        }
    }


}

