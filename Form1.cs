using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Необходимо для использования LINQ
using System.Windows.Forms;

namespace SEMENOV
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>(); // Список автомобилей
        private const string carsFilePath = "Cars.txt"; // Путь к файлу с данными автомобилей

        public Form1()
        {
            InitializeComponent();
            InitializeListView(); 
            LoadCarsFromFile(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCarsFromFile(); // Запускаем загрузку автомобилей при загрузке формы
        }

        private void InitializeListView()
        {
            listViewCars.View = View.Details; // Устанавливаем режим в "Детали"
            listViewCars.Columns.Clear(); // Очистка колонок

            // Добавление колонок
            listViewCars.Columns.Add("№", 50);
            listViewCars.Columns.Add("Марка", 100);
            listViewCars.Columns.Add("Модель", 100);
            listViewCars.Columns.Add("Цвет", 100);
            listViewCars.Columns.Add("Двигатель", 100);
            listViewCars.Columns.Add("Трансмиссия", 100);

            // Подписка на события
            listViewCars.MouseClick += new MouseEventHandler(this.listViewCars_MouseClick); // Добавлен обработчик клика мыши
            textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged); // Добавляем обработчик изменения текста
        }

        private void UpdateListView(List<Car> carsToDisplay = null)
        {
            listViewCars.Items.Clear(); // Очистка текущих элементов
            var displayCars = carsToDisplay ?? cars; // Отображаем автомобили

            for (int i = 0; i < displayCars.Count; i++)
            {
                var car = displayCars[i];
                var listViewItem = new ListViewItem((i + 1).ToString()); // Добавление номера
                listViewItem.SubItems.Add(car.Brand); // Марка
                listViewItem.SubItems.Add(car.Model); // Модель
                listViewItem.SubItems.Add(car.Color); // Цвет
                listViewItem.SubItems.Add(car.Engine); // Двигатель
                listViewItem.SubItems.Add(car.Transmission); // Трансмиссия

                listViewCars.Items.Add(listViewItem); // Добавление элемента в ListView
            }
        }

        private void LoadCarsFromFile()
        {
            cars.Clear(); // Очищаем список перед загрузкой
            if (File.Exists(carsFilePath))
            {
                string[] lines = File.ReadAllLines(carsFilePath);
                foreach (string line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        var car = new Car
                        {
                            Brand = parts[0],
                            Model = parts[1],
                            Color = parts[2],
                            Engine = parts[3],
                            Transmission = parts[4]
                        };
                        cars.Add(car);
                    }
                }
                UpdateListView(); // Обновление ListView после загрузки данных
            }
            else
            {
                MessageBox.Show("Файл с данными о машинах не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCarsToFile()
        {
            using (StreamWriter writer = new StreamWriter(carsFilePath, false)) // false для перезаписи
            {
                foreach (var car in cars)
                {
                    writer.WriteLine($"{car.Brand}|{car.Model}|{car.Color}|{car.Engine}|{car.Transmission}");
                }
            }
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            UpdateListView(); // Показываем все автомобили в ListView
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            using (var addCarForm = new AddCarForm())
            {
                if (addCarForm.ShowDialog() == DialogResult.OK)
                {
                    cars.Add(addCarForm.NewCar); // Добавление нового автомобиля
                    UpdateListView(); // Обновляем ListView
                    SaveCarsToFile(); // Сохраняем изменения
                    ShowSuccessMessage("Автомобиль успешно добавлен.");
                }
            }
        }

        private void EditCarButton_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCars.SelectedItems[0];
                int index = selectedItem.Index; // Индекс выбранного автомобиля
                var selectedCar = cars[index]; // Получаем информацию об автомобиле

                using (var addCarForm = new AddCarForm(selectedCar))
                {
                    if (addCarForm.ShowDialog() == DialogResult.OK)
                    {
                        cars[index] = addCarForm.NewCar; // Обновляем информацию об автомобиле
                        UpdateListView(); // Обновляем ListView
                        SaveCarsToFile(); // Сохраняем изменения
                        ShowSuccessMessage("Информация об автомобиле успешно обновлена.");
                    }
                }
            }
        }

        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCars.SelectedItems[0];
                int index = selectedItem.Index; // Индекс выбранного автомобиля

                cars.RemoveAt(index); // Удаляем выбранный автомобиль из списка
                UpdateListView(); // Обновляем ListView
                SaveCarsToFile(); // Сохраняем изменения
                ShowSuccessMessage("Автомобиль успешно удален.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower(); // Используем текст из textBox1
            var filteredCars = cars.Where(car =>
                car.Brand.ToLower().Contains(searchTerm) ||
                car.Model.ToLower().Contains(searchTerm) ||
                car.Color.ToLower().Contains(searchTerm) ||
                car.Engine.ToLower().Contains(searchTerm) ||
                car.Transmission.ToLower().Contains(searchTerm)).ToList();

            UpdateListView(filteredCars); // Обновляем ListView с отфильтрованными автомобилями
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCarsToFile(); // Сохранение автомобилей в файл
            ShowSuccessMessage("Данные о машинах успешно сохранены.");
        }

        private void listViewCars_MouseClick(object sender, MouseEventArgs e) // Обработчик клика мыши
        {
            ListViewItem item = listViewCars.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                int index = item.Index; // Получаем индекс выбранного автомобиля
                listViewCars.SelectedItems.Clear(); // Очистка выделения
                item.Selected = true; // Выбор автомобиля

                var selectedCar = cars[index]; // Получаем информацию об автомобиле
                MessageBox.Show($"Вы выбрали {selectedCar.Brand} {selectedCar.Model}",
                                "Информация об автомобиле",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information); // Отображение информации
            }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверить, нужно ли это событие, если не используется - можно удалить
        }
    }
}
