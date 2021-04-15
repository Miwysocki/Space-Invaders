using UnityEngine;

public class Normal : Difficulty
{
    private readonly float DMG = 2;
    private readonly float HP = 2;
    private readonly float MS = 1.5f;



    public int ScaleDMG(int value)
    {
        return Mathf.RoundToInt(value * DMG);
    }

    public int ScaleHP(int value)
    {
        return Mathf.RoundToInt(value * HP);
    }

    public int ScaleMS(int value)
    {
        return Mathf.RoundToInt(value * MS);
    }
}
