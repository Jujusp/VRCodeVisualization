using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuWristScript : MonoBehaviour
{

    public GameObject wristUI;

    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        DisplayWristUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisplayWristUI()
    {
        wristUI.SetActive(!gameObject.activeSelf);

    }

    public void MenuPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
            DisplayWristUI();
    }

    public void OnClickAddObject()
    {
        Object.Instantiate(objectToClone, new Vector3(-0.075f, 1.5f, 0.82f), Quaternion.identity);
    }
}
