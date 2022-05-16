using System.Collections;
using UnityEngine;


    public static class Helpers 
    {
        public static int RandomNumberInt(int min, int max)
        {
            int randomNumber = Random.Range(min, max);
            return randomNumber;
        }

       
    }
