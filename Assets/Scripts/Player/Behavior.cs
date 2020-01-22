using UnityEngine;
using InputSystem;

namespace Player
{
    public class Behavior : MonoBehaviour
    {
        public PlayerInput playerInput;
        public float forceFactorX = 10;
        public float forceFactorY = 10;

        private Rigidbody2D _rigidbody2D;
        
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            playerInput.onInputDetected.AddListener(Jump);
        }

        private void OnDisable()
        {
            playerInput.onInputDetected.RemoveListener(Jump);
        }

        private void Jump()
        {
            _rigidbody2D.AddForce(new Vector2(forceFactorX, forceFactorY), ForceMode2D.Impulse );
        }
    }
}
