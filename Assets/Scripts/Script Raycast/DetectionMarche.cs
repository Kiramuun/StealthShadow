using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionMarche : MonoBehaviour
{
    public Transform[] _detectionRayStart;
    private Vector3 _floorPos,
                    _stepPos;

    void Update()
    {
        RaycastHit hitFloor;

        if(Physics.Raycast(transform.position, Vector3.down, out hitFloor, 0.3f))
        {
            Debug.DrawRay(transform.position, Vector3.down * 0.3f, Color.red);
            _floorPos = hitFloor.point;
        }

        RaycastHit hitStep;

        if (Physics.Raycast(_detectionRayStart[0].position, Vector3.down, out hitStep, 2f))
        {
            Debug.DrawRay(_detectionRayStart[0].position, Vector3.down * 2f, Color.red);
            _stepPos = hitStep.point;
        }
        Debug.Log("Hauteur : " + (_stepPos.y - _floorPos.y));
    }
}
