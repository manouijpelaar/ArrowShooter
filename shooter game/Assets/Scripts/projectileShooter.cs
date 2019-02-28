using System.Collections;
using UnityEngine;

public class projectileShooter : MonoBehaviour { 

    public GameObject arrowPrefab;

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nb = (GameObject)Instantiate(arrowPrefab, this.transform.position, this.transform.rotation);
            nb.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 500);
        }
    }
}
