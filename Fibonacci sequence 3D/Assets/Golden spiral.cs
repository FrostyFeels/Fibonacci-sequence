using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldenspiral : MonoBehaviour
{
    private int directionX;
    private int directionY;
    private int currentNumber;

    public GameObject prefab;

    private Vector3 spawnPosition;  


    public void spawnCube(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            for (int j = 0; j < amount; j++)
            {
                GameObject newTile = Instantiate(prefab, transform.position, Quaternion.identity);
            }
               
        }
    }
}
