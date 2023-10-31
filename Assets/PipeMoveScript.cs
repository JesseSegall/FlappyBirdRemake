using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5;

    [SerializeField] private float deadZone = -60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        transform.position += Vector3.left * (Time.deltaTime * moveSpeed);

        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }

    }
}
