using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //[SerializeField] private int[] freeDays;  
    //private string[] summerMonths = new string[3] {"June", "July", "August" };
    //private string[] month = new string[12]; //massiv dla 

    private string[] films = new string[5] { "Mad Max 2", "Kill Bill", "Lion King", "WALLE", "Forsage 1-9" };
    void Start()
    {
        //print("SEICHAS " + summerMonths[0]);
        //print("Free days " + freeDays[0] + freeDays[1]);
        for(int i = 0; i < 5; i++)
        print(films[i]);
    }

    
    void Update()
    {
        
    }
}