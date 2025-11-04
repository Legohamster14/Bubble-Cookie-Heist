using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStairSlideAnim : MonoBehaviour
{
    //var for whether the player is in the trigger
    private bool InsideTrigger;
    //var for the text game object
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        //makes sure the text isnt visible at the start
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //checks to whether the player is inside the trigger
        if (InsideTrigger == true)
        {
            //plays enter code when e is press
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Makes sure the player has picked up the soap dish
                if (PlayerMovement.PickedUpSoapDish == true)
                {
                    SceneManager.LoadScene(5);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.isTrigger)
        {
            InsideTrigger = true;
            //makes the text visible when the player enters the trigger
            Text.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.isTrigger)
        {
            InsideTrigger = false;
            //makes the text invisible when the player exits the trigger
            Text.SetActive(false);
        }
    }
}
