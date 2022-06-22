using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandleListNode : MonoBehaviour
{
    // Start is called before the first frame update

    public bool hasNext;

    void Start()
    {
        hasNext = false;   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (!hasNext && other.gameObject.GetComponent<ColliderHandle>() != null)
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.transform.localPosition = new Vector3(0, 0, -0.0836f);
            other.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            other.gameObject.transform.Find("Grabbable").Find("Connection").gameObject.SetActive(true);
            Destroy(other.gameObject.GetComponent<XRGrabInteractable>());
            Destroy(other.gameObject.GetComponent<Rigidbody>());
            hasNext = true;
        }
    }
}
