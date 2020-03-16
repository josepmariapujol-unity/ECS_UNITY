/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
[AlwaysSynchronizeSystem]
public class PlayerPositionSystem : JobComponentSystem
{ 
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
       

        Entities.WithAll<PlayerTagData>().ForEach((ref PlayerPositionData positionData, in Translation translation) =>
            {
                positionData.position.x = translation.Value.x;
                positionData.position.z = translation.Value.z;
            }).Run();

        return default;
      
    }
 
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        throw new System.NotImplementedException();
    }
}
*/