using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    //
    public GameObject[] obstaclePrefab;
    //
    Vector3 spawnPos = new Vector3(40, 0, 0);
    private float spawnInterval = 3.5f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle",startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle(){
        int i = Random.Range(0,obstaclePrefab.Length); 
        //check if game in yet to over
        if(!(playerControllerScript.gameOver)){
            spawnInterval = Random.Range(2, 5);//time for next spawn
            Instantiate(obstaclePrefab[i], spawnPos, obstaclePrefab[i].transform.rotation);
        }
    }
}
