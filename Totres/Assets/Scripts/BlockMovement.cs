using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    private Transform tf;

    public float speed;
	// Use this for initialization
	void Start ()
	{
	    tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
	    {
	        tf.position = tf.position + Vector3.left;
	    }


	    if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
	    {
	        tf.position = tf.position + Vector3.right;
	    }
    }
}
