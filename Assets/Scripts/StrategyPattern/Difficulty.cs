using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Difficulty 
{
    int ScaleMS(int value);
    int ScaleHP(int value);
    int ScaleDMG(int value);
}
