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
    [SerializeField] private PanelController panelController;

    public InputActionAsset inputActionsAsset;

    private InputAction actionX;

    [SerializeField] private InputActionReference m_BackAction;

    void Awake()
    {
        actionX = m_BackAction.action;
    }

    void OnEnable()
    {
        if (actionX != null)
        {
            actionX.performed += OnXPressed;
            actionX.Enable();
        }
    }

    void OnDisable()
    {
        if (actionX != null)
        {
            actionX.performed -= OnXPressed;

            actionX.Disable();
            actionX.Dispose();
        }
    }

    private void OnXPressed(InputAction.CallbackContext context)
    {
        if (panelController.currentPanel == panelController.Panels[1])
        {
            panelController.switchPanel(panelController.Panels[0]);
        }

        if (panelController.currentPanel == panelController.Panels[0])
        {
            return;
        }
    }
}
