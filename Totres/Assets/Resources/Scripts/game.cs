using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class game : MonoBehaviour
{

    public static int gridHeight = 10;
    public static int gridWidth = 20;
    //public GameObject tetty;

	// Use this for initialization
	void Start () {
		SpawnNextPiece();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnNextPiece()
    {
        GameObject nextPiece = (GameObject) Instantiate(Resources.Load(GetRandomPiece(), typeof(GameObject)),
            new Vector2(-1.0f, 7.0f), Quaternion.identity);
    }

    public bool CheckIsInsideGrid(Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.y < gridWidth && (int)pos.y >= 0);
    }

    public Vector2 Round(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    bool CheckIsValidPosition()
    {
        foreach (Transform mino in transform)
        {
            Vector2 pos = FindObjectOfType<game>().Round(mino.position);

            if (FindObjectOfType<game>().CheckIsInsideGrid(pos) == false)
            {
                Debug.Log("bad place");
                return false;
            }
        }

        return true;
    }

    string GetRandomPiece()
    {
        int randomPiece = Random.Range(1, 8);
        string randomPieceName = "Prefab/Pieces/T_Piece";
        switch (randomPiece)
        {
            case 1:
                randomPieceName = "Prefab/Pieces/T_Piece";
                break;
            case 2:
                randomPieceName = "Prefab/Pieces/J_Piece";
                break;
            case 3:
                randomPieceName = "Prefab/Pieces/L_Piece";
                break;
            case 4:
                randomPieceName = "Prefab/Pieces/S_Piece";
                break;
            case 5:
                randomPieceName = "Prefab/Pieces/Z_Piece";
                break;
            case 6:
                randomPieceName = "Prefab/Pieces/Square_Piece";
                break;
            case 7:
                randomPieceName = "Prefab/Pieces/Long_Piece";
                break;

        }

        return randomPieceName;
    }
}
