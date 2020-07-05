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
            

            //Get the Screen positions of the object
            Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
            
            //Get the Screen position of the mouse
            Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
            
            //Get the angle between the points
            float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

            print(angle);
    
            //Ta Daaa
            Quaternion rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
            Instantiate(fireBending, transform.position, rotation);
        }
    }
 
     float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
