using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision : MonoBehaviour
{
    [SerializeField] ParticleSystem crashedVfx;
    [SerializeField] ParticleSystem portalHit;
    [SerializeField] ParticleSystem fire;
    [SerializeField] ParticleSystem successVfx;
    [SerializeField] AudioClip crashedSFX;
    [SerializeField] AudioClip portalSFX;
    [SerializeField] AudioClip butterPickup;
    [SerializeField] AudioClip successSfx;
    [SerializeField] GameObject plate;
    [SerializeField] GameObject afterPickupSpawn;
    [SerializeField] GameObject beforePickupSpawn;
    [SerializeField] GameObject butter;
    [SerializeField] float delay = 1f;

    
    AudioSource audioSource;
    WinHandler winHandler;
    
    bool isTransitioning = false;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        winHandler = GetComponent<WinHandler>();
        plate.SetActive(false);
        afterPickupSpawn.SetActive(false);
        
    }

   
    void Update()
    {
        Quit();
    }

    private void OnCollisionEnter(Collision other)
    {
        
            switch (other.gameObject.tag)
            {
                case "Enemy":
                    Debug.Log("crashed");
                    CrashSequence();
                    break;
                case "Portal":
                    Debug.Log("crashed");
                    PortalSequence();
                    break;
                case "Butter":
                    Debug.Log("picked");
                    audioSource.PlayOneShot(butterPickup);
                    plate.SetActive(true);
                    afterPickupSpawn.SetActive(true);
                    beforePickupSpawn.SetActive(false);
                    butter.SetActive(false);
                    break;
                case "Plate":
                    Debug.Log("Successful");
                    Success();                  
                    break;
            }
        
        
        
    }
    void CrashSequence()
    {
        
        crashedVfx.Play();
        fire.Play();
        audioSource.PlayOneShot(crashedSFX);
        Invoke("ReloadLevel", delay);
        
        
    }
    void PortalSequence()
    {
        
        portalHit.Play();
        audioSource.PlayOneShot(portalSFX);
        Invoke("ReloadLevel", delay);
    }

    void Success()
    {
        
        successVfx.Play();
        
        if(!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(successSfx);
        }
        else
        {
            return;
        }
        Invoke("WinHandler", delay);

    }

    void ReloadLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currentLevel + 1;
        if(nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 1;
        }
        SceneManager.LoadScene(nextLevel);
    }
    
    void WinHandler()
    {
        winHandler.WinProcess();
    }

    void Quit()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
