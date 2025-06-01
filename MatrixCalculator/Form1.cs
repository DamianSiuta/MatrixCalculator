using System;
using System.Text;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Read matrices from text inputs
                double[,] matrixA = ReadMatrix(txtMatrix1.Text);
                double[,] matrixB = ReadMatrix(txtMatrix2.Text);

                // Debugging - check matrix dimensions before calculation
                MessageBox.Show($"Matrix A: {matrixA.GetLength(0)}x{matrixA.GetLength(1)}");
                MessageBox.Show($"Matrix B: {matrixB.GetLength(0)}x{matrixB.GetLength(1)}");

                // Perform the selected operation
                if (ComboOperations.SelectedItem.ToString() == "Multiplication")
                    lblResult.Text = FormatMatrix(MultiplyMatrices(matrixA, matrixB));
                else if (ComboOperations.SelectedItem.ToString() == "Determinant")
                    lblResult.Text = $"Determinant: {Determinant(matrixA, matrixA.GetLength(0))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convert text input to a matrix (2D array)
        private double[,] ReadMatrix(string input)
        {
            string[] rows = input.Split(';');
            int rowCount = rows.Length;
            int colCount = rows[0].Split(' ').Length;

            double[,] matrix = new double[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] cols = rows[i].Trim().Split(' ');
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = Convert.ToDouble(cols[j]);
                }
            }
            return matrix;
        }

        // Function for matrix multiplication
        private double[,] MultiplyMatrices(double[,] A, double[,] B)
        {
            int rowsA = A.GetLength(0), colsA = A.GetLength(1);
            int rowsB = B.GetLength(0), colsB = B.GetLength(1);

            if (colsA != rowsB)
                throw new Exception("Cannot multiply: dimensions do not match!");

            double[,] result = new double[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return result;
        }

        // Recursive function to calculate the determinant
        private double Determinant(double[,] matrix, int size)
        {
            if (size == 1) return matrix[0, 0];

            double det = 0;
            for (int i = 0; i < size; i++)
            {
                double[,] subMatrix = GetSubMatrix(matrix, size, i);
                det += (i % 2 == 0 ? 1 : -1) * matrix[0, i] * Determinant(subMatrix, size - 1);
            }

            return det;
        }

        // Function for extracting submatrices (used for determinant calculation)
        private double[,] GetSubMatrix(double[,] matrix, int size, int column)
        {
            double[,] subMatrix = new double[size - 1, size - 1];

            for (int i = 1; i < size; i++)
            {
                int subCol = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == column) continue;
                    subMatrix[i - 1, subCol++] = matrix[i, j];
                }
            }
            return subMatrix;
        }

        // Function for formatting matrix output as text
        private string FormatMatrix(double[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j]).Append(" ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}