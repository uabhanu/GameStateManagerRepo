namespace Input
{
    using States;
    using UnityEngine;
    using UnityEngine.InputSystem;

    public class InputManager : MonoBehaviour , InputSystem_Actions.IPlayerActions
    {
        #region Variables

        private InputSystem_Actions _inputActions;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            _inputActions = new InputSystem_Actions();
            _inputActions.Player.SetCallbacks(this);
        }

        private void OnEnable() { _inputActions.Player.Enable(); }

        private void OnDisable() { _inputActions.Player.Disable(); }
        
        #endregion
        
        #region Input Callback Methods

        public void OnAttack(InputAction.CallbackContext callbackContext)
        {
            if(callbackContext.performed)
            {
                if(GameStateManager.Instance.CurrentState is GameplayState) { GameStateManager.Instance.TransitionToState(typeof(GameOverState)); }
            }
        }

        public void OnCrouch(InputAction.CallbackContext callbackContext)
        {
            if(callbackContext.performed)
            {
                if(GameStateManager.Instance.CurrentState is GameOverState) { GameStateManager.Instance.TransitionToState(typeof(MenuState)); }
            }
        }

        public void OnInteract(InputAction.CallbackContext callbackContext) {}

        public void OnJump(InputAction.CallbackContext callbackContext)
        {
            if(callbackContext.performed)
            {
                if(GameStateManager.Instance.CurrentState is MenuState) { GameStateManager.Instance.TransitionToState(typeof(GameplayState)); }
            }
        }

        public void OnLook(InputAction.CallbackContext callbackContext) {}
        public void OnMove(InputAction.CallbackContext callbackContext) {}
        public void OnNext(InputAction.CallbackContext callbackContext) {}
        public void OnPrevious(InputAction.CallbackContext callbackContext) {}
        public void OnSprint(InputAction.CallbackContext callbackContext) {}
        
        #endregion
    }
}