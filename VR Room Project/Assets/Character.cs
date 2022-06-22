using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update

    bool canCopy;
    void Start()
    {
        canCopy = true;   
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onGrabbed()
    {
        if (canCopy)
        {
            Object.Instantiate(this);
            canCopy = false;
        }
    }
    
  



}
