using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateAlphabet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject charactherPrototype;
    public Transform parent;

    void Start()
    {
        GameObject copy = GameObject.Instantiate(charactherPrototype);
        for(int i = 0; i < 26; i++)
        {
            Component[] charTexts;

            charTexts = copy.GetComponentsInChildren(typeof(TextMeshPro));
            foreach(TextMeshPro textMesh in charTexts)
            {
                textMesh.text = (char)(i + (int)'A') + "";
            }
            if (i < 10) {
                GameObject tf = Object.Instantiate(copy, new Vector3(-0.836f, 0.819f, -0.424f + i * (0.05f)), Quaternion.identity, parent);
                tf.SetActive(true);
            }
            else if(i < 20) {
                GameObject tf = Object.Instantiate(copy, new Vector3(-0.736f, 0.819f, -0.424f + (i - 10) * (0.05f)), Quaternion.identity, parent);
                tf.SetActive(true);

            }
            else {
                GameObject tf = Object.Instantiate(copy, new Vector3(-0.636f, 0.819f, -0.424f + (i - 20) * (0.05f)), Quaternion.identity, parent);
                tf.SetActive(true);

            }
        }
        copy.SetActive(false);

    }

    void OnGrabbed()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
