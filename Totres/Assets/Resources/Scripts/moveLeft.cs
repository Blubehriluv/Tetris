using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour {
    private Transform tf;
    public float speed;
    // Use this for initialization
    void Start () {
        tf = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
	    tf.position = tf.position + (Vector3.left * speed);
    }
}
