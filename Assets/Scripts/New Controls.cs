//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/New Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @NewControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""MouseInput"",
            ""id"": ""eaa702b1-69d2-4c4f-8dd2-35cb2c7e8838"",
            ""actions"": [
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8170be72-d740-4775-ba0e-5f49f7eb7404"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e719a24a-f4d8-48c1-ad49-e7c3905b8304"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseWheelUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a4c083bd-f5e3-4b9a-8633-18254d69073b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseWheelDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1c5fd011-baa9-4568-a66f-9a65f5deea81"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21825246-6ec6-42e4-8a82-15608daebbe9"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39b219f0-cb02-4c1b-ad03-115d3d4281de"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Inputs"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""973d44ed-573a-42a5-a991-0afe0b28b51e"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Inputs"",
                    ""action"": ""MouseWheelUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17855f03-e6c4-441e-97f3-f27296441519"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Inputs"",
                    ""action"": ""MouseWheelDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Inputs"",
            ""bindingGroup"": ""Inputs"",
            ""devices"": [
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MouseInput
        m_MouseInput = asset.FindActionMap("MouseInput", throwIfNotFound: true);
        m_MouseInput_MouseX = m_MouseInput.FindAction("MouseX", throwIfNotFound: true);
        m_MouseInput_MouseY = m_MouseInput.FindAction("MouseY", throwIfNotFound: true);
        m_MouseInput_MouseWheelUp = m_MouseInput.FindAction("MouseWheelUp", throwIfNotFound: true);
        m_MouseInput_MouseWheelDown = m_MouseInput.FindAction("MouseWheelDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MouseInput
    private readonly InputActionMap m_MouseInput;
    private List<IMouseInputActions> m_MouseInputActionsCallbackInterfaces = new List<IMouseInputActions>();
    private readonly InputAction m_MouseInput_MouseX;
    private readonly InputAction m_MouseInput_MouseY;
    private readonly InputAction m_MouseInput_MouseWheelUp;
    private readonly InputAction m_MouseInput_MouseWheelDown;
    public struct MouseInputActions
    {
        private @NewControls m_Wrapper;
        public MouseInputActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX => m_Wrapper.m_MouseInput_MouseX;
        public InputAction @MouseY => m_Wrapper.m_MouseInput_MouseY;
        public InputAction @MouseWheelUp => m_Wrapper.m_MouseInput_MouseWheelUp;
        public InputAction @MouseWheelDown => m_Wrapper.m_MouseInput_MouseWheelDown;
        public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
        public void AddCallbacks(IMouseInputActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseInputActionsCallbackInterfaces.Add(instance);
            @MouseX.started += instance.OnMouseX;
            @MouseX.performed += instance.OnMouseX;
            @MouseX.canceled += instance.OnMouseX;
            @MouseY.started += instance.OnMouseY;
            @MouseY.performed += instance.OnMouseY;
            @MouseY.canceled += instance.OnMouseY;
            @MouseWheelUp.started += instance.OnMouseWheelUp;
            @MouseWheelUp.performed += instance.OnMouseWheelUp;
            @MouseWheelUp.canceled += instance.OnMouseWheelUp;
            @MouseWheelDown.started += instance.OnMouseWheelDown;
            @MouseWheelDown.performed += instance.OnMouseWheelDown;
            @MouseWheelDown.canceled += instance.OnMouseWheelDown;
        }

        private void UnregisterCallbacks(IMouseInputActions instance)
        {
            @MouseX.started -= instance.OnMouseX;
            @MouseX.performed -= instance.OnMouseX;
            @MouseX.canceled -= instance.OnMouseX;
            @MouseY.started -= instance.OnMouseY;
            @MouseY.performed -= instance.OnMouseY;
            @MouseY.canceled -= instance.OnMouseY;
            @MouseWheelUp.started -= instance.OnMouseWheelUp;
            @MouseWheelUp.performed -= instance.OnMouseWheelUp;
            @MouseWheelUp.canceled -= instance.OnMouseWheelUp;
            @MouseWheelDown.started -= instance.OnMouseWheelDown;
            @MouseWheelDown.performed -= instance.OnMouseWheelDown;
            @MouseWheelDown.canceled -= instance.OnMouseWheelDown;
        }

        public void RemoveCallbacks(IMouseInputActions instance)
        {
            if (m_Wrapper.m_MouseInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseInputActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseInputActions @MouseInput => new MouseInputActions(this);
    private int m_InputsSchemeIndex = -1;
    public InputControlScheme InputsScheme
    {
        get
        {
            if (m_InputsSchemeIndex == -1) m_InputsSchemeIndex = asset.FindControlSchemeIndex("Inputs");
            return asset.controlSchemes[m_InputsSchemeIndex];
        }
    }
    public interface IMouseInputActions
    {
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMouseWheelUp(InputAction.CallbackContext context);
        void OnMouseWheelDown(InputAction.CallbackContext context);
    }
}
