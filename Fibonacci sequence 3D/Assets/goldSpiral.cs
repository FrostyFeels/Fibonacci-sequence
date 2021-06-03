using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldSpiral : MonoBehaviour
{
    public int directionX;
    public int directionY;
    private int currentNumber;

    public GameObject prefab;
    public Transform childPrefab;

    private Vector3 spawnPosition;
    private float currentSize;

    private float numberToLeft;
    private float numberToRight;
    private float numberToAbove;
    private float numberToDown = 1;

    private float oldNumberToRight;
    private float oldNumberToLeft;
    private float oldNumberToAbove;
    private float oldNumberToDown = 1;

    private float normalSize = 0.3f;

    private float oldSize;




    public void Start()
    {
        
    }


    public void spawnCube(float size)
    {
        
        currentSize = size;


        if(currentNumber < 1)
        {
            GameObject firstTile = Instantiate(prefab, prefab.transform.position, Quaternion.identity);
            firstTile.transform.localScale = firstTile.transform.localScale * size;
            firstTile.transform.localScale = new Vector3(firstTile.transform.localScale.x, firstTile.transform.localScale.y, 0f);

            oldSize = firstTile.transform.localScale.x;
            spawnPosition = firstTile.transform.position;
            currentNumber++;
            return;
        }

        if (currentNumber < 2)
        {
            GameObject firstTile = Instantiate(prefab, prefab.transform.position, Quaternion.identity);
            firstTile.transform.localScale = firstTile.transform.localScale * size;
            firstTile.transform.localScale = new Vector3(firstTile.transform.localScale.x, firstTile.transform.localScale.y, 0f);

            firstTile.transform.position += new Vector3(firstTile.transform.localScale.x, 0f, 0f);
            spawnPosition = firstTile.transform.position;
            oldSize = firstTile.transform.localScale.x;
            currentNumber++;
            return;
        }


        if (currentNumber < 3)
        {
            GameObject firstTile = Instantiate(prefab, spawnPosition, Quaternion.identity);
            firstTile.transform.localScale = firstTile.transform.localScale * currentSize;
            firstTile.transform.localScale = new Vector3(-firstTile.transform.localScale.x, -firstTile.transform.localScale.y, 0f);

            firstTile.transform.position += new Vector3(oldSize, 0f, 0f);
            spawnPosition = firstTile.transform.position;
            oldSize = firstTile.transform.localScale.x;
            currentNumber++;
            directionY = -1;
            return;
        }

        GameObject tile = Instantiate(prefab, spawnPosition, Quaternion.identity);
        Debug.Log(directionY);
        Debug.Log(directionX);

        if (directionX > 0)
        {
            tile.name = "Right";
            startPosition(0, tile);
            directionX = 0;
            directionY = 1;
            return;
        }

        if (directionX < 0)
        {
            tile.name = "Left";
            startPosition(1, tile);
            directionX = 0;
            directionY = -1;
            return;
        }

        if (directionY > 0)
        {
            tile.name = "Up";
            startPosition(2, tile);
            directionY = 0;
            directionX = -1;
            return;
        }

        if (directionY < 0)
        {
            tile.name = "Down";
            startPosition(3, tile);
            directionX = 1;
            directionY = 0;
            return;
        }






        currentNumber++;
    }

    void startPosition(int dir, GameObject tile)
    {

        childPrefab = tile.GetComponentInChildren<Transform>();

        switch (dir)
        {
            case 0:
                


                tile.transform.localScale = tile.transform.localScale * currentSize;
                tile.transform.localScale = new Vector3(tile.transform.localScale.x, tile.transform.localScale.y, 0f);

                tile.transform.position += new Vector3(oldSize, oldSize, 0f);
                spawnPosition = tile.transform.position;
                oldSize = tile.transform.localScale.x;
                break;
            case 1:

                

                tile.transform.localScale = tile.transform.localScale * currentSize;
                tile.transform.localScale = new Vector3(-tile.transform.localScale.x, -tile.transform.localScale.y, 0f);

                tile.transform.position += new Vector3(oldSize, oldSize, 0f);
                spawnPosition = tile.transform.position;
                oldSize = tile.transform.localScale.x;
                break;
            case 2:

           

                tile.transform.localScale = tile.transform.localScale * currentSize;
                tile.transform.localScale = new Vector3(tile.transform.localScale.x, -tile.transform.localScale.y, 0f);

                tile.transform.position += new Vector3(oldSize, -oldSize, 0f);
                spawnPosition = tile.transform.position;
                oldSize = tile.transform.localScale.x;
                break;
            case 3:

                

                tile.transform.localScale = tile.transform.localScale * currentSize;
                tile.transform.localScale = new Vector3(-tile.transform.localScale.x, tile.transform.localScale.y, 0f);

                tile.transform.position += new Vector3(oldSize, -oldSize, 0f);
                spawnPosition = tile.transform.position;
                oldSize = tile.transform.localScale.x;
                break;




        }
    }


    


}
