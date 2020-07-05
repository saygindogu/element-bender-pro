using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject fireBending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMouseInput();
        
    }

    private void ProcessMouseInput(){
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed primary button.");
            fireBending.SetActive(true);
 
            Instantiate(fireBending, transform.position, Quaternion.identity);
        }
    }
 
     float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
