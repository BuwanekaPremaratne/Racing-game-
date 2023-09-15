using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public Transform spawnPoint;
    public Canvas canvas;

    public GameObject cars;
    private GameObject newCar;
    private bool startSpawning;
    public float spawnInterval = 2f;

    public float timeSinceLastSpawn = 0;

    

    void Update()
    {
        if (startSpawning)
        {
            timeSinceLastSpawn += Time.deltaTime;

            if (timeSinceLastSpawn >= spawnInterval)
            {
                CarSpawn();
                timeSinceLastSpawn = 0f;
            }

        }

        if(newCar!=null &&newCar.transform.position.y==-100)
        {
            Destroy(newCar);

        }


    }

    public void OnStart()
    {
        startSpawning = true;

    }

    public void OnEnd()
    {
        startSpawning = false;

    }

    void CarSpawn()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-50f, 50f), 180, 1f);
        newCar = Instantiate(cars, spawnPosition, Quaternion.identity);
        newCar.transform.SetParent(canvas.transform, false);


    }




}
