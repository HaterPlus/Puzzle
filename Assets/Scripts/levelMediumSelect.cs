using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelMediumSelect : MonoBehaviour {

    public static int whichlevelM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {

        if (gameObject.name == "medium1")
        {
            whichlevelM = 1;
            SceneManager.LoadScene("medium");
        }

        if (gameObject.name == "medium2")
        {
            whichlevelM = 2;
            SceneManager.LoadScene("medium");

        }

        if (gameObject.name == "medium3")
        {
            whichlevelM = 3;
            SceneManager.LoadScene("medium");

        }

        if (gameObject.name == "medium4")
        {
            whichlevelM = 4;
            SceneManager.LoadScene("medium");

        }

        if (gameObject.name == "medium5")
        {
            whichlevelM = 5;
            SceneManager.LoadScene("medium");

        }

    }
}
