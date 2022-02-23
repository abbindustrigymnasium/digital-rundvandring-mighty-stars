using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : MonoBehaviour
{

    public Vector3 shipLockPosition;
    public Vector3 lockBoxSize;
    public GameObject moveableShip;
    public Transform shipPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveableShip != null) {
            checkComponent();
        }
        
    }

    void checkComponent() {
        Vector3 shipPosition = moveableShip.transform.position;
        if (shipPosition.x > shipLockPosition.x - lockBoxSize.x && shipPosition.x < shipLockPosition.x + lockBoxSize.x) {
            if (shipPosition.y > shipLockPosition.y - lockBoxSize.y && shipPosition.y < shipLockPosition.y + lockBoxSize.y) {
                if (shipPosition.z > shipLockPosition.z - lockBoxSize.z && shipPosition.z < shipLockPosition.z + lockBoxSize.z) {
                    Debug.Log("WITHIN AREA!!");
                    Destroy(moveableShip);
                    Instantiate(shipPrefab, shipLockPosition, Quaternion.identity);
                }
            }
        }
    }
}
