using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Obj;
    Camera mCamera;
    private RectTransform rt;
    Vector2 pos;

    void Start()
    {
        mCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (Obj)
        {
            pos = RectTransformUtility.WorldToScreenPoint(mCamera, Obj.transform.position);
            rt.position = pos;
        }
        else
        {
            Debug.LogError(this.gameObject.name + ": No Object Attached (TrackObject)");
        }


    }

}
