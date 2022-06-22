using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageData : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> objetosMutables;
    public List<GameObject> objetosInmutables;

    public GameObject copyInteger;
    public GameObject copyCharacther;
    public GameObject copyListNode;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickAddObject()
    {
        GameObject gb = Object.Instantiate(copyListNode, new Vector3(-0.075f, 0.8f, 0.82f), Quaternion.identity);
         gb.SetActive(true);
         objetosMutables.Add(gb);
    }
}
