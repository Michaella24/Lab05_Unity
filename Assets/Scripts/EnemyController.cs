using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        
    }
    //hit method
    public void GotHit() {
        animator.SetTrigger("GotHit"); //set the trigger if the enemy got hit
        hitParticles.Play(); // activate the effect
        audioSource.Play(); //active the sound effect
        GameManager.Instance.IncrementScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
