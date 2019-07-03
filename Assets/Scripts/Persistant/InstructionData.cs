using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class InstructionData
{
    public string name; //name of instruction set

    public Instructions[] instructions; //how many instruction you want

    public static implicit operator InstructionData(Instructions v)
    {
        throw new NotImplementedException();
    }
}
