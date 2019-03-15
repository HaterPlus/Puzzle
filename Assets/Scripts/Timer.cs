using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ObjectControl.timer <= 0)
        {
            ObjectControl.timer = 0;
        }

        GetComponent<TextMesh>().text = "Таймер :" + Mathf.RoundToInt(ObjectControl.timer).ToString();
    }
}
