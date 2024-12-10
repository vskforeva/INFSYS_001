using System;
using System.Windows.Forms;

namespace INFSYS_001
{
    public class TestValues
    {
        public static void FillTestValues(NumericUpDown numericUpDown1, NumericUpDown numericUpDown2, Panel panel1, Panel panel2)
        {
            // Устанавливаем значения для NumericUpDown
            numericUpDown1.Value = 2; // Количество переменных
            numericUpDown2.Value = 4; // Количество ограничений

            // Заполнение panel1 с двумя TextBox для целевой функции
            string[] objectiveFunctionValues = { "6", "5" }; // Значения для целевой функции
            for (int i = 0; i < objectiveFunctionValues.Length; i++)
            {
                string textBoxName = $"textBox_{i}";
                TextBox textBox;

                if (panel1.Controls.ContainsKey(textBoxName))
                {
                    textBox = (TextBox)panel1.Controls[textBoxName];
                }
                else
                {
                    textBox = new TextBox();
                    textBox.Name = textBoxName;
                    textBox.Location = new System.Drawing.Point(10 + (i * 70), 10);
                    panel1.Controls.Add(textBox);
                }

                // Устанавливаем значения для TextBox
                textBox.Text = objectiveFunctionValues[i]; // Значения для TextBox
            }

            // Заполнение panel2 с четырьмя строками по три TextBox в каждой для ограничений
            string[,] constraintsValues = {
                { "-3", "5", "25" },  // -3x1 + 5x2 ≤ 25
                { "-2", "5", "30" },  // -2x1 + 5x2 ≤ 30
                { "1", "0", "10" },   // x1 ≤ 10
                { "3", "-8", "6" }    // 3x1 - 8x2 ≤ 6
            };

            for (int i = 0; i < constraintsValues.GetLength(0); i++)
            {
                // Устанавливаем Y-координату для каждой строки
                int yOffset = i * 30 + 40; // Смещение по Y для каждой строки

                for (int j = 0; j < constraintsValues.GetLength(1); j++)
                {
                    string textBoxName = $"textBox_{j}_{i + 1}"; // Имя существующего TextBox

                    if (panel2.Controls.ContainsKey(textBoxName))
                    {
                        TextBox textBox = (TextBox)panel2.Controls[textBoxName];
                        // Устанавливаем значения для существующих TextBox
                        textBox.Text = constraintsValues[i, j]; // Значения для ограничения
                    }
                }

                // Заполнение полей для правой части ограничений с именами newTextField_n
                string newTextFieldName = $"newTextField_{i + 1}";

                if (panel2.Controls.ContainsKey(newTextFieldName))
                {
                    TextBox newTextField = (TextBox)panel2.Controls[newTextFieldName];
                    newTextField.Text = constraintsValues[i, constraintsValues.GetLength(1) - 1]; // Последний элемент как свободный член
                }
            }
        }
    }
}