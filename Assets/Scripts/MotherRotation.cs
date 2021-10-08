using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherRotation : MonoBehaviour
{

    public float rotation;
    public float distancia;
    public float ppunto;
    private float currentTime = 0;
    public GameObject player;
    public float timer = 0;
    public float random_num;
    public Material rojo;
    public GameObject gameover;
    public float clock;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1, 3);
        clock = Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ppunto = Vector3.Dot(transform.right.normalized, player.transform.right.normalized);
        distancia = Vector3.Distance(player.transform.position, transform.position);

        if(distancia<=6)
        {
            currentTime += Time.deltaTime;
        }
        if(currentTime>=timer)
        {
            random_num = Random.Range(-10, 45);
            transform.Rotate(0, random_num, 0);
            currentTime = 0;
            timer = Random.Range(1, 3);
            
        }
        if(distancia<=3&&ppunto<-0.9f)
        {
            player.GetComponent<Renderer>().material = rojo;
            gameover.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
}
