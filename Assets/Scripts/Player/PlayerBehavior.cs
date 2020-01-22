using UnityEngine;
using InputSystem;

namespace Player
{
    public class PlayerBehavior : MonoBehaviour
    {
        public PlayerInput playerInput;
        public float forceFactorX = 1f;
        public float forceFactorY = 1f;

        private Rigidbody2D rigidbody2D;
        
        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.freezeRotation = true;
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
            rigidbody2D.AddForce(new Vector2(forceFactorX, forceFactorY), ForceMode2D.Impulse );
        }
    }
}
