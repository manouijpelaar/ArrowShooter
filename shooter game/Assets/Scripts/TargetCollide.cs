using System.Collections;
using UnityEngine;

public class TargetCollide : MonoBehaviour
{
    public bool Hit;
    public GameObject TinyFire;
    public TargetVolgorde targetManager;

    private ParticleSystem particleSystem;

    private void Start()
    {
        // manager die de volgorde regelt
        targetManager = FindObjectOfType<TargetVolgorde>();
        particleSystem = TinyFire.gameObject.GetComponentInChildren<ParticleSystem>();
        particleSystem.Stop();
    }

    void OnCollisionEnter(Collision col)
    {   // turns on kinematic if a target is hit
        if (col.gameObject.tag == "arrow")
        {
            col.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            if (targetManager.CheckTarget(this))
            {
                Hit = true;

                particleSystem.Play();
                ParticleSystem.EmissionModule em = particleSystem.emission;
                em.enabled = true;
                //targetManager.CheckTarget(this);
            }
            if (targetManager.CheckWin())
            {
                //open door
                Debug.Log("door opens");
                targetManager.gate.SetBool("IsDoorOpen", true);
                targetManager.doorIsOpen = true;
            }
            Debug.Log("i am a particle!");
        }
    }

    public void Reset()
    {
        Hit = false;
        particleSystem.Stop();
    }
}
