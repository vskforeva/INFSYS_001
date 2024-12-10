using System;
using System.Collections.Generic;

namespace INFSYS_001
{
    public class Simplex
    {
            private double[,] table; // Симплекс таблица
            private int m, n;
            private List<int> basis; // Список базисных переменных
            private List<double[,]> iterations; // Список для хранения всех итераций

            public Simplex(double[,] source)
            {
                m = source.GetLength(0);
                n = source.GetLength(1);
                table = new double[m, n + m - 1];
                basis = new List<int>();
                iterations = new List<double[,]>(); // Инициализация списка итераций

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (j < n)
                            table[i, j] = source[i, j];
                        else
                            table[i, j] = 0;
                    }
                    // Выставляем коэффициент 1 перед базисной переменной в строке
                    if ((n + i) < table.GetLength(1))
                    {
                        table[i, n + i] = 1;
                        basis.Add(n + i);
                    }
                }

                n = table.GetLength(1);
            }

            // Метод для расчета симплекс-таблицы
            public double[,] Calculate(double[] result)
            {
                int mainCol, mainRow; // Ведущие столбец и строка

                while (!IsItEnd())
                {
                    mainCol = findMainCol();
                    mainRow = findMainRow(mainCol);
                    basis[mainRow] = mainCol;

                    double[,] new_table = new double[m, n];

                    for (int j = 0; j < n; j++)
                        new_table[mainRow, j] = table[mainRow, j] / table[mainRow, mainCol];

                    for (int i = 0; i < m; i++)
                    {
                        if (i == mainRow)
                            continue;

                        for (int j = 0; j < n; j++)
                            new_table[i, j] = table[i, j] - table[i, mainCol] * new_table[mainRow, j];
                    }

                    // Логируем текущее состояние симплекс-таблицы
                    iterations.Add((double[,])new_table.Clone()); // Сохраняем текущую таблицу

                    table = new_table;
                }

                // Заносим в result найденные значения X
                for (int i = 0; i < result.Length; i++)
                {
                    int k = basis.IndexOf(i + 1);
                    if (k != -1)
                        result[i] = table[k, 0];
                    else
                        result[i] = 0;
                }

                return table;
            }

            // Свойство для доступа к итерациям
            public List<double[,]> Iterations => iterations;

            private bool IsItEnd()
            {
                bool flag = true;

                for (int j = 1; j < n; j++)
                {
                    if (table[m - 1, j] < 0)
                    {
                        flag = false;
                        break;
                    }
                }

                return flag;
            }

            private int findMainCol()
            {
                int mainCol = 1;

                for (int j = 2; j < n; j++)
                    if (table[m - 1, j] < table[m - 1, mainCol])
                        mainCol = j;

                return mainCol;
            }

            private int findMainRow(int mainCol)
            {
                int mainRow = -1;

                for (int i = 0; i < m - 1; i++)
                {
                    if (table[i, mainCol] > 0)
                    {
                        if (mainRow == -1 ||
                            (table[i, 0] / table[i, mainCol]) < (table[mainRow, 0] / table[mainRow, mainCol]))
                        {
                            mainRow = i;
                        }
                    }
                }

                return mainRow;
            }
        }
    }
