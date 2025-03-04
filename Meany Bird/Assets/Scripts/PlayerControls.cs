using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Game manager object
    [Header("Game Controller Object for controlling the game")]
    public GameController gameController;
    [Header("Velocity")]
    public float velocity = 5; //Corrected the header to "Velocity"
    //Physics for the bird
    private Rigidbody2D rb;
    //Height of the bird object on the y axis
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        //Game Controller component
        gameController = GetComponent<GameController>();
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object Height equals the size of the height of the sprite
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // GameObject.Find("GameController").GetComponent<GameController>().GameOver();
            rb.velocity = Vector2.up * velocity;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "HighSpike" || collision.gameObject.tag == "LowSpike" || collision.gameObject.tag == "Ground") 
        {
            //Game is at a stopping state
            //Time.timeScale = 0;
            GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        }
    }
}

