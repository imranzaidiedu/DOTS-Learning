using Unity.Entities;
using Unity.Burst;
using Unity.Transforms;
using HelloCube.Common;

namespace HelloCube.MainThread
{
    /// <summary>
    /// This system class is checking if the <see cref="ExecuteMainThread"/> component is executed and then
    /// execute this system 
    /// </summary>
    public partial struct RotationSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<ExecuteMainThread>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            float deltaTime = SystemAPI.Time.DeltaTime;

            foreach (var (transform, speed) in 
                     SystemAPI.Query<RefRW<LocalTransform>, RefRO<RotationSpeed>>())
            {
                transform.ValueRW = transform.ValueRO.RotateY(speed.ValueRO.RadiansPerSecond * deltaTime);
            }
        }
    }
}