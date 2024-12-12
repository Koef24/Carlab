using System;
using System.Windows.Forms;

namespace SEMENOV
{
    public partial class AddCarForm : Form
    {
        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private TextBox colorTextBox;
        private TextBox engineTextBox;
        private TextBox transmissionTextBox;
        private Label labelMandatory; // Переименовано для уникальности

        public Car NewCar { get; private set; }

        // Конструктор для добавления нового автомобиля
        public AddCarForm()
        {
            InitializeComponent();
        }

        // Конструктор для редактирования существующего автомобиля
        public AddCarForm(Car car) : this()
        {
            brandTextBox.Text = car.Brand;
            modelTextBox.Text = car.Model;
            colorTextBox.Text = car.Color;
            engineTextBox.Text = car.Engine;
            transmissionTextBox.Text = car.Transmission;

            // Делаем поля "Марка" и "Модель" недоступными для редактирования
            brandTextBox.ReadOnly = true;
            modelTextBox.ReadOnly = true;

            // Изменяем цвет фона, чтобы обозначить, что они недоступны для редактирования
            brandTextBox.BackColor = System.Drawing.SystemColors.Control;
            modelTextBox.BackColor = System.Drawing.SystemColors.Control;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность поля "Модель"
            if (string.IsNullOrWhiteSpace(modelTextBox.Text))
            {
                MessageBox.Show("Поле 'Модель' должно быть заполнено.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                modelTextBox.Focus(); // Устанавливаем фокус на поле "Модель"
                return;
            }

            // Если проверки прошли создаем Car
            NewCar = new Car
            {
                Brand = brandTextBox.Text,
                Model = modelTextBox.Text,
                Color = colorTextBox.Text,
                Engine = engineTextBox.Text,
                Transmission = transmissionTextBox.Text
            };

            DialogResult = DialogResult.OK; //  OK
            Close(); // Закрыть 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // отмена
            Close(); // Закрыть 
        }

        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.transmissionTextBox = new System.Windows.Forms.TextBox();
            this.labelMandatory = new System.Windows.Forms.Label(); // Изменено имя
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(133, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 30);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Oк";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(358, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 30);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Марка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Модель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цвет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Двигатель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Трансмиссия:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandTextBox.Location = new System.Drawing.Point(139, 12);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(305, 31);
            this.brandTextBox.TabIndex = 4;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(139, 47);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(305, 31);
            this.modelTextBox.TabIndex = 3;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorTextBox.Location = new System.Drawing.Point(139, 82);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(305, 24);
            this.colorTextBox.TabIndex = 2;
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // engineTextBox
            // 
            this.engineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.engineTextBox.Location = new System.Drawing.Point(139, 117);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(305, 31);
            this.engineTextBox.TabIndex = 1;
            // 
            // transmissionTextBox
            // 
            this.transmissionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transmissionTextBox.Location = new System.Drawing.Point(139, 152);
            this.transmissionTextBox.Name = "transmissionTextBox";
            this.transmissionTextBox.Size = new System.Drawing.Size(305, 31);
            this.transmissionTextBox.TabIndex = 0;
            // 
            // labelMandatory
            // 
            this.labelMandatory.AutoSize = true;
            this.labelMandatory.Location = new System.Drawing.Point(128, 183);
            this.labelMandatory.Name = "labelMandatory";
            this.labelMandatory.Size = new System.Drawing.Size(368, 25);
            this.labelMandatory.TabIndex = 12;
            this.labelMandatory.Text = "* Поле обязательное к заполнению";
            // 
            // AddCarForm
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 269);
            this.Controls.Add(this.labelMandatory); // Добавление нового элемента
            this.Controls.Add(this.transmissionTextBox);
            this.Controls.Add(this.engineTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarForm";
            this.Text = "Добавить Автомобиль";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void engineTextBox_TextChanged(object sender, EventArgs e) { }

        private void transmissionTextBox_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void AddCarForm_Load(object sender, EventArgs e) { }

        private void colorTextBox_TextChanged(object sender, EventArgs e) { }
    }
}
