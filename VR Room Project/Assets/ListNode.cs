using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListNode : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canCopy;

    void Start()
    {
        
    }

    public void OnGrabbed()
    {
        if (canCopy)
        {
            ListNode gb = Object.Instantiate(this, new Vector3(0.663999975f, 1.5f, -0.168599963f), Quaternion.identity);
            Rigidbody rb = gb.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            gb.canCopy = true;
            canCopy = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
