using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip heartCollected;
    public AudioClip keyCollected;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("Player hit enemy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MovingPlatform"))
        {
            transform.SetPositionAndRotation(other.transform.position, other.transform.rotation);
        }

        if (other.CompareTag("Heart"))
        {
            audioSource.PlayOneShot(heartCollected, 1f);
        }

        if (other.CompareTag("Key"))
        {
            audioSource.PlayOneShot(keyCollected, 1f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
