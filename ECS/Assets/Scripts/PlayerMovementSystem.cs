using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
[AlwaysSynchronizeSystem]
public class PlayerMovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;

        Entities.WithAll<EnemyTagData>().ForEach((ref Translation translation, in PlayerMovementData moveData) =>
        {
            translation.Value.x += (deltaTime * moveData.speed * moveData.direction.x);
            //translation.Value.z += (deltaTime * moveData.speed * moveData.direction.z);

        }).Run();

        return default;
    }
}