using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveTrigger : MonoBehaviour
{
    public SkinnedMeshRenderer mr;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            mr.material.SetFloat("Vector1_67d7587098df4b63b2c9799a2ec14f1a", Time.time);
            
        }
    }
}
