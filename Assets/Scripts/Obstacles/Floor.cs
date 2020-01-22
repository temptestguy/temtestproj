using UnityEngine;
using Pose = Utils.Pose;

namespace Obstacles
{
    public class Floor : Obstacle
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            GameObject go = other.gameObject;
            
            if (go.CompareTag(interactTagType))
            {
               Debug.Log("DIE");
            }
        }

        public override void Respawn(Pose pose)
        {
            throw new System.NotImplementedException();
        }
    }
}
