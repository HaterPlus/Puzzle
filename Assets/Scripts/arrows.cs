using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

    public static float invAr = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(gameObject.name == "arrowUp")
        {
            invAr -= 1.44f;
        }

        if(gameObject.name == "arrowDown")
        {
            invAr += 1.44f;
        }
    }

}
