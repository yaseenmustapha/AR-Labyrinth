using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    GameManager gameManager;

    // Start is called before the first frame update
    void Start() {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death() {
        gameManager.FailLevel();
    }

    public void Win() {
        gameManager.CompleteLevel();
    }
}
