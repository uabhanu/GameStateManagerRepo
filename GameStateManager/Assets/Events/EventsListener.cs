namespace Events
{
    using UnityEngine;
    
    public class EventTestListener : MonoBehaviour
    {
        #region Unity Methods
        
        private void OnEnable()
        {
            GameEvents.OnGameStart += OnGameStartHandler;
            GameEvents.OnGameOver += OnGameOverHandler;

            Debug.Log("Events Listener is SUBSCRIBED to GameEvents.");
        }
        
        private void OnDisable()
        {
            GameEvents.OnGameStart -= OnGameStartHandler;
            GameEvents.OnGameOver -= OnGameOverHandler;
        }
        
        #endregion
        
        #region Event Listener Methods

        private void OnGameStartHandler() { Debug.Log("LISTENER CONFIRMED: Received OnGameStart event successfully!"); }

        private void OnGameOverHandler() { Debug.Log("LISTENER CONFIRMED: Received OnGameOver event successfully!"); }
        
        #endregion
    }
}