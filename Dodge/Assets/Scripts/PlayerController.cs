using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float zMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(xMove, 0, zMove);
    }public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
