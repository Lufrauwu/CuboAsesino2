using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphereSon;
    public float ppuntoSon;
    public float distanciaSon;
    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanciaSon = Vector3.Distance(cube.transform.position, transform.position);
        ppuntoSon = Vector3.Dot(transform.right.normalized, cube.transform.right.normalized);

        if(distanciaSon<1.5f&&ppuntoSon<-0.9f)
        {

            sphereSon.GetComponent<Renderer>().material.color = Color.red;
            timer += Time.deltaTime;
            if(timer>=1)
            {
                sphereSon.SetActive(false);
            }
            
        }

       /* if(transform.tag == "2seg")
        {

            GetComponent<Renderer>().material.color = Color.red;
        }*/


        

    }
}
