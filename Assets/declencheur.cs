using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declencheur : MonoBehaviour
{
    int BoxNumber = 0;
    private void OnTriggerEnter(Collider other){
        BoxNumber++;
        Debug.Log("Declenché : "+BoxNumber);
        
    }

    private void OnTriggerExit(Collider other){
        if(BoxNumber > 0){
            BoxNumber--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
