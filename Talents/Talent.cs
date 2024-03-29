using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Talent
{
    public long id;
    public string name;
    public Mastery mastery;
    public int maxRank;
    public abstract string GetIconFileName(CharacterMB characterMB);
}
