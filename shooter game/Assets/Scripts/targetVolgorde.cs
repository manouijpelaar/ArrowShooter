using System.Collections;
using UnityEngine;

public class targetVolgorde : MonoBehaviour
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
    {   // target 1 aan de beurt en reset staat uit, reset voor 2 en 3 aan
        Target1.GetComponent<TargetCollide>().Volgorde = true;
        Target1.GetComponent<TargetCollide>().Reset = false;
        Target2.GetComponent<TargetCollide>().Reset = true;
        Target3.GetComponent<TargetCollide>().Reset = true;

        if (Target2.GetComponent<TargetCollide>().Hit == true && Target2.GetComponent<TargetCollide>().Volgorde == false || Target3.GetComponent<TargetCollide>().Hit == true && Target3.GetComponent<TargetCollide>().Volgorde == false)
        {
            Restart();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // als target 1 is geraakt, is target 2 aan de beurt en reset voor target 1 en 3 aan
        if (Target1.GetComponent<TargetCollide>().Hit == true)
        {
            Target2.GetComponent<TargetCollide>().Volgorde = true;
            Target1.GetComponent<TargetCollide>().Hit = false; // zorgt ervoor dat er niet ongewild een restart plaatsvind
            Target1.GetComponent<TargetCollide>().Volgorde = false;
            Target1.GetComponent<TargetCollide>().Reset = true;
            Target2.GetComponent<TargetCollide>().Reset = false;

            if (Target1.GetComponent<TargetCollide>().Hit == true && Target1.GetComponent<TargetCollide>().Volgorde == false || Target3.GetComponent<TargetCollide>().Hit == true && Target3.GetComponent<TargetCollide>().Volgorde == false)
            {
                Restart();
            }
        }

        // als target 1 en 2 zijn geraakt, is target 3 aan de beurt en reset voor target 1 en 2 aan
        //Target1.GetComponent<TargetCollide>().Hit == true
        if (Target2.GetComponent<TargetCollide>().Hit == true)
        {
            Target3.GetComponent<TargetCollide>().Volgorde = true;
            Target2.GetComponent<TargetCollide>().Hit = false; // zorgt ervoor dat er niet ongewild een restart plaatsvind
            Target2.GetComponent<TargetCollide>().Volgorde = false;
            Target2.GetComponent<TargetCollide>().Reset = true;
            Target3.GetComponent<TargetCollide>().Reset = false;

            if (Target1.GetComponent<TargetCollide>().Hit == true && Target1.GetComponent<TargetCollide>().Volgorde == false || Target2.GetComponent<TargetCollide>().Hit == true && Target2.GetComponent<TargetCollide>().Volgorde == false)
            {
                Restart();
            }
        }

    }
    void Restart()
    {
        Target1.GetComponent<TargetCollide>().Hit = false;
        Target2.GetComponent<TargetCollide>().Hit = false;
        Target3.GetComponent<TargetCollide>().Hit = false;

        Target1.GetComponent<TargetCollide>().Volgorde = true;
        Target2.GetComponent<TargetCollide>().Volgorde = false;
        Target3.GetComponent<TargetCollide>().Volgorde = false;

        Target1.GetComponent<TargetCollide>().Reset = false;
        Target2.GetComponent<TargetCollide>().Reset = true;
        Target3.GetComponent<TargetCollide>().Reset = true;
    }
}