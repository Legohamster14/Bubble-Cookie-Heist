using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private bool IsInTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // if the player enters the trigger it will change the scene to the end game scene
    private void OnTriggerEnter(Collider other)
    {
        if (!other.isTrigger)
        {
            SceneManager.LoadScene(9);
        }
    }
}
