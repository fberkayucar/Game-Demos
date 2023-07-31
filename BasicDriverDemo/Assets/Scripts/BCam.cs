using UnityEngine;
using UnityEngine.InputSystem;
public class Example : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(4, 5, 6);
    private void Start()
    {

    }

    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}