using UnityEngine;
using Pose = Utils.Pose;

namespace Obstacles
{
    public class Booster : Obstacle
    {
        public float boostFactor = 2f;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            GameObject go = other.gameObject;
            
            if (go.CompareTag(interactTagType))
            {
                go.GetComponent<Rigidbody2D>().AddForce(Vector2.up * boostFactor, ForceMode2D.Impulse);
            }
        }

        public override void Respawn(Pose pose)
        {
            throw new System.NotImplementedException();
        }
    }
}
