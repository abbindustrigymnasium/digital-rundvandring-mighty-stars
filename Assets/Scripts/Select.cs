using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider hitObject;
    public Vector3 hitPosition;
    public GameObject selectedObject;
    public Transform AROriginTransform;

    public GameObject camera;

    public void select (){

        int objectLayer = 1 << 3;
        objectLayer = ~objectLayer;

        int planeLayer = 1 << 6;
        planeLayer = ~planeLayer;

        RaycastHit objectHit;
        RaycastHit planeHit;

        var rot = transform.TransformDirection(Vector3.forward) * 20;
        Debug.Log(Physics.Raycast(camera.transform.position, rot));
        if(Physics.Raycast(camera.transform.position, rot, out objectHit)){
            Debug.Log(objectHit.transform);
            hitPosition = camera.transform.position + camera.transform.forward * 1;
            hitPosition.y -= 0.25f;
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
    public void deSelect(){
        StartCoroutine(Wait(0.5f));
        
        Debug.Log("deselected");
    }

    IEnumerator Wait(float time)
    {   
        yield return new WaitForSeconds(time);
        selectedObject = null;
        Debug.Log("deselected");

    }

}
