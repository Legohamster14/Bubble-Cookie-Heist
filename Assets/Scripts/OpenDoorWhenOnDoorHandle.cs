using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWhenOnDoorHandle : MonoBehaviour
{
    //var of the door's animtor
    public Animator DoorAnimator;
    //var for the door game object
    public GameObject Door;

    //var for whether the door should be open as soon as the level loads
    public bool IsOpenByDefault;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // makes the the door open by default
        if (IsOpenByDefault == true)
        {
            DoorAnimator.SetBool("OpenByDefault", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Triggers the animation to open the door
        DoorAnimator.SetBool("OpenedHandle", true);
        //Gets rid of the collider so it doesnt move the player around when opening
        Door.GetComponent<BoxCollider>().enabled = false;
        //Gets rid of the doorhandle's collider
        gameObject.GetComponent<BoxCollider>().enabled =  false;
    }
}
