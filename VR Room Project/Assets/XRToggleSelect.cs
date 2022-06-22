using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRToggleSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionReference toggleReference = null;
    private MeshRenderer meshRenderer;
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        toggleReference.action.started += Toggle;
    }

    // Update is called once per frame
    void OnDestroy()
    {
        toggleReference.action.started -= Toggle;

    }

    private void Toggle(InputAction.CallbackContext context)
    {
        meshRenderer.material.color = Color.green;
    }
}
