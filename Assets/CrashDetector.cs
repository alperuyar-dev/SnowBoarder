using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioClip crashAudio;

    bool alive = true;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && alive)
        {
            alive = false;
            FindObjectOfType<Physics>().Dead();
            GetComponent<AudioSource>().PlayOneShot(crashAudio);
            particle.Play();
            Invoke("ReloadScene", 1.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
