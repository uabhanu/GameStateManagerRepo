namespace States
{
    using UnityEngine;

    public class MenuState : GameState
    {
        public MenuState(GameStateManager gameStateManager) : base(gameStateManager) {}

        public override void EnterState()
        {
            base.EnterState();
            Debug.Log("STATE: MenuState is active. InputManager handles transition to GameplayState (Jump action).");
        }

        public override void ExitState()
        {
            base.ExitState();
            Debug.Log("Exiting MenuState: CLEANUP completed (e.g., hiding the main menu canvas).");
        }
    }
}