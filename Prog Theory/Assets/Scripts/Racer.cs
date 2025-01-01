using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : MonoBehaviour
{
    public string name; // animal & racer names
    public string size = "S"; // S, M, or L
    public string speedRange = "F"; // F, FF, or FFF
    public float speedValue = 3.0f; // 1 through 5 x speedRange length
    public string color = "black"; // black, white, red, grey, or brown
    public Color animalColor = new Color(0, 0, 0, 1); // (0,0,0,1), (1,1,1,1), (1,0,0,1),(0.5, 0.5, 0.5, 1), or (0.58,0.29,0,1)
    public float speedEnhancer =3.0f; // initialize 3 for player & 0 for others
}

public class Cat : Racer //INHERITANCE
{
    
}

public class Dog : Racer //INHERITANCE
{
    public void Reset() //POLYMORPHISM
    {
        size = "M";
        speedRange = "FF";
        speedValue = speedRange.Length;
    }
}

public class Horse : Racer //INHERITANCE
{
    public void Reset() //POLOYMORPHISM
    {
        size = "L";
        speedRange = "FFF";
        speedValue = speedRange.Length;
    }
}