using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Transform cursorObject;
    public float distanceFromCam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        FollowCursor();
    }

    void FollowCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 targetLocation = ray.origin + (ray.direction * distanceFromCam);
        cursorObject.position = targetLocation;

    }
}
