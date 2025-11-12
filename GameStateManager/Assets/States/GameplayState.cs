namespace States
{
    using UnityEngine;

    public class GameplayState : GameState
    {
        public GameplayState(GameStateManager gameStateManager) : base(gameStateManager) {}

        public override void EnterState()
        {
            base.EnterState();
            Debug.Log("STATE: GameplayState is active. InputManager handles transition to GameOverState (Attack action).");
        }

        public override void ExitState()
        {
            base.ExitState();
            Debug.Log("Exiting GameplayState: CLEANUP completed (e.g., stopping enemies, pausing physics).");
        }
    }
}