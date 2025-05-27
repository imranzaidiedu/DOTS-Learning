using UnityEngine;
using Unity.Mathematics;
using Unity.Entities;

namespace HelloCube.Common
{
    /// <summary>
    /// This script is to bake rotation speed value as an IComponent to this gameObject's entity
    /// </summary>
    public class RotationSpeedAuthoring : MonoBehaviour
    {
        public float rotationSpeed = 10f;

        class Baker : Baker<RotationSpeedAuthoring>
        {
            public override void Bake(RotationSpeedAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);
                AddComponent(entity, new RotationSpeed()
                {
                    RadiansPerSecond = math.radians(authoring.rotationSpeed)
                });
            }
        }
    }

    public struct RotationSpeed : IComponentData
    {
        public float RadiansPerSecond;
    }
}