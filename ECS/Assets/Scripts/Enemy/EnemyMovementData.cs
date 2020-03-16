using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
[GenerateAuthoringComponent]
public struct EnemyMovementData : IComponentData
{
    public float speed;
    public float3 direction;
}
