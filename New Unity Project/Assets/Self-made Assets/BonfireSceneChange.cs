using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonfireSceneChange : MonoBehaviour
{
	[SerializeField] private string sceneName;
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
		    if (Input.GetKeyUp(KeyCode.F))
		    {
			    SceneManager.LoadScene(sceneName);
			    
		    }
	    }
    }
}
