using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHW : MonoBehaviour
{
    [SerializeField] private string[] streets = {"��������", "�������", "��������", "�������", "������������" };


    void Start()
    {
        foreach (string cityStreets in streets)
        {
            print("�����: " + cityStreets);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
