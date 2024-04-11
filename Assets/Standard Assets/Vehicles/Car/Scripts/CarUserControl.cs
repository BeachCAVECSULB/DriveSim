using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        [SerializeField] private InputActionAsset playerInput;
        private InputActionMap playerInputMap;
        [SerializeField] private PlayerInput input;
        private InputAction accelerateInputAction;
        private InputAction footbrakeInputAction;
        private InputAction steeringInputAction;

        private float acceleration, footbrake, angle;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();

            //playerInputMap = playerInput.FindActionMap("Player");
            accelerateInputAction = playerInput.FindAction("Acceleration");
            footbrakeInputAction = playerInput.FindAction("Footbrake");
            steeringInputAction = playerInput.FindAction("SteeringAngle");

            accelerateInputAction.performed += GetAccelerateInput;
            accelerateInputAction.canceled += GetAccelerateInput;

            footbrakeInputAction.performed += GetFootbrakeInput;
            footbrakeInputAction.canceled += GetFootbrakeInput;

            steeringInputAction.performed += GetSteeringAngleInput;
            steeringInputAction.canceled += GetSteeringAngleInput;
        }

        private void GetAccelerateInput(InputAction.CallbackContext context)
        {
            acceleration = context.ReadValue<float>();
        }

        private void GetFootbrakeInput(InputAction.CallbackContext context)
        {
            footbrake = context.ReadValue<float>();
        }

        private void GetSteeringAngleInput(InputAction.CallbackContext context)
        {
            angle = context.ReadValue<float>();
        }

        private void OnEnable()
        {
            accelerateInputAction.Enable();
            footbrakeInputAction.Enable();
            steeringInputAction.Enable();
        }

        private void OnDisable()
        {
            accelerateInputAction.Disable();
            footbrakeInputAction.Disable();
            steeringInputAction.Disable();
        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            //m_Car.Move(h, v, v, handbrake); // original

            bool isUsingKeyboard = input.currentControlScheme == "Keyboard&Mouse";

            m_Car.Move(angle, acceleration, footbrake, 0f, isUsingKeyboard);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
