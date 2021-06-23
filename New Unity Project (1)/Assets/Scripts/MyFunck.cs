using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFunck : MonoBehaviour
{
    private float[] landSquares = new float[3] {0.12f, 0.5f, 0.024f};
    private float price = 100f;

    void Start()
    {
        

        //Divide(5f, 2f);
        //Divide(5, 2);
        //CheckAge(35, "Alexey");
        CountSquare(60f, 20f);
        CountSquare(100f, 50f);
        CountSquare(48f, 5f);


    }

    private void CountSquare(float width, float height)
    {
        float rez = (width * height / 100) / price;
        print(rez);
    }



    private void PrintWelcome()
    {
        print("Privet");
        print("Dobro pozhalovat");
    }

    private void Divide(float num1, float num2)
    {
        float rez = num1 / num2;
        print(rez);
    }

    private void Divide(int num1, int num2)
    {
        float rez = num1 / num2;
        print(rez);
    }

    private void CheckAge(int yourAge, string yourName)
    {
        if (yourAge >= 18)
        {
            print("Dobro pozhalovat" + yourName);
        }


        else
        {
            print("Zhdite" + yourName + (18 - yourAge));
        }

    }
}
