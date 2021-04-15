using UnityEngine;

public class Hard : Difficulty
{
    private readonly float DMG = 4;
    private readonly float HP = 3;
    private readonly float MS = 2;



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
