using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    private Transform tf;

    private float fall = 0;
    public float fallSpeed = 1;

    public float speed;
	// Use this for initialization
	void Start ()
	{
	    tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tf.position = tf.position + Vector3.left;

            if (checkIsValidPosition())
            {

            }
            else
            {
                tf.position = tf.position + Vector3.right;
            }
        }


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            tf.position = tf.position + Vector3.right;
            if (checkIsValidPosition())
            {

            }
            else
            {
                tf.position = tf.position + Vector3.left;
            }
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fallSpeed)
        {
            tf.position = tf.position + Vector3.down;

            fall = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            tf.Rotate(0, 0, 90);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            tf.Rotate(0, 0, -90);
        }
    }

    bool checkIsValidPosition()
    {
        foreach (Transform mino in transform)
        {
            Vector2 pos = FindObjectOfType<game>().Round(mino.position);

            if (FindObjectOfType<game>().CheckIsInsideGrid (pos) == false)
            {
                return false;
            }
        }

        return true;
    }
}
