using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class MoveToPivot : MonoBehaviour
{
    [SerializeField] private Transform _pivotTransform;

    private void Update()
    {
        transform.position = _pivotTransform.position;
    }
}
