using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //[SerializeField] private int[] freeDays;  
    //private string[] summerMonths = new string[3] {"June", "July", "August" };
    //private string[] month = new string[12]; //massiv dla 
    private string[] films = new string[5] { "Mad Max 2", "Kill Bill", "Lion King", "WALLE", "Forsage 1-9" };
    private string filmsList = "";
    void Start()
    {
        //print("SEICHAS " + summerMonths[0]);
        //print("Free days " + freeDays[0] + freeDays[1]);
        //for(int i = 0; i < films.Length; i++)
        // print(films[i]);

        //foreach (string film in films)
        //{
        //    print(film);
        //}
        ////PrintArray(films);
        foreach (string film in films)
        {
            filmsList = filmsList + " , " + film;
            if (film == films[4])
            {
                filmsList = filmsList + "!";
            }
        }
            print(filmsList);


            //if ("WALLE" != film)
            //{
            //    print(film);

            //}

        }
        //private void PrintArray(string[] array)
        //{
        //    foreach (string film in array)
        //    {
        //        print(film);
        //    }
        //}

        void Update()
        {

        }
    }