using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public Transform target;
    public float control;
    public Vector3 Distance;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        control = target.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (control <= target.position.y)
        {
            transform.position = new Vector3(target.position.x, target.position.y, target.position.z) + Distance;
        }
    }
}
