using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLock : MonoBehaviour
{

    public Vector3 shipLockPosition;
    public Vector3 lockBoxSize;
    public GameObject lockedGameObject;
    public GameObject lockedGhostGameObject;
    public GameObject[] unlockedGameObjects;
    public GameObject[] lockedGameObjects;
    public GameObject[] lockedGhostGameObjects;
    public GameObject endScreen;
    public GameObject restartButton;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        lockedGameObject.transform.position = shipLockPosition;
        lockedGhostGameObject.transform.position = shipLockPosition;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < unlockedGameObjects.Length; i++) {
            if (unlockedGameObjects[i] != null) {
                checkComponent(unlockedGameObjects[i], lockedGameObjects[i], lockedGhostGameObjects[i]);
            }
        }
       
    }

    void checkComponent(GameObject unlockedGameObject, GameObject lockedGameObject, GameObject lockedGhostGameObject) {
        Vector3 objectPosition = unlockedGameObject.transform.position;
        if (objectPosition.x > shipLockPosition.x - lockBoxSize.x && objectPosition.x < shipLockPosition.x + lockBoxSize.x) {
            if (objectPosition.y > shipLockPosition.y - lockBoxSize.y && objectPosition.y < shipLockPosition.y + lockBoxSize.y) {
                if (objectPosition.z > shipLockPosition.z - lockBoxSize.z && objectPosition.z < shipLockPosition.z + lockBoxSize.z) {
                    counter++;
                    Debug.Log("New Locked Object", unlockedGameObject);
                    Destroy(unlockedGameObject);
                    lockedGhostGameObject.GetComponent<MeshRenderer>().enabled = false;
                    lockedGameObject.GetComponent<MeshRenderer>().enabled = true;
                    if (counter == 9){
                        endScreen.SetActive(true);
                        restartButton.SetActive(true);
                    }
                }
            }
        }
    }
    public void disableEndScreen(){
        endScreen.SetActive(false);

    }
}
