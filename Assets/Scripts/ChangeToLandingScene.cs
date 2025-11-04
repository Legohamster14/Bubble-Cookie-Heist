using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToLandingScene : MonoBehaviour
{
    //ID of the scene I want it to change to
    public int SceneID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //changes scene once 5 seconds has passeds
        if (Time.timeSinceLevelLoad >= 5)
        {
            SceneManager.LoadScene(SceneID);
        }
    }
}
