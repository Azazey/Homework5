using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartScaler : MonoBehaviour
{
    public void SetScale(float value)
    {
        transform.localScale = Vector3.one * value;
    }
}
