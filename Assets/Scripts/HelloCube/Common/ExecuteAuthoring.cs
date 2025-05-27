using UnityEngine;
using Unity.Entities;

namespace HelloCube.Common
{
    /// <summary>
    /// This class provides the ability to toggle different components to enable player
    /// to switch between different implementations for performance improvement
    /// </summary>
    public class ExecuteAuthoring : MonoBehaviour
    {
        public bool mainThread = false;
        public bool iJobEntityThread = false;

        /// <summary>
        /// This class helps to bake the values from MonoBehaviour to IComponents.
        /// We can have this class implemented in a separate file but we are
        /// keeping it here as this is a very small file
        /// </summary>
        class Baker : Baker<ExecuteAuthoring>
        {
            public override void Bake(ExecuteAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                
                if(authoring.mainThread) AddComponent<ExecuteMainThread>(entity);
                if(authoring.iJobEntityThread) AddComponent<ExecuteIJobEntity>(entity);
            }
        }
    }

    public struct ExecuteMainThread : IComponentData
    {
    }
    
    public struct ExecuteIJobEntity : IComponentData
    {
    }
}