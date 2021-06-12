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
                    ""type"": ""PassThrough"",
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
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a4bdba19-b55a-41ae-86ae-10b5ff5ec664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""7aa5e2e3-7bb6-4e8a-bbbd-4d7fc9b0e10d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""35446bd0-341d-4a79-b30f-f75570be65fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DebugButton"",
                    ""type"": ""Button"",
                    ""id"": ""b746a4db-8665-447a-be9a-af38e5684ebe"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""220543b0-342b-48ce-a577-dcaad4eb9140"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""1d4b8cb6-ad4a-4134-b9ad-d6704804a155"",
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
                    ""id"": ""95aff561-fd39-4998-988a-7b3dfd7ca556"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""669e1ed3-16ac-449f-b1ef-dea07800dcbf"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e267cac1-17f4-4dd3-aa3c-bf76d009a5a4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cb048a4c-d6d4-464f-8db7-793081100545"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8b9cab1-1774-4f23-8ee0-125a8925f81c"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b362d33e-4494-40fe-af0c-e5d0088b3413"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88496959-9338-4263-9953-a101eb11a07e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddca420a-26f9-4d5d-b552-ff5b33599901"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DebugButton"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_DebugButton = m_Player.FindAction("DebugButton", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interaction;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_DebugButton;
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
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @DebugButton => m_Wrapper.m_Player_DebugButton;
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
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @DebugButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugButton;
                @DebugButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugButton;
                @DebugButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDebugButton;
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
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @DebugButton.started += instance.OnDebugButton;
                @DebugButton.performed += instance.OnDebugButton;
                @DebugButton.canceled += instance.OnDebugButton;
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
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDebugButton(InputAction.CallbackContext context);
    }
}
