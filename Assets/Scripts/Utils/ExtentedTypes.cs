using UnityEngine;

namespace Utils
{ 
#region ExtendetTypes

    public struct Pose
    {
        public Vector2 position;
        public Quaternion rotation;

        public Pose(Vector2 position, Quaternion rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }
        
        public Pose(Vector2 position)
        {
            this.position = position;
            rotation = Quaternion.identity;
        }
    }
    
#endregion
}
