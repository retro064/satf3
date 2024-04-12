using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 3;
    private int curHealth;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = curHealth.ToString() + "x";

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
            curHealth = 0;
            // Destroy player
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            curHealth--;
        }
        if (other.CompareTag("Heart"))
        {
            curHealth++;
        }
    }
}
