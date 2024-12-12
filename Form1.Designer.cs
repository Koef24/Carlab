namespace SEMENOV
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddCarButton = new System.Windows.Forms.Button();
            this.EditCarButton = new System.Windows.Forms.Button();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(13, 14);
            this.AddCarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(140, 40);
            this.AddCarButton.TabIndex = 1;
            this.AddCarButton.Text = "Добавить";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // EditCarButton
            // 
            this.EditCarButton.Location = new System.Drawing.Point(13, 64);
            this.EditCarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditCarButton.Name = "EditCarButton";
            this.EditCarButton.Size = new System.Drawing.Size(140, 40);
            this.EditCarButton.TabIndex = 2;
            this.EditCarButton.Text = "Изменить";
            this.EditCarButton.UseVisualStyleBackColor = true;
            this.EditCarButton.Click += new System.EventHandler(this.EditCarButton_Click);
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.Location = new System.Drawing.Point(187, 14);
            this.DeleteCarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(140, 40);
            this.DeleteCarButton.TabIndex = 3;
            this.DeleteCarButton.Text = "Удалить";
            this.DeleteCarButton.UseVisualStyleBackColor = true;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCarButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(187, 64);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 40);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(361, 64);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(200, 40);
            this.ShowAllButton.TabIndex = 7;
            this.ShowAllButton.Text = "Показать все";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(13, 112);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(1114, 555);
            this.listViewCars.TabIndex = 8;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEMENOV.Properties.Resources._2020aca836bf33c0801fd864ab4a4723;
            this.ClientSize = new System.Drawing.Size(1139, 679);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteCarButton);
            this.Controls.Add(this.EditCarButton);
            this.Controls.Add(this.AddCarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1165, 750);
            this.MinimumSize = new System.Drawing.Size(1165, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобильный каталог";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button EditCarButton;
        private System.Windows.Forms.Button DeleteCarButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.ListView listViewCars;
    }
}
