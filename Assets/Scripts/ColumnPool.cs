using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float SpawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    private GameObject[] colums;
    private Vector2 objectPoolPosition = new Vector2(-15f,-25f);
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

    private float timeSinceLastSpawnd;
	// Use this for initialization
	void Start () {

		colums = new GameObject[columnPoolSize];

	    for (int i = 0; i < columnPoolSize; i++)
	    {
	        colums[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
	    }
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timeSinceLastSpawnd += Time.deltaTime;

	    if (GameControl.instance.gameOver == false && timeSinceLastSpawnd >= SpawnRate)
	    {
	        timeSinceLastSpawnd = 0;
	        float spawmYPosition = Random.Range(columnMin, columnMax);
	        colums[currentColumn].transform.position = new Vector2(spawnXPosition, spawmYPosition);
	        currentColumn++;
	        if (currentColumn >= columnPoolSize)
	        {
	            currentColumn = 0;
	        }
	    }
	}
}
