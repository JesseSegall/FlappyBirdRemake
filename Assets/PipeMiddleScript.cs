using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public GameObject bird;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        BirdScript birdScript = bird.GetComponent<BirdScript>();
        bool isAlive = birdScript.IsBirdAlive();
        if (collision.gameObject.layer == 3 && isAlive ) {
            Debug.Log("Middle Pipe Collision");
            logic.AddScore(1);
        }
        
      
    }
}
