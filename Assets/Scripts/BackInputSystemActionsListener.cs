using System;
using System.Linq;
using PanelManagment;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;

public class BackInputSystemActionsListener : MonoBehaviour
{
    private PanelController panelController;

    public InputActionAsset inputActionsAsset;
    
    private InputAction actionX;

    private int index;

    [SerializeField] private InputActionReference m_BackAction;
    void Start()
    {
        actionX = m_BackAction.action;
    }

    void OnEnable()
    {
        actionX.performed += OnXPressed;
        actionX.Enable();
    }

    void OnDisable()
    {
        actionX.performed -= OnXPressed;

        actionX.Disable();
    }

    private void OnXPressed(InputAction.CallbackContext context)
    {
        if (panelController.currentPanel == panelController.Panels[0])
            return;
        else if (panelController.currentPanel == panelController.Panels[1])
            panelController.switchPanel(panelController.Panels[0]);
        print("Voltando");
    }
}
