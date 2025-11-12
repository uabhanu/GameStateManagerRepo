namespace States
{
    using UnityEngine;

    public class GameOverState : GameState
    {
        public GameOverState(GameStateManager gameStateManager) : base(gameStateManager) {}

        public override void EnterState()
        {
            base.EnterState();
            Debug.Log("STATE: GameOverState is active. Press the assigned INPUT (Crouch) to restart.");
        }

        public override void ExitState()
        {
            base.ExitState();
            Debug.Log("Exiting GameOverState: CLEANUP completed (Hiding UI, resetting scores, etc.)");
        }
    }
}