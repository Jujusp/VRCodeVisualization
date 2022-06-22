using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColliderHandle : MonoBehaviour
{
    // Start is called before the first frame update

    public bool hasAttachedObject;
    void Start()
    {
        hasAttachedObject = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( !hasAttachedObject && other.gameObject.GetComponent<CanBeAttached>() != null)
        {/**
            other.gameObject.AddComponent<FixedJoint>();
            other.gameObject.GetComponent<FixedJoint>().connectedBody = gameObject.GetComponent<Rigidbody>();
            Debug.Log("Successfully attached element to listNode");
            **/
            hasAttachedObject = true;
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.transform.localPosition = new Vector3(0, 0.010f);
            other.gameObject.transform.rotation = new Quaternion(0, 90, 0, 0);
            Destroy(other.gameObject.GetComponent<XRGrabInteractable>());
            Destroy(other.gameObject.GetComponent<Rigidbody>());
            other.attachedRigidbody.isKinematic = false;

        }
    }   

}
