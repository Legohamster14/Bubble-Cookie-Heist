using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour
{
    //ID of the scene I want it to change to
    public int SceneID;

    //Variable for whether the door is open
    public bool IsDoorOpen = false;

    // animator for the door
    public Animator DoorAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes sure the door is Open
        if (DoorAnimator.GetBool("OpenedHandle") == true)
        {
            IsDoorOpen = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Changes scene if door is open
        if (IsDoorOpen == true)
        {
            SceneManager.LoadScene(SceneID);
        }
    }
}
