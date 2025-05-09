using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private int score = 10;
    public float speed = 5.5f;

    [SerializeField] private int[] points = {10, 20, 30 };
    [SerializeField] private List<int> coins = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        coins.Add(5);
        coins.Add(5);


        /*
        for(int i = 0; i <300000; i++) {
            Debug.Log("Spawn monster");
        }

        SayHello();
        SayAnything("Good Morning!");
        */

        Debug.Log(points[0]);

    }
    void SayHello() {
        Debug.Log("Hello");
    }

    void SayAnything(string message) {
        Debug.Log("Let me tell you this: "+message);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (score > 20 &&)
        {
            Debug.Log("You win!");
        } else if (score > 500) {
            Debug.Log("You lose!");
        }
        else {
            Debug.Log("You didn't win yet!");
        }
        */
    }
}
