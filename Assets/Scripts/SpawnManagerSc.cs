using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSc : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private int randomObstacle;

    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false) 
        {
            randomObstacle = Random.Range(0,obstaclePrefab.Length);
            Instantiate(obstaclePrefab[randomObstacle], spawnPosition, obstaclePrefab[randomObstacle].transform.rotation);
        }
    }
}
