using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from https://answers.unity.com/questions/1297374/change-a-variable-in-a-different-object.html

public class OpenDoor : MonoBehaviour
{
    private GameObject getDoor;

    private ChangeSpring springScript;
    // Start is called before the first frame update
    void Start()
    {
        getDoor = GameObject.FindWithTag("Door");

        springScript = getDoor.GetComponent<ChangeSpring>();

 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        springScript.springVal = 50f;
        springScript.tarPos = -90f;
        springScript.springBool = true;

    }

    private void OnTriggerExit(Collider other)
    {
        GameObject getTrigger;
        getTrigger = GameObject.FindWithTag("DoorTrigger");
        Destroy(getTrigger);
    }
    
}
