using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool keyCollected = false;
    public static int keyThreshold = 3;
    private GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door");
    }

    // Update is called once per frame
    void Update()
    {
        if (keyCollected)
        {
            door.SetActive(false);
        }
    }
    
    /* In level 2:
     * if enemyCount < 0:
     * key spawns
     * 
     * enemyCount = getArrayOfGameObjectsTags("Enemy")
     */
}
