using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate = 2;
    [SerializeField] private float heightOffset = 10;
    private float _timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update() {

        if (_timer < spawnRate) {
            _timer += Time.deltaTime;
        }
        else {
            SpawnPipe();
            _timer = 0;
        }
       
    }

    void SpawnPipe() {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
