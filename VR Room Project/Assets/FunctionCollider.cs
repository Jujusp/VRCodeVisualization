using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isAdd;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Integer>() != null)
        {
            if (isAdd)
            {
                other.gameObject.GetComponent<Integer>().AddOneToNumber();
            }
            else
            {
                other.gameObject.GetComponent<Integer>().SubstractOneToNumber();

            }
        }
    }
}
