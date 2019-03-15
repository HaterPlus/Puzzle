using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingOrder = 15;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ObjectControl.timeBonus <= 0)
        {
            ObjectControl.timeBonus = 0;
        }
          
        GetComponent<TextMesh>().text = "Счет :" +  Mathf.RoundToInt(ObjectControl.totalScore + ObjectControl.timeBonus).ToString();
      

	}
}
