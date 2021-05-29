// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b3f62873-bb01-48a8-ba78-beeeb79af62f"",
            ""actions"": [
                {
                    ""name"": ""RightMouseButton"",
                    ""type"": ""PassThrough"",
                    ""id"": ""432f440a-c4e7-4124-ae19-f01838e9ccf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3058bb0-ab2c-4d0a-a4d3-4fcf5bd217fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell_1"",
                    ""type"": ""Button"",
                    ""id"": ""79fb4393-1a7e-4023-bc81-3189bd85e4a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell_2"",
                    ""type"": ""Button"",
                    ""id"": ""07bbf0f7-30cc-4d12-800a-008e21e00b62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell_3"",
                    ""type"": ""Button"",
                    ""id"": ""9d7c27be-201b-4074-8643-dbaa31d7e62f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell_ULT"",
                    ""type"": ""Button"",
                    ""id"": ""5e934d72-c207-4c14-a3c3-ec35a91a62e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ee0b1a2-2c16-490f-9177-4dedbc8a4ef4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f0cbed8-6b1c-4fcf-8d20-dcc11636d2d6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""RightMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f09e515-dcf5-4063-8ac0-92d63a3b7ec5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad202e31-9d83-4d41-87bd-d2d3bc5951c7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea2cff97-3eb3-4e09-a79d-ee590c2ea41c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2fc46e-ab4e-4c13-ae37-79b39dd4cdeb"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell_ULT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RightMouseButton = m_Player.FindAction("RightMouseButton", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
        m_Player_Spell_1 = m_Player.FindAction("Spell_1", throwIfNotFound: true);
        m_Player_Spell_2 = m_Player.FindAction("Spell_2", throwIfNotFound: true);
        m_Player_Spell_3 = m_Player.FindAction("Spell_3", throwIfNotFound: true);
        m_Player_Spell_ULT = m_Player.FindAction("Spell_ULT", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_RightMouseButton;
    private readonly InputAction m_Player_MousePosition;
    private readonly InputAction m_Player_Spell_1;
    private readonly InputAction m_Player_Spell_2;
    private readonly InputAction m_Player_Spell_3;
    private readonly InputAction m_Player_Spell_ULT;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightMouseButton => m_Wrapper.m_Player_RightMouseButton;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputAction @Spell_1 => m_Wrapper.m_Player_Spell_1;
        public InputAction @Spell_2 => m_Wrapper.m_Player_Spell_2;
        public InputAction @Spell_3 => m_Wrapper.m_Player_Spell_3;
        public InputAction @Spell_ULT => m_Wrapper.m_Player_Spell_ULT;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @RightMouseButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMouseButton;
                @RightMouseButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMouseButton;
                @RightMouseButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightMouseButton;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @Spell_1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_1;
                @Spell_1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_1;
                @Spell_1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_1;
                @Spell_2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_2;
                @Spell_2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_2;
                @Spell_2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_2;
                @Spell_3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_3;
                @Spell_3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_3;
                @Spell_3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_3;
                @Spell_ULT.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_ULT;
                @Spell_ULT.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_ULT;
                @Spell_ULT.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpell_ULT;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RightMouseButton.started += instance.OnRightMouseButton;
                @RightMouseButton.performed += instance.OnRightMouseButton;
                @RightMouseButton.canceled += instance.OnRightMouseButton;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Spell_1.started += instance.OnSpell_1;
                @Spell_1.performed += instance.OnSpell_1;
                @Spell_1.canceled += instance.OnSpell_1;
                @Spell_2.started += instance.OnSpell_2;
                @Spell_2.performed += instance.OnSpell_2;
                @Spell_2.canceled += instance.OnSpell_2;
                @Spell_3.started += instance.OnSpell_3;
                @Spell_3.performed += instance.OnSpell_3;
                @Spell_3.canceled += instance.OnSpell_3;
                @Spell_ULT.started += instance.OnSpell_ULT;
                @Spell_ULT.performed += instance.OnSpell_ULT;
                @Spell_ULT.canceled += instance.OnSpell_ULT;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnRightMouseButton(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnSpell_1(InputAction.CallbackContext context);
        void OnSpell_2(InputAction.CallbackContext context);
        void OnSpell_3(InputAction.CallbackContext context);
        void OnSpell_ULT(InputAction.CallbackContext context);
    }
}
