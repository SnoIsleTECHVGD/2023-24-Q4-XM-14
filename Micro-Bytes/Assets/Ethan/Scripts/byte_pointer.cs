using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byte_pointer : MonoBehaviour
{
    public Transform Target;
    public float HideDistance;
    private void Update()
    {
        var dir = Target.position - transform.position;
        if(dir.magnitude < HideDistance)
        {
            SetChildrenActive(false);
        }
        else
        {
            SetChildrenActive(true);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }
    void SetChildrenActive(bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }
}
