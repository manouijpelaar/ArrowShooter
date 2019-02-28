using System.Collections;
using UnityEngine;

public class TargetCollide : MonoBehaviour
{
    public GameObject targetVolgorde;
    public bool Hit;
    public bool Volgorde;
    public bool Reset;
    public GameObject Itself;

    void OnCollisionEnter(Collision col)
    {
        if (Volgorde == true)
        {
            if (col.gameObject.name == "Arrow(Clone)")
            {
                Itself.GetComponent<TargetCollide>().Hit = true;
                col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
