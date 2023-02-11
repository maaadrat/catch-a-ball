using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    public int bounceCount;
    Rigidbody rgb;
    // Start is called before the first frame update
    void Start()
    {
        bounceCount = 0;
        rgb = GetComponent<Rigidbody>();
        rgb.AddForce(0, -20, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // void OnCollisionEnter(Collision obj) {
    //     if (obj.gameObject.name == "Red Cube") {
    //         bounceCount += 1;
    //         print("Bad");
    //         print(bounceCount);
    //         if(bounceCount > 5) {
    //             Destroy(obj.gameObject);
    //         }
    //     } 
    // }
}
