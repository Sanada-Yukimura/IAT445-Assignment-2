using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Message : MonoBehaviour
{
    public Text messageTextFlame;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    try
	    {
		    Vector3 messagePos = Camera.main.WorldToScreenPoint(this.transform.position);
		    messageTextFlame.transform.position = messagePos;
	    }
	    catch (System.Exception e)
	    {
		    
	    }
		}
}
