using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableText : MonoBehaviour
{
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //enables the text when the player enters the trigger
        if (!other.isTrigger)
        {
            Text.SetActive(true);
        }
    }
}
