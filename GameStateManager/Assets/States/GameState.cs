namespace States
{
    using UnityEngine;
    
    public abstract class GameState
    {
        protected readonly GameStateManager _gameStateManager;
        
        public GameState(GameStateManager gameStateManager) { _gameStateManager = gameStateManager; }
        
        public virtual void EnterState() { Debug.Log($"Entering State: {GetType().Name}"); }
        
        public virtual void ExitState() { Debug.Log($"Exiting State: {GetType().Name}"); }
        
        public virtual void UpdateState() {}
    }
}