using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] private int[] freeDays;  
    private string[] summerMonths = new string[3] {"June", "July", "August" };
    
    void Start()
    {
        print("SEICHAS " + summerMonths[0]);
        print("Free days " + freeDays[0] + freeDays[1]);
    }

    
    void Update()
    {
        
    }
}