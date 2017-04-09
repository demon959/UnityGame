using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct IntVextor2 {

    public int x, z;

    public IntVextor2(int x, int z) {
        this.x = x;
        this.z = z;
    }

    public static IntVextor2 operator + (IntVextor2 a, IntVextor2 b) {
        a.x += b.x;
        a.z += b.z;
        return a;
    }
}
