using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canCopy;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGrabbed()
    {
        if (canCopy)
        {
            Integer gb = Object.Instantiate(this);
            Rigidbody rb = gb.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            gb.canCopy = true;
            canCopy = false;

        }
    }

    public void UpdateValue(int value)
    {
        foreach(Transform child in gameObject.transform)
        {
            TMPro.TextMeshPro tp = child.GetComponent<TMPro.TextMeshPro>();
            tp.text = "" + (int.Parse(tp.text ) + value);
            
        }
    }

    public void AddOneToNumber()
    {
        UpdateValue(1);
    }
    public void SubstractOneToNumber()
    {
        UpdateValue(-1);
    }

    public void OnActivated()
    {
        Debug.Log("Pressed A honey");
    }
}
