using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*SceneManager.LoadScene("FinalScene");*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnCollisionEnter(Collision other)
    {
        

            SceneManager.LoadScene("FinalScene");

        
    }
}
