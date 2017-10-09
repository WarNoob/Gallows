namespace Gallows
{
    partial class GameFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFrame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Timer(this.components);
            this.end = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonYouWin = new System.Windows.Forms.Button();
            this.buttonGameOver = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(337, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // start
            // 
            this.start.Enabled = true;
            this.start.Interval = 10;
            this.start.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // end
            // 
            this.end.Interval = 10;
            this.end.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 460);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button37);
            this.panel1.Controls.Add(this.button38);
            this.panel1.Controls.Add(this.button39);
            this.panel1.Controls.Add(this.button40);
            this.panel1.Controls.Add(this.button41);
            this.panel1.Controls.Add(this.button42);
            this.panel1.Controls.Add(this.button43);
            this.panel1.Controls.Add(this.button44);
            this.panel1.Controls.Add(this.button45);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button27);
            this.panel1.Controls.Add(this.button28);
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.button30);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button32);
            this.panel1.Controls.Add(this.button33);
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.button35);
            this.panel1.Controls.Add(this.button36);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonYouWin);
            this.panel1.Controls.Add(this.buttonGameOver);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.Black;
            this.button37.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button37.BackgroundImage")));
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button37.Image = ((System.Drawing.Image)(resources.GetObject("button37.Image")));
            this.button37.Location = new System.Drawing.Point(268, 393);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(30, 30);
            this.button37.TabIndex = 66;
            this.button37.Text = "Ю";
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Black;
            this.button38.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button38.BackgroundImage")));
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button38.Image = ((System.Drawing.Image)(resources.GetObject("button38.Image")));
            this.button38.Location = new System.Drawing.Point(238, 393);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(30, 30);
            this.button38.TabIndex = 65;
            this.button38.Text = "Б";
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.Black;
            this.button39.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button39.BackgroundImage")));
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button39.FlatAppearance.BorderSize = 0;
            this.button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button39.Image = ((System.Drawing.Image)(resources.GetObject("button39.Image")));
            this.button39.Location = new System.Drawing.Point(208, 393);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(30, 30);
            this.button39.TabIndex = 64;
            this.button39.Text = "Ь";
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Black;
            this.button40.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button40.BackgroundImage")));
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button40.Image = ((System.Drawing.Image)(resources.GetObject("button40.Image")));
            this.button40.Location = new System.Drawing.Point(178, 393);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(30, 30);
            this.button40.TabIndex = 63;
            this.button40.Text = "Т";
            this.button40.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.Black;
            this.button41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button41.BackgroundImage")));
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button41.Image = ((System.Drawing.Image)(resources.GetObject("button41.Image")));
            this.button41.Location = new System.Drawing.Point(148, 393);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(30, 30);
            this.button41.TabIndex = 62;
            this.button41.Text = "И";
            this.button41.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.Black;
            this.button42.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button42.BackgroundImage")));
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button42.FlatAppearance.BorderSize = 0;
            this.button42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button42.Image = ((System.Drawing.Image)(resources.GetObject("button42.Image")));
            this.button42.Location = new System.Drawing.Point(118, 393);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(30, 30);
            this.button42.TabIndex = 61;
            this.button42.Text = "М";
            this.button42.UseVisualStyleBackColor = false;
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.Black;
            this.button43.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button43.BackgroundImage")));
            this.button43.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button43.FlatAppearance.BorderSize = 0;
            this.button43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button43.Image = ((System.Drawing.Image)(resources.GetObject("button43.Image")));
            this.button43.Location = new System.Drawing.Point(88, 393);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(30, 30);
            this.button43.TabIndex = 60;
            this.button43.Text = "С";
            this.button43.UseVisualStyleBackColor = false;
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.Black;
            this.button44.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button44.BackgroundImage")));
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button44.FlatAppearance.BorderSize = 0;
            this.button44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button44.Image = ((System.Drawing.Image)(resources.GetObject("button44.Image")));
            this.button44.Location = new System.Drawing.Point(58, 393);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(30, 30);
            this.button44.TabIndex = 59;
            this.button44.Text = "Ч";
            this.button44.UseVisualStyleBackColor = false;
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.Black;
            this.button45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button45.BackgroundImage")));
            this.button45.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button45.FlatAppearance.BorderSize = 0;
            this.button45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button45.Image = ((System.Drawing.Image)(resources.GetObject("button45.Image")));
            this.button45.Location = new System.Drawing.Point(28, 393);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(30, 30);
            this.button45.TabIndex = 58;
            this.button45.Text = "Я";
            this.button45.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Black;
            this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button26.Image = ((System.Drawing.Image)(resources.GetObject("button26.Image")));
            this.button26.Location = new System.Drawing.Point(316, 357);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(30, 30);
            this.button26.TabIndex = 57;
            this.button26.Text = "Э";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Black;
            this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button27.Image = ((System.Drawing.Image)(resources.GetObject("button27.Image")));
            this.button27.Location = new System.Drawing.Point(286, 357);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(30, 30);
            this.button27.TabIndex = 56;
            this.button27.Text = "Ж";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Black;
            this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button28.Image = ((System.Drawing.Image)(resources.GetObject("button28.Image")));
            this.button28.Location = new System.Drawing.Point(256, 357);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(30, 30);
            this.button28.TabIndex = 55;
            this.button28.Text = "Д";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Black;
            this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button29.Image = ((System.Drawing.Image)(resources.GetObject("button29.Image")));
            this.button29.Location = new System.Drawing.Point(226, 357);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(30, 30);
            this.button29.TabIndex = 54;
            this.button29.Text = "Л";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Black;
            this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button30.Image = ((System.Drawing.Image)(resources.GetObject("button30.Image")));
            this.button30.Location = new System.Drawing.Point(196, 357);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(30, 30);
            this.button30.TabIndex = 53;
            this.button30.Text = "О";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Black;
            this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button31.Image = ((System.Drawing.Image)(resources.GetObject("button31.Image")));
            this.button31.Location = new System.Drawing.Point(166, 357);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(30, 30);
            this.button31.TabIndex = 52;
            this.button31.Text = "Р";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Black;
            this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
            this.button32.Location = new System.Drawing.Point(136, 357);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(30, 30);
            this.button32.TabIndex = 51;
            this.button32.Text = "П";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Black;
            this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.Location = new System.Drawing.Point(106, 357);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(30, 30);
            this.button33.TabIndex = 50;
            this.button33.Text = "А";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Black;
            this.button34.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button34.BackgroundImage")));
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.Location = new System.Drawing.Point(76, 357);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(30, 30);
            this.button34.TabIndex = 49;
            this.button34.Text = "В";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.Black;
            this.button35.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button35.BackgroundImage")));
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button35.Image = ((System.Drawing.Image)(resources.GetObject("button35.Image")));
            this.button35.Location = new System.Drawing.Point(46, 357);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(30, 30);
            this.button35.TabIndex = 48;
            this.button35.Text = "Ы";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.Black;
            this.button36.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button36.BackgroundImage")));
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button36.Image = ((System.Drawing.Image)(resources.GetObject("button36.Image")));
            this.button36.Location = new System.Drawing.Point(16, 357);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(30, 30);
            this.button36.TabIndex = 47;
            this.button36.Text = "Ф";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Black;
            this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(330, 321);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 30);
            this.button21.TabIndex = 46;
            this.button21.Text = "Ъ";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Black;
            this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button22.Image = ((System.Drawing.Image)(resources.GetObject("button22.Image")));
            this.button22.Location = new System.Drawing.Point(300, 321);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 30);
            this.button22.TabIndex = 45;
            this.button22.Text = "Х";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Black;
            this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(270, 321);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(30, 30);
            this.button23.TabIndex = 44;
            this.button23.Text = "З";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Black;
            this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.Location = new System.Drawing.Point(240, 321);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(30, 30);
            this.button24.TabIndex = 43;
            this.button24.Text = "Щ";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Black;
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(210, 321);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(30, 30);
            this.button20.TabIndex = 42;
            this.button20.Text = "Ш";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Black;
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(180, 321);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(30, 30);
            this.button19.TabIndex = 41;
            this.button19.Text = "Г";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Black;
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(150, 321);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(30, 30);
            this.button18.TabIndex = 40;
            this.button18.Text = "Н";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Black;
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(120, 321);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 30);
            this.button17.TabIndex = 39;
            this.button17.Text = "Е";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Black;
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(90, 321);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 30);
            this.button16.TabIndex = 38;
            this.button16.Text = "К";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(60, 321);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 30);
            this.button15.TabIndex = 37;
            this.button15.Text = "У";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(30, 321);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 30);
            this.button14.TabIndex = 36;
            this.button14.Text = "Ц";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Black;
            this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button25.Image = ((System.Drawing.Image)(resources.GetObject("button25.Image")));
            this.button25.Location = new System.Drawing.Point(0, 321);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 30);
            this.button25.TabIndex = 35;
            this.button25.Text = "Й";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 23;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Black;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox9.ForeColor = System.Drawing.Color.Gold;
            this.textBox9.Location = new System.Drawing.Point(309, 34);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(32, 32);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "Т";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Black;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox10.ForeColor = System.Drawing.Color.Gold;
            this.textBox10.Location = new System.Drawing.Point(281, 34);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(32, 32);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Е";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Black;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox11.ForeColor = System.Drawing.Color.Gold;
            this.textBox11.Location = new System.Drawing.Point(253, 34);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 32);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "Р";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox5.ForeColor = System.Drawing.Color.Gold;
            this.textBox5.Location = new System.Drawing.Point(224, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 32);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "Т";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox6.ForeColor = System.Drawing.Color.Gold;
            this.textBox6.Location = new System.Drawing.Point(196, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 32);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "Р";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox7.ForeColor = System.Drawing.Color.Gold;
            this.textBox7.Location = new System.Drawing.Point(168, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 32);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "О";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox8.ForeColor = System.Drawing.Color.Gold;
            this.textBox8.Location = new System.Drawing.Point(140, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 32);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "П";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox3.ForeColor = System.Drawing.Color.Gold;
            this.textBox3.Location = new System.Drawing.Point(112, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 32);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "О";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox4.ForeColor = System.Drawing.Color.Gold;
            this.textBox4.Location = new System.Drawing.Point(84, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 32);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Т";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.ForeColor = System.Drawing.Color.Gold;
            this.textBox2.Location = new System.Drawing.Point(56, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 32);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "В";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(28, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 32);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "А";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.tetBox1_TextChanged);
            // 
            // buttonYouWin
            // 
            this.buttonYouWin.Location = new System.Drawing.Point(112, 176);
            this.buttonYouWin.Name = "buttonYouWin";
            this.buttonYouWin.Size = new System.Drawing.Size(79, 23);
            this.buttonYouWin.TabIndex = 11;
            this.buttonYouWin.Text = "You Win";
            this.buttonYouWin.UseVisualStyleBackColor = true;
            this.buttonYouWin.Click += new System.EventHandler(this.buttonYouWin_Click);
            // 
            // buttonGameOver
            // 
            this.buttonGameOver.Location = new System.Drawing.Point(112, 147);
            this.buttonGameOver.Name = "buttonGameOver";
            this.buttonGameOver.Size = new System.Drawing.Size(79, 23);
            this.buttonGameOver.TabIndex = 10;
            this.buttonGameOver.Text = "Game Over";
            this.buttonGameOver.UseVisualStyleBackColor = true;
            this.buttonGameOver.Click += new System.EventHandler(this.buttonGameOver_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(280, 118);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(252, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(224, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(196, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(169, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Висельница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFrame_FormClosing);
            this.Load += new System.EventHandler(this.GameFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer start;
        private System.Windows.Forms.Timer end;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonYouWin;
        private System.Windows.Forms.Button buttonGameOver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button25;

    }
}

