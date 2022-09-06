using UnityEngine;
using System.Collections.Generic;

public class SparseMatrix
{

    public struct Triplet {
        int i;
        int j;
        float value;

        public Triplet(int i, int j, float value) {
            this.i = i;
            this.j = j;
            this.value = value;
        }
    }

    public readonly int rows;
    public readonly int cols;
    public readonly List<Triplet> triplets;

    public SparseMatrix(int rows, int cols) {
        this.rows = rows;
        this.cols = cols;
        this.triplets = new List<Triplet>();
    }


}