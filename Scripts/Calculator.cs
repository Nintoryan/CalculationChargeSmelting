using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationChargeSmelting
{
    class Calculator
    {
        public List<(Material, int)> CalculateShicht(List<Material> shichtMaterials, Material targetMat)
        {
            //Добавить условие, что shichtMaterials.Count-1 == targetMat.elemets.count,
            //если их больше, попробовать вычисление с каждым набором, 
            //если shichtMaterials.Count-1 < targetMat.elemets.count,то попытаться найти решения для всех уменьшеных систем уравнений
            //Добавить проверку, что если в шихте нет элемента, который содержится в targetMat, то посчитать нельзя
            foreach (var sm in shichtMaterials)
            {
                sm.Modificate(targetMat.Compound.Keys.ToList());
            }
            var A = new int[targetMat.Compound.Count+1];
            A[0] = 100;
            for (int i = 1; i < targetMat.Compound.Count + 1; i++)
            {
                A[i] = targetMat.Compound.Values.ToArray()[i - 1] * 100 / (100 /*- element.Ugar*/);
            }

            var equastions = new int[shichtMaterials.Count][];
            for(int i = 0; i<shichtMaterials.Count;i++)
            {
                equastions[i] = new int[shichtMaterials.Count + 1];
                for(int j = 0; j < shichtMaterials.Count; j++)
                {
                    if (i == 0)
                    {
                        equastions[i][j] = 1;
                    }
                    else
                    {
                        equastions[i][j] = shichtMaterials[i].Compound.Values.ToArray()[j];
                    }
                    
                }
                equastions[i][shichtMaterials.Count]=A[i];
            }
            var s = "";
            for (int i = 0; i < equastions.Length; i++)
            {
                for (int j = 0; j < equastions[i].Length; j++)
                {
                    s += $"{equastions[i][j]} ";
                }
                s += "\n";
            }
            MessageBox.Show(s,
                        "Матрица",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            var masses = CramerSolver.SolveCramer(equastions);
           
            var result = new List<(Material, int)>();
            for (int i = 0; i < masses.Length; i++)
            {
                result.Add((shichtMaterials[i], masses[i]));
            }
            return result;
        }
    }
    public class CramerSolver
    {
        public static void ExampleCramer()
        {
            var equations = new[] {
            new [] { 1, 1, 1,  100 },
            new [] { 3,  2,  2, 100},
            new [] { 1,  3,  3, 100},
        };
            var solution = SolveCramer(equations);

        }
        public static int[] SolveCramer(int[][] equations)
        {
            int size = equations.Length;
            if (equations.Any(eq => eq.Length != size + 1)) throw new ArgumentException($"Each equation must have {size + 1} terms.");
            int[,] matrix = new int[size, size];
            int[] column = new int[size];
            for (int r = 0; r < size; r++)
            {
                column[r] = equations[r][size];
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = equations[r][c];
                }
            }
            return Solve(new SubMatrix(matrix, column));
        }
        private static int[] Solve(SubMatrix matrix)
        {
            int det = matrix.Det();
            if (det == 0) throw new ArgumentException("The determinant is zero.");

            int[] answer = new int[matrix.Size];
            for (int i = 0; i < matrix.Size; i++)
            {
                matrix.ColumnIndex = i;
                answer[i] = matrix.Det() / det;
            }
            return answer;
        }
    }

    public class SubMatrix
    {
        private int[,] source;
        private SubMatrix prev;
        private int[] replaceColumn;

        public SubMatrix(int[,] source, int[] replaceColumn)
        {
            this.source = source;
            this.replaceColumn = replaceColumn;
            this.prev = null;
            this.ColumnIndex = -1;
            Size = replaceColumn.Length;
        }

        private SubMatrix(SubMatrix prev, int deletedColumnIndex = -1)
        {
            this.source = null;
            this.prev = prev;
            this.ColumnIndex = deletedColumnIndex;
            Size = prev.Size - 1;
        }

        public int ColumnIndex { get; set; }
        public int Size { get; }

        public int this[int row, int column]
        {
            get
            {
                if (source != null) return column == ColumnIndex ? replaceColumn[row] : source[row, column];
                return prev[row + 1, column < ColumnIndex ? column : column + 1];
            }
        }

        public int Det()
        {
            if (Size == 1) return this[0, 0];
            if (Size == 2) return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];
            SubMatrix m = new SubMatrix(this);
            int det = 0;
            int sign = 1;
            for (int c = 0; c < Size; c++)
            {
                m.ColumnIndex = c;
                int d = m.Det();
                det += this[0, c] * d * sign;
                sign = -sign;
            }
            return det;
        }
    }
}
