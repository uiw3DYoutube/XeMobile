// GENERATED AUTOMATICALLY FROM 'Assets/prefabs/InputSystem/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""873e6326-8918-47fa-9a27-87b150ab9711"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""3ce056bb-ff96-4811-9434-8061dbf6ca73"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CursorPos"",
                    ""type"": ""Value"",
                    ""id"": ""e6ad816b-037f-491b-9f69-19580871ca1c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MainAction"",
                    ""type"": ""Button"",
                    ""id"": ""0c1d443d-2e4a-473a-ac9d-19529ebed871"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""757536d5-9534-4e0f-af72-f3f0dd92b359"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""71c9ace8-84cd-4149-8b8b-d499cf6dadb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1a6c7f78-8e57-43cb-a0ed-9253434f5188"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7259cbe7-ce05-4b94-89ac-80b1f7990f66"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b981e1c8-9033-43aa-a168-9ce5786d0ee5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c16c690d-4ec8-471b-9549-ae977451d05b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f1ad01e-f365-4cbd-972d-47ec5bd68cb9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7f7715f7-82a7-4b66-b25d-dd0bc9e6f1af"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CursorPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e16f849-9167-446b-858b-ad3c921ba546"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c946a310-dce0-401c-a7b2-0e64ffc7e5b6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61937af0-f1e8-4a99-920b-bc24f5cf26d6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_move = m_Gameplay.FindAction("move", throwIfNotFound: true);
        m_Gameplay_CursorPos = m_Gameplay.FindAction("CursorPos", throwIfNotFound: true);
        m_Gameplay_MainAction = m_Gameplay.FindAction("MainAction", throwIfNotFound: true);
        m_Gameplay_Space = m_Gameplay.FindAction("Space", throwIfNotFound: true);
        m_Gameplay_NextWeapon = m_Gameplay.FindAction("NextWeapon", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_move;
    private readonly InputAction m_Gameplay_CursorPos;
    private readonly InputAction m_Gameplay_MainAction;
    private readonly InputAction m_Gameplay_Space;
    private readonly InputAction m_Gameplay_NextWeapon;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Gameplay_move;
        public InputAction @CursorPos => m_Wrapper.m_Gameplay_CursorPos;
        public InputAction @MainAction => m_Wrapper.m_Gameplay_MainAction;
        public InputAction @Space => m_Wrapper.m_Gameplay_Space;
        public InputAction @NextWeapon => m_Wrapper.m_Gameplay_NextWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @CursorPos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPos;
                @CursorPos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPos;
                @CursorPos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCursorPos;
                @MainAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainAction;
                @MainAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainAction;
                @MainAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainAction;
                @Space.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpace;
                @NextWeapon.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextWeapon;
                @NextWeapon.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextWeapon;
                @NextWeapon.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextWeapon;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @CursorPos.started += instance.OnCursorPos;
                @CursorPos.performed += instance.OnCursorPos;
                @CursorPos.canceled += instance.OnCursorPos;
                @MainAction.started += instance.OnMainAction;
                @MainAction.performed += instance.OnMainAction;
                @MainAction.canceled += instance.OnMainAction;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @NextWeapon.started += instance.OnNextWeapon;
                @NextWeapon.performed += instance.OnNextWeapon;
                @NextWeapon.canceled += instance.OnNextWeapon;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCursorPos(InputAction.CallbackContext context);
        void OnMainAction(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnNextWeapon(InputAction.CallbackContext context);
    }
}
