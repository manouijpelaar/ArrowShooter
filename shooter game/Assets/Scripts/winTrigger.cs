using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject completeLevelScreen;
    public TargetVolgorde targetManager;

    void OnTriggerEnter(Collider win)
    {   // when player collides with winscene, level complete
        if (win.gameObject.tag == "player")
        {
            win.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            completeLevelScreen.SetActive(true);
            targetManager.gate.SetBool("IsDoorOpen", false);
            targetManager.doorIsOpen = false;
            Debug.Log("You Win!");
        }
    }
}
