using System.Collections;
using UnityEngine;

public class camMouseLook : MonoBehaviour {

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothness = 2.0f;

    GameObject player;

    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    void Update()
    {
        var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothness, sensitivity * smoothness));
        smoothV.x = Mathf.Lerp(smoothV.x, mouseDelta.x, 1f / smoothness);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseDelta.y, 1f / smoothness);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
