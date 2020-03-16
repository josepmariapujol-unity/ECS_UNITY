using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
[GenerateAuthoringComponent]
public struct PlayerPositionData : IComponentData
{
    public float3 position;
}
