using UnityEngine;
using Unity.Entities;

namespace HelloCube.Common
{
    public class ExecuteAuthoring : MonoBehaviour
    {
        public bool mainThread = false;

        class Baker : Baker<ExecuteAuthoring>
        {
            public override void Bake(ExecuteAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);
                
                if(authoring.mainThread) AddComponent<ExecuteMainThread>(entity);
            }
        }
    }

    public struct ExecuteMainThread : IComponentData
    {
    }
}