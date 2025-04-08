using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision) {
        GameObject.Find("DoodleHead").SetActive(false);
        GameController.gameOver();
    }
    [Header("Platform Object")]
    public GameObject platform;
    float yPos = 0;
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    public static void GameOver() {
        instance.gameOverCanvas.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
