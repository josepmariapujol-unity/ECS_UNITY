using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
[AlwaysSynchronizeSystem]
public class EnemyInputMovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        Entities.WithAll<EnemyTagData>().ForEach((ref EnemyMovementData moveData, in PlayerPositionData positionData, in Translation translation) =>
        {
            moveData.direction = new float3(0f,0f,0f);
            /*
                moveData.direction.x = (positionData.position.x - translation.Value.x);
                moveData.direction.z = (positionData.position.z - translation.Value.z);
             */
            moveData.direction.x += 1;

        }).Run();
        
        return default;
    }
}
