using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSimpleSelect : MonoBehaviour
{

    public static int whichlevelS;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {



        if (gameObject.name == "simple1")
        {
            whichlevelS = 1;

            SceneManager.LoadScene("simple");

        }
        if (gameObject.name == "simple2")
        {
            whichlevelS = 2;

            SceneManager.LoadScene("simple");

        }
        if (gameObject.name == "simple3")
        {
            whichlevelS = 3;

            SceneManager.LoadScene("simple");
        }
        if (gameObject.name == "simple4")
        {
            whichlevelS = 4;

            SceneManager.LoadScene("simple");
        }
        if (gameObject.name == "simple5")
        {
            whichlevelS = 5;

            SceneManager.LoadScene("simple");
        }



    }
}
