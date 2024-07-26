using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AABB : MonoBehaviour
{
    [Min(0)]
    public float expandSize = 0;
    public static Bounds s_AABB;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    { 
        
        s_AABB = new Bounds(GetComponent<SkinnedMeshRenderer>().bounds.center, Vector3.zero);
        s_AABB.Expand(expandSize);
    }

    private void OnDrawGizmos()
    {
        var oldColor = Gizmos.color;
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(s_AABB.center, s_AABB.size);
        Gizmos.color = oldColor;
    }
}
