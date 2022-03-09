using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draged : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject self;
    public GameObject compare;
    public GameObject mainCamera;
    private Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        compare = mainCamera.GetComponent<Select>().selectedObject;
        if(compare == self)
        {
            Debug.Log("Selected");
            targetPos = mainCamera.GetComponent<Select>().hitPosition;
            transform.position = targetPos;

        }
    }
}
