using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombHit : MonoBehaviour
{
    public Rigidbody tank, bomb;
    public HealthBar healthBar;
    public int damage = 5;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        tank = GetComponent<Rigidbody>();
        health = healthBar.health; // ambil max health
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.health = health;   
    }
    private void OnCollisionEnter(Collision collision)
    {
        bomb = collision.rigidbody;
        health -= damage;

    }
}
