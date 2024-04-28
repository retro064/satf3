using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool keyCollected = false;
    public int keyThreshold;
    public int keysCollected = 0;
    private GameObject door;
    public TextMeshProUGUI keyText;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door");
    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keysCollected.ToString() + "/" + keyThreshold.ToString();
        if (keysCollected == keyThreshold)
        {
            keyCollected = true;

        }

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
