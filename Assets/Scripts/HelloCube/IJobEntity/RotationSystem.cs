using Unity.Mathematics;
using Unity.Entities;
using Unity.Burst;
using Unity.Transforms;
using HelloCube.Common;

namespace HelloCube.JobEntity
{
    public partial struct RotationSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<ExecuteIJobEntity>();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var job = new JobRatation { deltaTime = SystemAPI.Time.DeltaTime };
            job.Schedule();
        }
    }

    [BurstCompile]
    partial struct JobRatation : IJobEntity
    {
        public float deltaTime;

        void Execute(ref LocalTransform transform, in RotationSpeed speed)
        {
            transform = transform.RotateY(speed.RadiansPerSecond * deltaTime);
        }
    }
}