using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpStool : MonoBehaviour
{
    //Variable for whether the player can pick up the stool
    private bool CanPickUpStool;
    //Variable for the stool game object
    public GameObject Stool;
    //var for text object
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        //makes the text invisible at the start
        Text.SetActive(false);
        //this gets rid of the stool is the player has already picked it up
        if (PlayerMovement.PickedUpStool)
        {
            GameObject.Destroy(Stool);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //makes sure the player is inside the trigger
        if (CanPickUpStool == true)
        {
            //Plays when e is press
            if (Input.GetKeyUp(KeyCode.E))
            {
                //destroys the stool in the scene
                GameObject.Destroy(Stool);
                //this will let the player put down the stool in another place
                PlayerMovement.PickedUpStool = true;
                //gets rid of the text when the player pick up the stool
                Text.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!other.isTrigger)
        {
            CanPickUpStool = true;
            //turns on the text when the player enters the trigger
            Text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.isTrigger)
        {
            CanPickUpStool = false;
            //turns off the text when the player exits the trigger
            Text.SetActive(false);
        }
    }
}
