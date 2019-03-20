using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject completeLevelScreen;

    void OnTriggerEnter(Collider win)
    {   // when player collides with winscene, level complete
        if (win.gameObject.tag == "player")
        {
            win.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
            completeLevelScreen.SetActive(true);
            Debug.Log("You Win!");
        }
    }
}
