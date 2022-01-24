using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bullet;
    void Start()
    {
        bullet = GetComponent<Rigidbody>();
        bullet.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }
    void Update()
    {
        
    }
}
