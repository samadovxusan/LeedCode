using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee
{
    public static class SpiralMatrix
    {
        public static int[][] GenerateMatrix(int n)
        {
            // Matritsani 0 lar bilan boshlash
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            int top = 0, bottom = n - 1, left = 0, right = n - 1;
            int value = 1;

            while (top <= bottom && left <= right)
            {
                // Yuqori qatorda to'ldirish
                for (int i = left; i <= right; i++)
                {
                    matrix[top][i] = value++;
                }
                top++;

                // O'ng ustunda to'ldirish
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = value++;
                }
                right--;

                // Pastki qatorda to'ldirish
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom][i] = value++;
                    }
                    bottom--;
                }

                // Chap ustunda to'ldirish
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i][left] = value++;
                    }
                    left++;
                }
            }

            return matrix;
        }
    }

}
