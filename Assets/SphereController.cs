using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    static int loseCondition = 5;
    static int winCondition = 11;
    private int bounceCount = 0;
    Rigidbody rgb;
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        rgb.AddForce(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 7.0f), Random.Range(-3.0f, 3.0f), ForceMode.Impulse);
    }
    void checkLose () {
        if(loseCondition < 1) {
            print("You lose!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(tr.position.y < -5) {
            Destroy(gameObject);
            loseCondition -= 1;
            checkLose();
        }
    }
    void OnCollisionEnter(Collision obj) {
        if(obj.gameObject.tag == "Plane") {
            bounceCount += 1;
            //print(gameObject.name + ", " + bounceCount);
            if(bounceCount > 4) {
                Destroy(gameObject);
                loseCondition -= 1;
                //print(loseCondition + ", "+ gameObject.name);
                checkLose();
            }       
        }
    }
    void OnMouseDown () {
        Destroy(gameObject);
        winCondition -= 1;
        print("Сфер осталось - " + winCondition);
        if(winCondition < 1) {
            print("You win!");
        } 
    }
}
