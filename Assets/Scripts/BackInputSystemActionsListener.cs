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

    // private InputAction testAction;

    [SerializeField] private InputActionReference m_BackAction;
    void Awake()
    {
        actionX = m_BackAction.action;
    }

    void OnEnable()
    {
        if (actionX != null)
        {
            // Debug.Log($"Registrando action: {m_BackAction.action?.name ?? "NULA"}");
            actionX.performed += OnXPressed;
            actionX.Enable();
        }

        // testAction = new InputAction("TestX", binding: "<Keyboard>/x");
        // testAction.performed += OnXPressed;
        // testAction.Enable();

        // if (m_BackAction == null || m_BackAction.action == null)
        // {
        //     Debug.LogError("Ação não está atribuída corretamente.");
        //     return;
        // }

        // if (!m_BackAction.action.enabled || m_BackAction.asset.enabled)
        // {
        //     m_BackAction.action.Enable();
        //     Debug.Log("Habilitei a ação manualmente.");
        // }

        // m_BackAction.action.performed += OnXPressed;
    }

    void OnDisable()
    {
        if (actionX != null)
        {
            actionX.performed -= OnXPressed;

            actionX.Disable();
            actionX.Dispose();
        }

        // testAction.Disable();
        // testAction.Dispose();

        // if (m_BackAction?.action != null)
        // {
        //     m_BackAction.action.performed -= OnXPressed;
        //     m_BackAction.action.Disable();
        // }
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
