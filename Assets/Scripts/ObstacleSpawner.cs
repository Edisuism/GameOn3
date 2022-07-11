using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float maxY, minY, maxX, minX, minTime, maxTime;
    private float timer;


    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Spawn();
            timer = Random.Range(minTime, maxTime);
        }

        void Spawn()
        {
            float randX = Random.Range(minX, maxX);
            float randY = Random.Range(minY, maxY);

            Instantiate(obstacle, transform.position + new Vector3(randX, randY, 0), transform.rotation);
        }
    }
}
