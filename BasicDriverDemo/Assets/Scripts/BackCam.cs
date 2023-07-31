using UnityEngine;
using UnityEngine.InputSystem;
public class BackCam : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    private void Start()
    {

    }

    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}