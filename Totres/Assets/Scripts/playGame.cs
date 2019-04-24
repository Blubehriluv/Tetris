using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playGame : MonoBehaviour {

    // Use this for initialization
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene("SampleScene");
    }

}
