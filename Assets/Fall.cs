using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Ball"){
            SceneManager.LoadScene("Ball_and_Cube");
            // var respawn = GameObject.FindWithTag("Respawn");
            // other.gameObject.transform.position = respawn.transform.position;
        }
    }
}
