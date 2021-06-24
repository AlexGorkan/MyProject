using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLists : MonoBehaviour
{
    [SerializeField] private List<GameObject> balls;
    [SerializeField] private List<GameObject> balls1 = new List<GameObject>();

    void Start()
    {
        //balls1.Add(gameObject.transform.GetChild(0).gameObject); // mozhno udalit transform
        //balls1.Add(transform.GetChild(0).gameObject); 
        for (int i = 0; i < transform.childCount; i++)
        {
            balls1.Add(transform.GetChild(i).gameObject);
        }


    }

   
    void Update()
    {
        
    }
}
