using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxYPos;
    public float spawnTime;
    public GameObject pipe;

	// Use this for initialization
	void Start () {
        //startSpawningPipes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startSpawningPipes() {
        InvokeRepeating("spawnPipe", 0.2f, spawnTime);
    }

    public void stopSpawningPipes() {
        CancelInvoke("spawnPipe");
    }

    void spawnPipe() {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(1.5f, maxYPos), 0), Quaternion.identity);
    }
}
