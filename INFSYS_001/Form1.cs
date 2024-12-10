using System;
using System.Text;
using System.Windows.Forms;


namespace INFSYS_001
{
    public partial class Form1 : Form
    {
        private int currentRowCount = 0;
        private int textBoxCount = 1; // Изначальное количество TextBox
        private const int textBoxWidth = 60; // Ширина TextBox
        private const int textBoxHeight = 20; // Высота TextBox
        private const int textBoxSpacing = 45; // Расстояние между TextBox
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown2.Minimum = 1; // Set minimum value
            numericUpDown2.Value = 1; // Set default value
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged; // Subscribe 

            // Устанавливаем AutoScroll для panel2
            panel2.AutoScroll = true;

            // Создаем первую строку с одним TextBox при запуске формы
            CreateTextBoxRow(1);
            UpdatePanel2Rows(1); // Инициализация panel2 с одной строкой
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int newCount = (int)numericUpDown1.Value;
            CreateTextBoxRow(newCount);
            CreateTextBoxRowForPanel2(newCount);
            UpdatePanel2Rows((int)numericUpDown2.Value); // Обновляем panel2 с текущим количеством строк
        }

        private void CreateTextBoxRow(int count)
        {
            panel1.Controls.Clear(); // Очищаем groupBox2 перед добавлением новых элементов

            // Создаем TextBox
            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = $"textBox_{i}";
                textBox.Location = new Point(textBoxSpacing + (textBoxWidth + textBoxSpacing) * i, 0);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                panel1.Controls.Add(textBox);

                // Создаем Label с номером и символом
                Label label = new Label();
                label.Width = 45;
                label.Text = $"x{i + 1}";
                if (i == count - 1)
                {
                    label.Text += " →";
                }
                else
                {
                    label.Text += " +";
                }
                label.Location = new Point(textBox.Right, textBox.Top);
                panel1.Controls.Add(label);
            }

            textBoxCount = count;
        }

        private void CreateTextBoxRowForPanel2(int count)
        {
            int currentTop = panel2.Controls.Count > 0
        ? panel2.Controls[panel2.Controls.Count - 1].Bottom + textBoxSpacing
        : 0; // Устанавливаем начальную позицию для первого элемента

            // Увеличиваем счетчик строк
            currentRowCount++;

            // Создаем Label для номера строки
            Label rowNumberLabel = new Label();
            rowNumberLabel.Text = $"{currentRowCount})"; // Номер строки
            rowNumberLabel.Width = 20; // Ширина для номера строки
            rowNumberLabel.Location = new Point(textBoxSpacing - 25, currentTop); // Позиция перед TextBox'ами
            panel2.Controls.Add(rowNumberLabel);

            for (int i = 0; i < count; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = $"textBox_{i}_{currentRowCount}"; // Уникальное имя для каждого TextBox
                textBox.Location = new Point(textBoxSpacing + (textBoxWidth + textBoxSpacing) * i, currentTop);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                panel2.Controls.Add(textBox);

                Label label = new Label();
                label.Width = 45;
                label.Text = $"x{i + 1}" + (i == count - 1 ? "" : " +");
                label.Location = new Point(textBox.Right, currentTop);
                panel2.Controls.Add(label);
            }

            ComboBox comboBox = new ComboBox();
            comboBox.Name = $"comboBox_{currentRowCount}"; // Уникальное имя для каждого ComboBox
            comboBox.Items.AddRange(new string[] { "≤", "=", "≥" });
            comboBox.SelectedIndex = 0;
            comboBox.Location = new Point(textBoxSpacing + (textBoxWidth + textBoxSpacing) * count, currentTop);
            comboBox.Width = 60;
            comboBox.Size = new Size(textBoxWidth, textBoxHeight);
            panel2.Controls.Add(comboBox);

            TextBox newTextField = new TextBox();
            newTextField.Name = $"newTextField_{currentRowCount}"; // Уникальное имя для нового TextField
            newTextField.Location = new Point(comboBox.Right + textBoxSpacing, currentTop);
            newTextField.Size = new Size(textBoxWidth, textBoxHeight);
            panel2.Controls.Add(newTextField);

            // Обновляем label5 с текущим количеством строк
            UpdateRowCountLabel();
        }

        private void UpdateRowCountLabel()
        {
            label5.Text = $"Количество строк: {currentRowCount}"; // Обновляем текст label5
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int rowCount = (int)numericUpDown2.Value;
            UpdatePanel2Rows(rowCount);
        }

        private void UpdatePanel2Rows(int rowCount)
        {
            panel2.Controls.Clear(); // Clear panel2 before adding new elements
            currentRowCount = 0; // Reset current row count

            for (int r = 0; r < rowCount; r++)
            {
                CreateTextBoxRowForPanel2(textBoxCount); // Create a row with the current number of TextBoxes
            }

            // Update the label with the new row count
            UpdateRowCountLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before clearing
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить все поля?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear all TextBoxes in panel1
                foreach (Control control in panel1.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear(); // Clear the text in TextBoxes
                    }
                }

                // Clear all TextBoxes in panel2
                foreach (Control control in panel2.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear(); // Clear the text in TextBoxes
                    }
                }

                // Clear label7
                label7.Text = string.Empty; // or label7.Clear(); - это также возможно, если label7 поддерживает этот метод
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TestValues.FillTestValues(numericUpDown1, numericUpDown2, panel1, panel2);

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label7.Text = string.Empty; // Очистить предыдущие результаты
            int variableCount = (int)numericUpDown1.Value; // Количество переменных
            int constraintCount = (int)numericUpDown2.Value; // Количество ограничений

            double[,] simplexTable = new double[constraintCount + 1, variableCount + 1]; // +1 для правой части
            StringBuilder selectedSigns = new StringBuilder(); // Для хранения выбранных знаков

            for (int r = 0; r < constraintCount; r++)
            {
                // Проверка выбранного знака в ComboBox
                ComboBox comboBox = panel2.Controls.Find($"comboBox_{r + 1}", true).FirstOrDefault() as ComboBox;
                if (comboBox == null || comboBox.SelectedItem == null)
                {
                    MessageBox.Show($"Ошибка: выберите знак ограничения для строки {r + 1}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Выход из метода при ошибке
                }

                // Добавление выбранного знака в строку
                selectedSigns.AppendLine($"Строка {r + 1}: {comboBox.SelectedItem}");

                TextBox rightHandSideTextBox = panel2.Controls.Find($"newTextField_{r + 1}", true).FirstOrDefault() as TextBox;
                if (rightHandSideTextBox != null && double.TryParse(rightHandSideTextBox.Text, out double rhsValue))
                {
                    simplexTable[r, 0] = rhsValue; // Заполнение правой части в первом столбце
                }

                for (int c = 0; c < variableCount; c++)
                {
                    TextBox textBox = panel2.Controls.Find($"textBox_{c}_{r + 1}", true).FirstOrDefault() as TextBox;
                    if (textBox != null && double.TryParse(textBox.Text, out double value))
                    {
                        simplexTable[r, c + 1] = value; // Заполнение значений ограничений начиная со второго столбца
                    }
                }

                // Обработка знака ограничения
                string sign = comboBox.SelectedItem.ToString();
                switch (sign)
                {
                    case "≤":
                        // Значения остаются без изменений
                        break;
                    case "=":
                        // Для равенства можно оставить как есть или добавить слэк-переменные при необходимости
                        break;
                    case "≥":
                        // Инвертируем знак и правую часть для преобразования в стандартную форму
                        for (int j = 0; j < simplexTable.GetLength(1); j++)
                        {
                            simplexTable[r, j] = -simplexTable[r, j]; // Инвертируем все значения в строке
                        }
                        break;
                    default:
                        MessageBox.Show("Ошибка: выберите корректный знак ограничения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Выход из метода при ошибке
                }
            }

            // Вывод выбранных знаков перед продолжением
            MessageBox.Show($"Выбранные знаки:\n{selectedSigns.ToString()}", "Информация о знаках", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Заполнение целевой функции (последняя строка)
            for (int i = 0; i < variableCount; i++)
            {
                TextBox textBox = panel1.Controls.Find($"textBox_{i}", true).FirstOrDefault() as TextBox;
                if (textBox != null && double.TryParse(textBox.Text, out double value))
                {
                    simplexTable[constraintCount, i + 1] = value; // Сохранение значений целевой функции
                }
            }

            // Определение типа задачи: максимизация или минимизация на основе выбора ComboBox
            string selectedValue = comboBox1.SelectedItem?.ToString();

            switch (selectedValue)
            {
                case "min":
                    break;

                case "max":
                    for (int j = 1; j < simplexTable.GetLength(1); j++)
                    {
                        simplexTable[constraintCount, j] = -simplexTable[constraintCount, j]; // Инвертируем коэффициенты для максимизации
                    }
                    break;

                default:
                    MessageBox.Show("Ошибка: выберите 'min' для минимизации или 'max' для максимизации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Вывод исходной симплекс-таблицы перед расчетом
            StringBuilder initialTableOutput = new StringBuilder();
            initialTableOutput.AppendLine("Исходная симплекс-таблица:");

            for (int i = 0; i < simplexTable.GetLength(0); i++)
            {
                for (int j = 0; j < simplexTable.GetLength(1); j++)
                {
                    initialTableOutput.Append($"{simplexTable[i, j]:F2}".PadLeft(15) + " ");
                }
                initialTableOutput.AppendLine();
            }

            label7.Text += initialTableOutput.ToString();

            try
            {
                Simplex simplex = new Simplex(simplexTable);
                double[] result = new double[variableCount];

                double[,] finalTableResult = simplex.Calculate(result);

                StringBuilder outputBuilder = new StringBuilder();

                outputBuilder.AppendLine("\nИтерации симплекс-таблицы:");

                if (simplex.Iterations.Count > 0)
                {
                    foreach (var iteration in simplex.Iterations)
                    {
                        for (int i = 0; i < iteration.GetLength(0); i++)
                        {
                            for (int j = 0; j < iteration.GetLength(1); j++)
                            {
                                outputBuilder.Append($"{iteration[i, j]:F2}".PadLeft(15) + " ");
                            }
                            outputBuilder.AppendLine();
                        }
                        outputBuilder.AppendLine();
                    }
                }
                else
                {
                    outputBuilder.AppendLine("Оптимальный план найден без итераций.");
                }

                outputBuilder.AppendLine("\nРешение:");

                for (int i = 0; i < result.Length; i++)
                {
                    outputBuilder.AppendLine($"X[{i + 1}] = {result[i]:F2}");
                }

                label7.Text += outputBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}
