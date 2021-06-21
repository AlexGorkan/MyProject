using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHW : MonoBehaviour
{
    [SerializeField] private string[] streets = {"Соборная", "Рабочая", "Лазурная", "Чкалова", "Адмиральская" };


    void Start()
    {
        foreach (string cityStreets in streets)
        {
            print("Улица: " + cityStreets);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
