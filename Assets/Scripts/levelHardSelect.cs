using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelHardSelect : MonoBehaviour {


    public static int whichlevelH;
	void Start () {
		
	}
	
	void Update () {

    }

    void OnMouseDown()
    {

        if (gameObject.name == "hard1")
        {
            whichlevelH = 1;
            SceneManager.LoadScene("hard");
        }

        if (gameObject.name == "hard2")
        {
            whichlevelH = 2;
            SceneManager.LoadScene("hard");

        }

        if (gameObject.name == "hard3")
        {
            whichlevelH = 3;
            SceneManager.LoadScene("hard");

        }

        if (gameObject.name == "hard4")
        {
            whichlevelH = 4;
            SceneManager.LoadScene("hard");

        }

        if (gameObject.name == "hard5")
        {
            whichlevelH = 5;
            SceneManager.LoadScene("hard");

        }

    }
}
