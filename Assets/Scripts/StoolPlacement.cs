using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoolPlacement : MonoBehaviour
{
    //var for whether the player is in the trigger
    private bool IsInTrigger;
    //var for the stool game object
    public GameObject Stool;
    //var for the text game object
    public GameObject Text;

    // var for the position the stool with be set too
    private Vector3 Offset = new Vector3(0, -0.2f, 0);

    // Start is called before the first frame update
    void Start()
    {
        //disables the text on start
        Text.SetActive(false);

        //if the stool has been placed it will stay there even if the player leaves and re-enters the room
        if (PlayerMovement.PlacedStool)
        {
            Stool.transform.position = transform.position + Offset;
            Text.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInTrigger == true)
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                //makes sure the player has picked up the stool
                if (PlayerMovement.PickedUpStool == true)
                {
                    Stool.transform.position = transform.position + Offset;
                    //disables the text object when the player picks up the stool
                    Text.SetActive(false);
                    PlayerMovement.PlacedStool = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.isTrigger)
        {
            IsInTrigger = true;
            //only enbles the text when the player has pick up the stool
            if (PlayerMovement.PickedUpStool)
            {
                Text.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.isTrigger)
        {
            IsInTrigger = false;
            //turns off the text when the player leaves the trigger
            Text.SetActive(false);
        }
    }
}
