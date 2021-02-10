using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from https://answers.unity.com/questions/1297374/change-a-variable-in-a-different-object.html
// https://forum.unity.com/threads/how-i-can-access-objects-hinge-joint-and-change-its-value-with-c.1015696/
// https://docs.unity3d.com/ScriptReference/HingeJoint-spring.html

public class ChangeSpring : MonoBehaviour
{
    public float springVal = 0;
    public float tarPos = 0;
    public bool springBool = false;
    
    // Start is called before the first frame update
    void Start()
    {
        updateSpringValues();
    }

    // Update is called once per frame
    void Update()
    {
        updateSpringValues();
    }

    void updateSpringValues()
    {
        GameObject getDoor = GameObject.FindWithTag("Door");
        
        HingeJoint hinge = getDoor.GetComponent<HingeJoint>();

        JointSpring hingeSpring = hinge.spring;

        hingeSpring.spring = springVal;
        hingeSpring.targetPosition = tarPos;
        hinge.spring = hingeSpring;
        
        
        hingeSpring.targetPosition = tarPos;
        hinge.useSpring = springBool;
    }
    
}
