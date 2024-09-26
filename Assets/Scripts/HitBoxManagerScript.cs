using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider[] attackColliders;
    void Start()
    {
        foreach(Collider attackCollider in attackColliders) {
            attackCollider.enabled = false; //disable all the colliders at the start 
        }
    }
    //enable the colliders
    public void EnableHitBox() {
        foreach (Collider attackCollider in attackColliders) {
            attackCollider.enabled = true;
        }
    }

    //disable the colliders 
    public void DisableHitBox() {
        foreach (Collider attackCollider in attackColliders) {
            attackCollider.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
