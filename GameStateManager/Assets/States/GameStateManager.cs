namespace States
{
    using Events;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameStateManager : MonoBehaviour
    {
        #region Variables
        
        private Dictionary<System.Type , GameState> _availableStatesDict;

        public GameState CurrentState{get; private set;}
        public static GameStateManager Instance{get; private set;}
        
        #endregion
        
        #region Unity Methods

        private void Awake()
        {
            if(Instance && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeStates();
            TransitionToState(typeof(MenuState));
        }

        private void Update() { CurrentState?.UpdateState(); }
        
        #endregion
        
        #region My Methods

        private void InitializeStates() { _availableStatesDict = new Dictionary<System.Type , GameState>() { { typeof(MenuState) , new MenuState(this) } , { typeof(GameplayState) , new GameplayState(this) } , { typeof(GameOverState) , new GameOverState(this) } }; }

        public void TransitionToState(System.Type newStateType)
        {
            if(!_availableStatesDict.ContainsKey(newStateType))
            {
                Debug.LogError($"State Type {newStateType} not found in available states!");
                return;
            }

            CurrentState?.ExitState();
            CurrentState = _availableStatesDict[newStateType];
            CurrentState.EnterState();

            if(newStateType == typeof(GameplayState)) { GameEvents.TriggerGameStart(); }
            else if(newStateType == typeof(GameOverState)) { GameEvents.TriggerGameOver(); }
        }
        
        #endregion
    }
}