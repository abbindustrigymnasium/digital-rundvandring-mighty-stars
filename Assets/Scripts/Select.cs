using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider hitObject;
    public Vector3 hitPosition;
    public Vector3 hitRotation;
    public GameObject selectedObject;
    public Transform AROriginTransform;

    public GameObject camera;

    private bool heldDown;

    void Update(){
    if (heldDown){


        int objectLayer = 1 << 3;
        objectLayer = ~objectLayer;

        int planeLayer = 1 << 6;
        planeLayer = ~planeLayer;

        RaycastHit objectHit;
        RaycastHit planeHit;

        var rot = transform.TransformDirection(Vector3.forward) * 40;
        Debug.Log(Physics.Raycast(camera.transform.position, rot));
        if(Physics.Raycast(camera.transform.position, rot, out objectHit)){
            Debug.Log(objectHit.transform);
            hitPosition = camera.transform.position + camera.transform.forward * 1;
            hitRotation = camera.transform.eulerAngles + new Vector3(0,90,0);
            Debug.Log(hitPosition);
            Debug.Log(camera.transform.position);
            Debug.Log(camera.transform.forward);    
            if(Physics.Raycast(camera.transform.position, rot, out planeHit)){
                selectedObject = objectHit.collider.gameObject.transform.parent.gameObject;
                Debug.Log(objectHit.collider);
            }
        }
        Debug.DrawRay(camera.transform.position, rot*10,Color.red, 3.0f);

}
    }
    public void select (){
        heldDown = true;
Debug.Log("selected");

    }
    public void deSelect(){
        StartCoroutine(Wait(0.5f));
        heldDown = false;
        Debug.Log("deselected");
    }

    IEnumerator Wait(float time)
    {   
        yield return new WaitForSeconds(time);
        selectedObject = null;

    }

}
