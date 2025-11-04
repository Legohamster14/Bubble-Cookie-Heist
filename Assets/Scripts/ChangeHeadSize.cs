using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeadSize : MonoBehaviour
{
    //animator for the head
    public Animator HeadAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Makes sure that the other collider isnt a trigger
        if (other.isTrigger == false)
        {
            //Makes the head deflate
            HeadAnimator.SetBool("IsOnGround", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Makes sure that the other collider isnt a trigger
        if (other.isTrigger == false)
        {
            //Makes the head deflate
            HeadAnimator.SetBool("IsOnGround", false);
        }
    }
}
