using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float velocity;
    public logicScript logic;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * velocity;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.showGameOver();
    }
}
