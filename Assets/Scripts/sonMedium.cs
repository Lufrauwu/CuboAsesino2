using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonMedium : MonoBehaviour
{
    // Start is called before the first frame update
    public float distanciaSon;
    public float ppuntoSon;
    public GameObject sphereSon;
    public GameObject cube;
    public float timer;
    public Material amarillo;
    public Material rojo;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distanciaSon = Vector3.Distance(cube.transform.position, transform.position);
        ppuntoSon = Vector3.Dot(transform.right.normalized, cube.transform.right.normalized);

        if (distanciaSon < 1.5f && ppuntoSon < -0.9f)
        {


            timer += Time.deltaTime;
            if (timer >= 2)
            {
                sphereSon.GetComponent<Renderer>().material = amarillo;
                if(timer>=4)
                {
                    sphereSon.GetComponent<Renderer>().material = rojo;
                    if(timer>=5)
                    {
                        sphereSon.SetActive(false);
                    }
                }
            }
        }
    }
}
