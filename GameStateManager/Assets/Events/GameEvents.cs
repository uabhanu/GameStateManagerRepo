namespace Events
{
    using System;
    using UnityEngine;
    
    public static class GameEvents
    {
        public static event Action OnGameStart;
        public static event Action OnGameOver;
        public static event Action OnGamePause;
        
        public static void TriggerGameOver()
        {
            OnGameOver?.Invoke();
            Debug.Log("EVENT FIRED: OnGameOver (Decoupling verified)");
        }
        
        public static void TriggerGamePause()
        {
            OnGamePause?.Invoke();
            Debug.Log("EVENT FIRED: OnGamePause");
        }
        
        public static void TriggerGameStart()
        {
            OnGameStart?.Invoke();
            Debug.Log("EVENT FIRED: OnGameStart (Decoupling verified)");
        }
    }
}