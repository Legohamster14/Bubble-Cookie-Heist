using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLivingRoom : MonoBehaviour
{
    //var for if the player is in the trigger
    private bool IsInTrigger;

    //var for the text game object
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        //disables the text at the start
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //loads the scene when the player presses e and is in the trigger box
        if (IsInTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(7);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //enables the text when the player enters the trigger
        if (!other.isTrigger)
        {
            IsInTrigger = true;
            Text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //disables the text when the player leaves the trigger
        if (!other.isTrigger)
        {
            IsInTrigger = false;
            Text.SetActive(false);
        }
    }
}
