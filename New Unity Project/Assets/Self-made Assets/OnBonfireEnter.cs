using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBonfireEnter : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var raycaster = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
        if (Physics.Raycast(raycaster, out hit))
        {
            if (Input.GetKeyUp(KeyCode.E))
        { 
            GameObject coiledSword = GameObject.FindWithTag("coiledSword");
            Vector3 newPosition = new Vector3(-43.8f, 40.76f, -40.6f);
            if (coiledSword != null) {
	            coiledSword.transform.position = newPosition;
	            coiledSword.GetComponent<Rigidbody>().useGravity = true;
            }
        }
        }
    }

        
 
    
//    private void OnTriggerEnter(Collider other)
//    {
//        GameObject coiledSword = GameObject.FindWithTag("coiledSword");
//        Vector3 newPosition = new Vector3(-43.8f, 40.76f, -40.6f);
//        coiledSword.transform.position = newPosition;
//        coiledSword.GetComponent<Rigidbody>().useGravity = true;
//
//    }
    
    
}
