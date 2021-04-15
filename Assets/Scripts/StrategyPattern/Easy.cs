using UnityEngine;

public class Easy : Difficulty
{
    private readonly float DMG = 1;
    private readonly float HP = 1;
    private readonly float MS = 1;



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
