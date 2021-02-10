using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonfireBaseRemoval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider tar)
    {
        if (tar.GetComponent<Collider>().tag == "bonfireBase")
        {
            Debug.Log("collide");
            GameObject bonfireBase;
            bonfireBase = GameObject.FindWithTag("bonfireBase");
            Destroy(bonfireBase);
            GameObject coiledSwordModel = GameObject.FindWithTag("coiledSword");
            Destroy(coiledSwordModel);
			GameObject messageText = GameObject.FindWithTag("sphereMessage");
            GameObject message = GameObject.FindWithTag("messageText");
            Destroy(messageText);
            Destroy(message);
            
            GameObject bonfire = GameObject.FindWithTag("bonfire");
            Vector3 newPosition = new Vector3(-43.55f, 24.91f, -42.49f);
            bonfire.transform.position = newPosition;
            GameObject particleFlame = GameObject.FindWithTag("flame");
            Vector3 newFlamePos = new Vector3(-43.48f, 25.98f, -42.74f);
            particleFlame.transform.position = newFlamePos;
            Vector3 newFlameSize = new Vector3(0.9136802f, 0.8442293f, 0.196837f);
            particleFlame.transform.localScale = newFlameSize;
            
            GameObject sphereMessageTwo = GameObject.FindWithTag("secondSphereMessage");
			Vector3 newSpherePos = new Vector3(-43.41f, 32f, -42.57f);
			sphereMessageTwo.transform.position = newSpherePos;

			
			


			
            


        }
    }
}
