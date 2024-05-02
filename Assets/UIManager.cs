using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform panel;

    [SerializeField] private InputActionAsset playerInput;
    private InputAction menuInputAction;

    private void Awake()
    {
        menuInputAction = playerInput.FindAction("Menu");
        menuInputAction.performed += DisplayMenu;
    }

    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        menuInputAction.Enable();
    }

    private void OnDisable()
    {
        menuInputAction.Disable();
    }

    private void DisplayMenu(InputAction.CallbackContext context)
    {
        panel.gameObject.SetActive(!panel.gameObject.activeSelf);
    }
}
