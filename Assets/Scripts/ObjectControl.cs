using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour {

    public string pieceStatus = "Idle";

    public Transform edgeParticles;

    public KeyCode placePiece;
    public KeyCode returntoInv;

    public string checkPlacement = "";

    public float yDiff = 0;
    public Vector2 invPos;

    public float newYpos;
    public float newXpos;

    public Sprite stage2Image;
    public Sprite stage3Image;
    public Sprite stage4Image;
    public Sprite stage5Image;

    public static int totalScore;
    public static float timeBonus = 0;
    public static float timer = 600;

    private void Start()
    {
        if (levelSimpleSelect.whichlevelS == 2)
        {
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        }
        if (levelSimpleSelect.whichlevelS == 3)
        {
            GetComponent<SpriteRenderer>().sprite = stage3Image;
        }
        if (levelSimpleSelect.whichlevelS == 4)
        {
            GetComponent<SpriteRenderer>().sprite = stage4Image;
        }
        if (levelSimpleSelect.whichlevelS == 5)
        {
            GetComponent<SpriteRenderer>().sprite = stage5Image;
        }

        if (levelHardSelect.whichlevelH == 2)
        {
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        }
        if (levelHardSelect.whichlevelH == 3)
        {
            GetComponent<SpriteRenderer>().sprite = stage3Image;
        }
        if (levelHardSelect.whichlevelH == 4)
        {
            GetComponent<SpriteRenderer>().sprite = stage4Image;
        }
        if (levelHardSelect.whichlevelH == 5)
        {
            GetComponent<SpriteRenderer>().sprite = stage5Image;
        }


        if (levelMediumSelect.whichlevelM == 2)
        {
            GetComponent<SpriteRenderer>().sprite = stage2Image;
        }
        if (levelMediumSelect.whichlevelM == 3)
        {
            GetComponent<SpriteRenderer>().sprite = stage3Image;
        }
        if (levelMediumSelect.whichlevelM == 4)
        {
            GetComponent<SpriteRenderer>().sprite = stage4Image;
        }
        if (levelMediumSelect.whichlevelM == 5)
        {
            GetComponent<SpriteRenderer>().sprite = stage5Image;
        }


    }

    private void Update()
    {
        timeBonus -= Time.deltaTime / 30;
        timer -= Time.deltaTime / 30;

        returnp();

        if (pieceStatus == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if((Input.GetKeyDown(placePiece)) && (pieceStatus == "pickedup"))
        {

            checkPlacement = "y";

        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y")) 
        {
            other.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Renderer>().sortingOrder = 0;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "Locked";
            Instantiate(edgeParticles, other.gameObject.transform.position, edgeParticles.rotation);
            checkPlacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            totalScore += 10;
            GameMaster.remainingPieces -= 1;
        }

        if ((other.gameObject.name != gameObject.name) && (checkPlacement == "y"))
        {
            totalScore -= 5;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
            checkPlacement = "n";
           
        }
    }
    private void OnMouseDown()
    {
        pieceStatus = "pickedup";
        checkPlacement = "n";
        GetComponent<Renderer>().sortingOrder = 10;
        invPos = transform.position;
    }

   
       
    void returnp() {
        if ((Input.GetKeyDown(returntoInv)) && (pieceStatus == "pickedup"))
        {
            transform.position = new Vector2(newXpos, newYpos);
            pieceStatus = "";
            
        }
}

       

    }


