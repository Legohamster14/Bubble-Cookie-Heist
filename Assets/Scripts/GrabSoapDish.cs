using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSoapDish : MonoBehaviour
{
    //var for whether the player can pick up the soap dish
    private bool AbleToPickup;
    //var for the soapdish game object
    public GameObject SoapDish;
    //var for the player
    public GameObject Player;
    //var for the text game object
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        //turns off the text at the start
        Text.SetActive(false);

        //if the player has already picked up the soap dish this stops it from coming back when the player leaves and re-enters the room
        if (PlayerMovement.PickedUpSoapDish)
        {
            GameObject.Destroy(SoapDish);
            Text.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (AbleToPickup)
        {
            //this gets rid of the soap dish and text when you press e
            //it also lets the player script know that you have picked it up
            if (Input.GetKeyUp(KeyCode.E))
            {
                GameObject.Destroy(SoapDish);
                PlayerMovement.PickedUpSoapDish = true;
                Text.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.isTrigger)
        {
            AbleToPickup = true;
            //enables the text when the player enters the trigger
            Text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.isTrigger)
        {
            AbleToPickup = false;
            //disables the text when the player leaves the trigger
            Text.SetActive(false);
        }
    }
}
