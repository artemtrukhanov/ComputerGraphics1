namespace CG_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матморфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интенсивностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растяжениеГистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.собельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прюиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.матморфологияToolStripMenuItem,
            this.чернобелыйToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.интенсивностьToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.растяжениеГистToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.горизонтальнаяToolStripMenuItem});
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.волныToolStripMenuItem.Text = "Волны";
            // 
            // горизонтальнаяToolStripMenuItem
            // 
            this.горизонтальнаяToolStripMenuItem.Name = "горизонтальнаяToolStripMenuItem";
            this.горизонтальнаяToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.горизонтальнаяToolStripMenuItem.Text = "Горизонтальная";
            this.горизонтальнаяToolStripMenuItem.Click += new System.EventHandler(this.горизонтальнаяToolStripMenuItem_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект \"Стекла\"";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // матморфологияToolStripMenuItem
            // 
            this.матморфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расширениеToolStripMenuItem1,
            this.сужениеToolStripMenuItem1,
            this.закрытиеToolStripMenuItem1,
            this.открытиеToolStripMenuItem1,
            this.gradToolStripMenuItem});
            this.матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            this.матморфологияToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // расширениеToolStripMenuItem1
            // 
            this.расширениеToolStripMenuItem1.Name = "расширениеToolStripMenuItem1";
            this.расширениеToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.расширениеToolStripMenuItem1.Text = "Расширение";
            this.расширениеToolStripMenuItem1.Click += new System.EventHandler(this.расширениеToolStripMenuItem1_Click);
            // 
            // сужениеToolStripMenuItem1
            // 
            this.сужениеToolStripMenuItem1.Name = "сужениеToolStripMenuItem1";
            this.сужениеToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.сужениеToolStripMenuItem1.Text = "Сужение";
            this.сужениеToolStripMenuItem1.Click += new System.EventHandler(this.сужениеToolStripMenuItem1_Click);
            // 
            // закрытиеToolStripMenuItem1
            // 
            this.закрытиеToolStripMenuItem1.Name = "закрытиеToolStripMenuItem1";
            this.закрытиеToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.закрытиеToolStripMenuItem1.Text = "Закрытие";
            this.закрытиеToolStripMenuItem1.Click += new System.EventHandler(this.закрытиеToolStripMenuItem1_Click);
            // 
            // открытиеToolStripMenuItem1
            // 
            this.открытиеToolStripMenuItem1.Name = "открытиеToolStripMenuItem1";
            this.открытиеToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.открытиеToolStripMenuItem1.Text = "Открытие";
            this.открытиеToolStripMenuItem1.Click += new System.EventHandler(this.открытиеToolStripMenuItem1_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // чернобелыйToolStripMenuItem
            // 
            this.чернобелыйToolStripMenuItem.Name = "чернобелыйToolStripMenuItem";
            this.чернобелыйToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.чернобелыйToolStripMenuItem.Text = "Черно-белый";
            this.чернобелыйToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // интенсивностьToolStripMenuItem
            // 
            this.интенсивностьToolStripMenuItem.Name = "интенсивностьToolStripMenuItem";
            this.интенсивностьToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.интенсивностьToolStripMenuItem.Text = "Интенсивность";
            this.интенсивностьToolStripMenuItem.Click += new System.EventHandler(this.интенсивностьToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // растяжениеГистToolStripMenuItem
            // 
            this.растяжениеГистToolStripMenuItem.Name = "растяжениеГистToolStripMenuItem";
            this.растяжениеГистToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.растяжениеГистToolStripMenuItem.Text = "Растяжение гист.";
            this.растяжениеГистToolStripMenuItem.Click += new System.EventHandler(this.растяжениеГистToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.гауссаToolStripMenuItem,
            this.собельToolStripMenuItem,
            this.прюиттToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // гауссаToolStripMenuItem
            // 
            this.гауссаToolStripMenuItem.Name = "гауссаToolStripMenuItem";
            this.гауссаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.гауссаToolStripMenuItem.Text = "Гаусса";
            this.гауссаToolStripMenuItem.Click += new System.EventHandler(this.гауссаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 445);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // собельToolStripMenuItem
            // 
            this.собельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sXToolStripMenuItem,
            this.sYToolStripMenuItem});
            this.собельToolStripMenuItem.Name = "собельToolStripMenuItem";
            this.собельToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.собельToolStripMenuItem.Text = "Собель";
            // 
            // sXToolStripMenuItem
            // 
            this.sXToolStripMenuItem.Name = "sXToolStripMenuItem";
            this.sXToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sXToolStripMenuItem.Text = "sX";
            this.sXToolStripMenuItem.Click += new System.EventHandler(this.sXToolStripMenuItem_Click);
            // 
            // sYToolStripMenuItem
            // 
            this.sYToolStripMenuItem.Name = "sYToolStripMenuItem";
            this.sYToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sYToolStripMenuItem.Text = "sY";
            this.sYToolStripMenuItem.Click += new System.EventHandler(this.sYToolStripMenuItem_Click);
            // 
            // прюиттToolStripMenuItem
            // 
            this.прюиттToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pXToolStripMenuItem,
            this.pYToolStripMenuItem});
            this.прюиттToolStripMenuItem.Name = "прюиттToolStripMenuItem";
            this.прюиттToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.прюиттToolStripMenuItem.Text = "Прюитт";
            // 
            // pXToolStripMenuItem
            // 
            this.pXToolStripMenuItem.Name = "pXToolStripMenuItem";
            this.pXToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pXToolStripMenuItem.Text = "pX";
            this.pXToolStripMenuItem.Click += new System.EventHandler(this.pXToolStripMenuItem_Click);
            // 
            // pYToolStripMenuItem
            // 
            this.pYToolStripMenuItem.Name = "pYToolStripMenuItem";
            this.pYToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pYToolStripMenuItem.Text = "pY";
            this.pYToolStripMenuItem.Click += new System.EventHandler(this.pYToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матморфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интенсивностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растяжениеГистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прюиттToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pYToolStripMenuItem;
    }
}

