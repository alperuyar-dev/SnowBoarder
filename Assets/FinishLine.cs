using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioClip finishAudio;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(finishAudio);
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

