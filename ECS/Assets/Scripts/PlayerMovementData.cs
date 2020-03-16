using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
[GenerateAuthoringComponent]
public struct PlayerMovementData : IComponentData
{
    public float speed;
    public float3 direction;
}