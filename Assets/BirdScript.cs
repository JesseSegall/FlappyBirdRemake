using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField]private Rigidbody2D myRigidbody;

     [SerializeField]private float flapStrength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
        
    }
}
