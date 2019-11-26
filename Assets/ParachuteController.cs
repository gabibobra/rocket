using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteController : MonoBehaviour

{
    public Rigidbody paraquedas;
    public Vector3 rot;
    public GameObject body;
    public bool check2;

    // Start is called before the first frame update
    void Start()
    {
        paraquedas = GetComponent<Rigidbody>();
        paraquedas.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        check2 = body.GetComponent<ControlaFoguete>().check;
        if (check2 == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                paraquedas.GetComponent<MeshRenderer>().enabled = true;
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(90f,0,0), 5f * Time.deltaTime);
                paraquedas.drag = 10f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,90f,0), 1f * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90f, 0), 1f * Time.deltaTime);
            }
        }
    }
}
