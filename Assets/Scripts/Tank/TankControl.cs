//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/TankControl.inputactions
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

namespace Tanks
{
    public partial class @TankControl: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TankControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankControl"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""9b42a979-cca3-4636-8776-e4f0f1bee9c8"",
            ""actions"": [
                {
                    ""name"": ""Handbreak"",
                    ""type"": ""Button"",
                    ""id"": ""903a2f51-02fe-4be8-8de0-7bfb8445fb8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""97be836c-3177-41ff-976a-034982545a05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56270405-03f1-417a-8ec6-3f5189067e42"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b08cabd1-d53c-4f46-ac8b-0bf203e93eed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c512fa55-f8e3-462d-8d7b-812e1d5cfad7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""abb55437-af85-457e-b597-16ea962abf3f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8377b3e-c8c0-4cc9-b3bd-5a3c28e63014"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3ee11c1b-2cc7-4b24-a28b-fd194a61d0f6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""2ab70bd8-bbc2-4ae5-9a5d-ae90a1107fae"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""b417357c-51b5-407b-b8c4-87fa61cfb3db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Focus"",
                    ""type"": ""Value"",
                    ""id"": ""c01e3ed9-dbb3-4a99-988f-079856e2a599"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47a92bad-51c1-43f1-8f3a-4ea8778a6106"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7134906-ea94-4f6a-ae3b-b46dba6a675a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Tank
            m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
            m_Tank_Handbreak = m_Tank.FindAction("Handbreak", throwIfNotFound: true);
            m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
            // Turret
            m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
            m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
            m_Turret_Focus = m_Turret.FindAction("Focus", throwIfNotFound: true);
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

        // Tank
        private readonly InputActionMap m_Tank;
        private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
        private readonly InputAction m_Tank_Handbreak;
        private readonly InputAction m_Tank_Movement;
        public struct TankActions
        {
            private @TankControl m_Wrapper;
            public TankActions(@TankControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Handbreak => m_Wrapper.m_Tank_Handbreak;
            public InputAction @Movement => m_Wrapper.m_Tank_Movement;
            public InputActionMap Get() { return m_Wrapper.m_Tank; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
            public void AddCallbacks(ITankActions instance)
            {
                if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
                @Handbreak.started += instance.OnHandbreak;
                @Handbreak.performed += instance.OnHandbreak;
                @Handbreak.canceled += instance.OnHandbreak;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }

            private void UnregisterCallbacks(ITankActions instance)
            {
                @Handbreak.started -= instance.OnHandbreak;
                @Handbreak.performed -= instance.OnHandbreak;
                @Handbreak.canceled -= instance.OnHandbreak;
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
            }

            public void RemoveCallbacks(ITankActions instance)
            {
                if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITankActions instance)
            {
                foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TankActions @Tank => new TankActions(this);

        // Turret
        private readonly InputActionMap m_Turret;
        private List<ITurretActions> m_TurretActionsCallbackInterfaces = new List<ITurretActions>();
        private readonly InputAction m_Turret_Fire;
        private readonly InputAction m_Turret_Focus;
        public struct TurretActions
        {
            private @TankControl m_Wrapper;
            public TurretActions(@TankControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Fire => m_Wrapper.m_Turret_Fire;
            public InputAction @Focus => m_Wrapper.m_Turret_Focus;
            public InputActionMap Get() { return m_Wrapper.m_Turret; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
            public void AddCallbacks(ITurretActions instance)
            {
                if (instance == null || m_Wrapper.m_TurretActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TurretActionsCallbackInterfaces.Add(instance);
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Focus.started += instance.OnFocus;
                @Focus.performed += instance.OnFocus;
                @Focus.canceled += instance.OnFocus;
            }

            private void UnregisterCallbacks(ITurretActions instance)
            {
                @Fire.started -= instance.OnFire;
                @Fire.performed -= instance.OnFire;
                @Fire.canceled -= instance.OnFire;
                @Focus.started -= instance.OnFocus;
                @Focus.performed -= instance.OnFocus;
                @Focus.canceled -= instance.OnFocus;
            }

            public void RemoveCallbacks(ITurretActions instance)
            {
                if (m_Wrapper.m_TurretActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITurretActions instance)
            {
                foreach (var item in m_Wrapper.m_TurretActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TurretActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TurretActions @Turret => new TurretActions(this);
        public interface ITankActions
        {
            void OnHandbreak(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
        }
        public interface ITurretActions
        {
            void OnFire(InputAction.CallbackContext context);
            void OnFocus(InputAction.CallbackContext context);
        }
    }
}
