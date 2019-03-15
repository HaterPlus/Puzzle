using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

      public static int remainingPieces ;

    void Start () {
        
    }
	
	
	void Update () {

        ObjectControl.timeBonus -= Time.deltaTime;

        if(remainingPieces == 0)
        {
            SceneManager.LoadScene("levelcomplete");
        }

        if(ObjectControl.timer <= 0)
        {
            SceneManager.LoadScene("levellose");
        }

        if(ObjectControl.totalScore <= -100)
        {
            SceneManager.LoadScene("levellose");
        }
	}
}
