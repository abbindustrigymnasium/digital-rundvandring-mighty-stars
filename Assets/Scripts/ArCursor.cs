using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArCursor : MonoBehaviour
{
//
//    public GameObject cursorChildObject;
//    public GameObject objectToPlace;
//    public ARRaycastManager raycastManager;
//
//    public bool useCursor = true;
//    // Start is called before the first frame update
//    void Start()
//    {
//        cursorChildObject.SetActive(useCursor);
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//        if (useCursor){
//            UpdateCursor();
//        }
//        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
//          if (useCursor) {
//              GameIbject.Instansiate(objectToPlace, transform.position, transform);
//          }
//          else
//          {
//                List<ARRaycastHit> hits = new List<ARRaycastHit>();
//                raycastManager.Raycast(Input.GetTouch(0).position, hits, UnityEngine,XR.ARSubsystems.TrackableType.Planes);
//                if (hit.Counts > 0)
//                {
//                    GameObject.Instansiate(objectToPlace, hits[0],pose.position,hits[0],pose.rotation)
//                }    
//          }
//        }
//    }
//
//    void UpdateCursor()
//    {
//        Vector2 screenPosition = Camera.Main.ViewportToScreenPoint(new Vector2(0.5f,0.5f));
//        List<ARRaycastHit> hits = new List<ARRaycastHit>();
//        raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
//
//        if (hits.Count > 0)
//        {
//            transform.position = hits[0].pose.position;
//            transform.rotation = hits[0].pose.rotation;
//
//        }
//    }
}
