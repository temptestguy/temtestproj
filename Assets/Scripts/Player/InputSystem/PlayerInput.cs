using UnityEngine;
using UnityEngine.Events;

namespace InputSystem
{
    public class PlayerInput : MonoBehaviour
    {    
        public UnityEvent onInputDetected = new UnityEvent();
        
#if UNITY_EDITOR
        private float downTime = .0f;
        private float pressedRequiredTime = .4f;

        private void Awake()
        {
                downTime = Time.time;                   
        }
#endif

        private void FixedUpdate()
        {
#if UNITY_EDITOR
            if (Input.GetKey(KeyCode.Space))
            {
                    if (Time.time - downTime > pressedRequiredTime)
                    {
                            onInputDetected.Invoke();
                            downTime = Time.time;
                    }
            }
#endif
        }
    }
}
