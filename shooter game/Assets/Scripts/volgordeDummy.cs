using System.Collections;
using UnityEngine;

public class volgordeDummy : MonoBehaviour
{
    public bool inputTarget1;
    public bool inputTarget2;
    public bool inputTarget3;
    public GameObject ItSelf;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Opnieuw()
    {
        Target1.GetComponent<TargetCollide>().Hit = false;
        Target2.GetComponent<TargetCollide>().Hit = false;
        Target3.GetComponent<TargetCollide>().Hit = false;
        inputTarget1 = false;
        inputTarget2 = false;
        inputTarget3 = false;
    }
    void FixedUpdate()
    {
        if (Target1.GetComponent<TargetCollide>().Hit == true)
        {
            Debug.Log("een");
            ItSelf.gameObject.GetComponent<targetVolgorde>().inputTarget1 = true; // zet 1 aan

            if (inputTarget1 == false && inputTarget2 == false && inputTarget3 == false)
            {
                if (Target2.GetComponent<TargetCollide>().Hit == true || Target3.GetComponent<TargetCollide>().Hit == true)
                {
                    Debug.Log("11111");
                    Opnieuw();
                }
            }
        }

        if (Target2.GetComponent<TargetCollide>().Hit == true)
        {
            Debug.Log("twee");
            if (inputTarget1 == true)
            {
                ItSelf.gameObject.GetComponent<targetVolgorde>().inputTarget2 = true; //zet 2 aan
                if (inputTarget1 == false && inputTarget2 == false && inputTarget3 == false)
                {
                    if (Target1.GetComponent<TargetCollide>().Hit == true || Target3.GetComponent<TargetCollide>().Hit == true)
                    {
                        Debug.Log("22222");
                        Opnieuw();
                    }
                }
            }
        }

        if (Target3.GetComponent<TargetCollide>().Hit == true)
        {
            Debug.Log("drie");
            if (inputTarget1 == true && inputTarget2 == true)
            {
                ItSelf.gameObject.GetComponent<targetVolgorde>().inputTarget3 = true; //zet 3 aan
                if (inputTarget1 == false && inputTarget2 == false && inputTarget3 == false)
                {
                    if (Target1.GetComponent<TargetCollide>().Hit == true || Target2.GetComponent<TargetCollide>().Hit == true)
                    {
                        Debug.Log("helloooo");
                        Opnieuw();
                    }
                }
            }
        }
    }
}