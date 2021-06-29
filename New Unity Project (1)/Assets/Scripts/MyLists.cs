using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{
    //[SerializeField] private List<GameObject> balls;
    [SerializeField] private List<GameObject> balls1 = new List<GameObject>();
    [SerializeField] private Vector3 ballsStartPosition = new Vector3(0f, 0f, 0f);
    [SerializeField] private float speed;
    private int count = 0;

    void Start()
    {
        //balls1.Add(gameObject.transform.GetChild(0).gameObject); // mozhno udalit transform
        //balls1.Add(transform.GetChild(0).gameObject); 
        for (int i = 0; i < transform.childCount; i++)
        {
            balls1.Add(transform.GetChild(i).gameObject);
            //transform.gameObject.transform.position = ballsStartPosition;
            ballsStartPosition.x = 0;
            gameObject.transform.Translate(Vector3.right);
            if (gameObject.transform.position.y >= (ballsStartPosition.y + 2))
            {
                transform.position = Vector3.right;
                transform.gameObject.transform.Translate(new Vector3(0f, ballsStartPosition.y, 0f));
                count++;
            }
            

        }
        

    }

   
    void Update()
    {
        
    }
}
