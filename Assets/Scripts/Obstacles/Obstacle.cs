using System;
using UnityEngine;
using Pose = Utils.Pose;

namespace Obstacles
{
    [RequireComponent(typeof(Collider2D))]
    public abstract class Obstacle : MonoBehaviour
    {
        public string interactTagType = "Player";
        
        public abstract void Respawn(Pose pose);
    }
}