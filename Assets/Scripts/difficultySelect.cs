using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class difficultySelect : MonoBehaviour {

    public static int difficulty;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (gameObject.name == "Simple")
        {
            difficulty = 1;
            SceneManager.LoadScene("SimpleChoose");
            GameMaster.remainingPieces = 9;
        }

        if (gameObject.name == "Medium")
        {
            difficulty = 2;

            SceneManager.LoadScene("MediumChoose");

            GameMaster.remainingPieces = 16;
        }

        if (gameObject.name == "Hard")
        {
            difficulty = 3;
            SceneManager.LoadScene("HardChoose");
            GameMaster.remainingPieces = 25;
        }
    }
}
