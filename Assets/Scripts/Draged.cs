using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draged : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject self;
    public GameObject compare;
    public GameObject mainCamera;
    private Transform targetRot;
    private Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        compare = mainCamera.GetComponent<Select>().selectedObject;
        if(compare == self)
        {
            Debug.Log("Selected");
            targetPos = mainCamera.GetComponent<Select>().hitPosition;
            targetRot = mainCamera.GetComponent<Select>().hitRotation;
            transform.forward = targetRot.forward*-1;
            transform.Rotate(270,0,0);
            transform.position = Vector3.Lerp(transform.position, targetPos, 10f * Time.deltaTime);


        }
    }
}
