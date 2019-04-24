using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFall : MonoBehaviour
{

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            transform.Translate(0, -1, 0);
        }
    }
}