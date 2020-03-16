using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
[AlwaysSynchronizeSystem]
public class EnemyMovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltaTime = Time.DeltaTime;

        return Entities.WithAll<EnemyTagData>().ForEach((ref Translation translation, in EnemyMovementData moveData) =>
        {
            /*
            translation.Value.x += (deltaTime * moveData.speed * moveData.direction.x);
            translation.Value.y += (deltaTime * moveData.speed * moveData.direction.y);
            translation.Value.z += (deltaTime * moveData.speed * moveData.direction.z);
            */
            translation.Value.x += (deltaTime * moveData.speed * moveData.direction.x);
            translation.Value.z += (deltaTime * moveData.speed * moveData.direction.z);


        }).Schedule(inputDeps);

//        return inputDeps;
    }
}
