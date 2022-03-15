using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draged : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject self;
    public GameObject compare;
    public GameObject mainCamera;
    private Vector3 targetRot;
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
            transform.position = Vector3.Lerp(transform.position, targetPos, 10f * Time.deltaTime);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetRot, 10f * Time.deltaTime);

        }
    }
}
