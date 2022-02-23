using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : MonoBehaviour
{

    public Vector3 shipLockPosition;
    public Vector3 lockBoxSize;
    public GameObject lockedGameObject;
    public GameObject[] unlockedGameObjects;
    public GameObject[] lockedGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        //lockedGameObject.transform.position = shipLockPosition;
        checkComponent(unlockedGameObjects[0], lockedGameObjects[0]);
        //Instantiate(shipPrefab, shipLockPosition, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < unlockedGameObjects.Length; i++) {
            if (unlockedGameObjects[i] != null) {
                checkComponent(unlockedGameObjects[i], lockedGameObjects[i]);
            }
        }
    }

    void checkComponent(GameObject unlockedGameObject, GameObject lockedGameObject) {
        Vector3 objectPosition = unlockedGameObject.transform.position;
        if (objectPosition.x > shipLockPosition.x - lockBoxSize.x && objectPosition.x < shipLockPosition.x + lockBoxSize.x) {
            if (objectPosition.y > shipLockPosition.y - lockBoxSize.y && objectPosition.y < shipLockPosition.y + lockBoxSize.y) {
                if (objectPosition.z > shipLockPosition.z - lockBoxSize.z && objectPosition.z < shipLockPosition.z + lockBoxSize.z) {
                    Debug.Log("WITHIN AREA!!");
                    Destroy(unlockedGameObject);
                    lockedGameObject.GetComponent<MeshRenderer>().enabled = true;
                }
            }
        }
    }
}
