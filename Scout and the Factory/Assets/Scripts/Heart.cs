using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public float speed = 5.0f;
    private PlayerHealth playerHealth;
    private AudioSource audioSource;
    public AudioClip healSfx;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        // transform.rotation = Quaternion.Euler(0, speed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(healSfx, 1f);
            playerHealth.curHealth++;
            Destroy(gameObject);
        }
    }

    IEnumerator delayDestroy()
    {
        yield return null;
        gameObject.SetActive(false);
        yield return new WaitForSeconds(.66f);
        
    }
}
