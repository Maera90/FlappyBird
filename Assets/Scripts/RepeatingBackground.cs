using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundColider;

    private float groundHorizontalLength;
	// Use this for initialization
	void Start ()
	{
	    groundColider = GetComponent<BoxCollider2D>();
	    groundHorizontalLength = groundColider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
	    if (transform.position.x < -groundHorizontalLength)
	    {
	        RepositionBackground();
	    }
	}

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2((groundHorizontalLength * 2f)-0.5f,0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
