using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() != null)
        {
            // create a joint
            HingeJoint joint = gameObject.AddComponent<HingeJoint>();

            //Set the anchor point where the wand and blade collide
           

            //Set the forces which will break the joint.
            joint.breakForce = 20;
            joint.breakTorque = 100;

            // Stops objects from continuing to collide and creating more joints
            joint.enableCollision = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
