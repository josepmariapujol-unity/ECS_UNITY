using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public class PlayerInputMovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        Entities.WithoutBurst().ForEach((ref PlayerMovementData moveData, in PlayerInputData inputData) =>
        {
            moveData.direction = new float3(0,0,0);
            moveData.direction.x += Input.GetKeyDown(inputData.forwardKey) ? 1 : 0;

        }).Run();
        
        return default;
    }
}
