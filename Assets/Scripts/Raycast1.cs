using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//[RequireComponent(ARRaycastManager)]
//public class NewBehaviourScript : MonoBehaviour
//{   
//    private ARRaycastManager raycastManager;
//
//    [SerializeField]
//    private GameObject PlacablePrefab;
//
//    private GameObject spawnedObject;
//
//    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();
//
//    private void Start(){
//        raycastManager = GetComponent<ARRaycastManager>();
//    }
//
//    bool tryGetPosition (out Vector2 touchPostition)
//    {
//        if(Input.touchCount > 0)
//        {
//            touchPostition = Input.GetTouch(0).position;
//            return true;
//        }
//
//        touchPostition = default;
//        return false;
//    }
//    
//    private void Update()
//    {
//    if(!tryGetPosition(out Vector2 touchPostition))
//    {
//        return;
//    }
//    if(raycastManager.Raycast(touchPostition, s_Hits, TrackableType.PlaneWithinBounds))
//        var hitPose = s_Hits[0].pose;
//        if(spawnedObject== null)
//        {
//            spawnedObject = Instantiate(PlacablePrefab, hitPose.position, hitPose.rotation);
//        }
//        else
//        {
//            spawnedObject.transform.position = hitPose.position;
//            spawnedObject.transform.rotation = hitPose.rotation;
//
//        }
//    }
//}
