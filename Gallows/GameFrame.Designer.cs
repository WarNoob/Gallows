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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFrame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Timer(this.components);
            this.end = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLetter23 = new System.Windows.Forms.Button();
            this.buttonLetter24 = new System.Windows.Forms.Button();
            this.buttonLetter25 = new System.Windows.Forms.Button();
            this.buttonLetter26 = new System.Windows.Forms.Button();
            this.buttonLetter27 = new System.Windows.Forms.Button();
            this.buttonLetter28 = new System.Windows.Forms.Button();
            this.buttonLetter29 = new System.Windows.Forms.Button();
            this.buttonLetter30 = new System.Windows.Forms.Button();
            this.buttonLetter31 = new System.Windows.Forms.Button();
            this.buttonLetter12 = new System.Windows.Forms.Button();
            this.buttonLetter13 = new System.Windows.Forms.Button();
            this.buttonLetter14 = new System.Windows.Forms.Button();
            this.buttonLetter15 = new System.Windows.Forms.Button();
            this.buttonLetter16 = new System.Windows.Forms.Button();
            this.buttonLetter17 = new System.Windows.Forms.Button();
            this.buttonLetter18 = new System.Windows.Forms.Button();
            this.buttonLetter19 = new System.Windows.Forms.Button();
            this.buttonLetter20 = new System.Windows.Forms.Button();
            this.buttonLetter21 = new System.Windows.Forms.Button();
            this.buttonLetter22 = new System.Windows.Forms.Button();
            this.buttonLetter7 = new System.Windows.Forms.Button();
            this.buttonLetter8 = new System.Windows.Forms.Button();
            this.buttonLetter9 = new System.Windows.Forms.Button();
            this.buttonLetter10 = new System.Windows.Forms.Button();
            this.buttonLetter6 = new System.Windows.Forms.Button();
            this.buttonLetter5 = new System.Windows.Forms.Button();
            this.buttonLetter4 = new System.Windows.Forms.Button();
            this.buttonLetter3 = new System.Windows.Forms.Button();
            this.buttonLetter2 = new System.Windows.Forms.Button();
            this.buttonLetter1 = new System.Windows.Forms.Button();
            this.buttonLetter0 = new System.Windows.Forms.Button();
            this.buttonLetter11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            this.pictureBox2.Image = global::Gallows.Properties.Resources.visel0;
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
            this.panel1.Controls.Add(this.buttonLetter23);
            this.panel1.Controls.Add(this.buttonLetter24);
            this.panel1.Controls.Add(this.buttonLetter25);
            this.panel1.Controls.Add(this.buttonLetter26);
            this.panel1.Controls.Add(this.buttonLetter27);
            this.panel1.Controls.Add(this.buttonLetter28);
            this.panel1.Controls.Add(this.buttonLetter29);
            this.panel1.Controls.Add(this.buttonLetter30);
            this.panel1.Controls.Add(this.buttonLetter31);
            this.panel1.Controls.Add(this.buttonLetter12);
            this.panel1.Controls.Add(this.buttonLetter13);
            this.panel1.Controls.Add(this.buttonLetter14);
            this.panel1.Controls.Add(this.buttonLetter15);
            this.panel1.Controls.Add(this.buttonLetter16);
            this.panel1.Controls.Add(this.buttonLetter17);
            this.panel1.Controls.Add(this.buttonLetter18);
            this.panel1.Controls.Add(this.buttonLetter19);
            this.panel1.Controls.Add(this.buttonLetter20);
            this.panel1.Controls.Add(this.buttonLetter21);
            this.panel1.Controls.Add(this.buttonLetter22);
            this.panel1.Controls.Add(this.buttonLetter7);
            this.panel1.Controls.Add(this.buttonLetter8);
            this.panel1.Controls.Add(this.buttonLetter9);
            this.panel1.Controls.Add(this.buttonLetter10);
            this.panel1.Controls.Add(this.buttonLetter6);
            this.panel1.Controls.Add(this.buttonLetter5);
            this.panel1.Controls.Add(this.buttonLetter4);
            this.panel1.Controls.Add(this.buttonLetter3);
            this.panel1.Controls.Add(this.buttonLetter2);
            this.panel1.Controls.Add(this.buttonLetter1);
            this.panel1.Controls.Add(this.buttonLetter0);
            this.panel1.Controls.Add(this.buttonLetter11);
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // buttonLetter23
            // 
            this.buttonLetter23.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter23.BackgroundImage")));
            this.buttonLetter23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter23.FlatAppearance.BorderSize = 0;
            this.buttonLetter23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter23.ForeColor = System.Drawing.Color.White;
            this.buttonLetter23.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter23.Image")));
            this.buttonLetter23.Location = new System.Drawing.Point(333, 395);
            this.buttonLetter23.Name = "buttonLetter23";
            this.buttonLetter23.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter23.TabIndex = 66;
            this.buttonLetter23.Text = "Ю";
            this.buttonLetter23.UseVisualStyleBackColor = false;
            this.buttonLetter23.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter24
            // 
            this.buttonLetter24.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter24.BackgroundImage")));
            this.buttonLetter24.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter24.FlatAppearance.BorderSize = 0;
            this.buttonLetter24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter24.ForeColor = System.Drawing.Color.White;
            this.buttonLetter24.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter24.Image")));
            this.buttonLetter24.Location = new System.Drawing.Point(303, 395);
            this.buttonLetter24.Name = "buttonLetter24";
            this.buttonLetter24.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter24.TabIndex = 65;
            this.buttonLetter24.Text = "Б";
            this.buttonLetter24.UseVisualStyleBackColor = false;
            this.buttonLetter24.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter25
            // 
            this.buttonLetter25.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter25.BackgroundImage")));
            this.buttonLetter25.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter25.FlatAppearance.BorderSize = 0;
            this.buttonLetter25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter25.ForeColor = System.Drawing.Color.White;
            this.buttonLetter25.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter25.Image")));
            this.buttonLetter25.Location = new System.Drawing.Point(273, 395);
            this.buttonLetter25.Name = "buttonLetter25";
            this.buttonLetter25.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter25.TabIndex = 64;
            this.buttonLetter25.Text = "Ь";
            this.buttonLetter25.UseVisualStyleBackColor = false;
            this.buttonLetter25.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter26
            // 
            this.buttonLetter26.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter26.BackgroundImage")));
            this.buttonLetter26.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter26.FlatAppearance.BorderSize = 0;
            this.buttonLetter26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter26.ForeColor = System.Drawing.Color.White;
            this.buttonLetter26.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter26.Image")));
            this.buttonLetter26.Location = new System.Drawing.Point(243, 395);
            this.buttonLetter26.Name = "buttonLetter26";
            this.buttonLetter26.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter26.TabIndex = 63;
            this.buttonLetter26.Text = "Т";
            this.buttonLetter26.UseVisualStyleBackColor = false;
            this.buttonLetter26.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter27
            // 
            this.buttonLetter27.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter27.BackgroundImage")));
            this.buttonLetter27.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter27.FlatAppearance.BorderSize = 0;
            this.buttonLetter27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter27.ForeColor = System.Drawing.Color.White;
            this.buttonLetter27.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter27.Image")));
            this.buttonLetter27.Location = new System.Drawing.Point(213, 395);
            this.buttonLetter27.Name = "buttonLetter27";
            this.buttonLetter27.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter27.TabIndex = 62;
            this.buttonLetter27.Text = "И";
            this.buttonLetter27.UseVisualStyleBackColor = false;
            this.buttonLetter27.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter28
            // 
            this.buttonLetter28.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter28.BackgroundImage")));
            this.buttonLetter28.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter28.FlatAppearance.BorderSize = 0;
            this.buttonLetter28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter28.ForeColor = System.Drawing.Color.White;
            this.buttonLetter28.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter28.Image")));
            this.buttonLetter28.Location = new System.Drawing.Point(183, 395);
            this.buttonLetter28.Name = "buttonLetter28";
            this.buttonLetter28.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter28.TabIndex = 61;
            this.buttonLetter28.Text = "М";
            this.buttonLetter28.UseVisualStyleBackColor = false;
            this.buttonLetter28.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter29
            // 
            this.buttonLetter29.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter29.BackgroundImage")));
            this.buttonLetter29.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter29.FlatAppearance.BorderSize = 0;
            this.buttonLetter29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter29.ForeColor = System.Drawing.Color.White;
            this.buttonLetter29.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter29.Image")));
            this.buttonLetter29.Location = new System.Drawing.Point(153, 395);
            this.buttonLetter29.Name = "buttonLetter29";
            this.buttonLetter29.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter29.TabIndex = 60;
            this.buttonLetter29.Text = "С";
            this.buttonLetter29.UseVisualStyleBackColor = false;
            this.buttonLetter29.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter30
            // 
            this.buttonLetter30.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter30.BackgroundImage")));
            this.buttonLetter30.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter30.FlatAppearance.BorderSize = 0;
            this.buttonLetter30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter30.ForeColor = System.Drawing.Color.White;
            this.buttonLetter30.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter30.Image")));
            this.buttonLetter30.Location = new System.Drawing.Point(123, 395);
            this.buttonLetter30.Name = "buttonLetter30";
            this.buttonLetter30.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter30.TabIndex = 59;
            this.buttonLetter30.Text = "Ч";
            this.buttonLetter30.UseVisualStyleBackColor = false;
            this.buttonLetter30.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter31
            // 
            this.buttonLetter31.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter31.BackgroundImage")));
            this.buttonLetter31.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter31.FlatAppearance.BorderSize = 0;
            this.buttonLetter31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter31.ForeColor = System.Drawing.Color.White;
            this.buttonLetter31.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter31.Image")));
            this.buttonLetter31.Location = new System.Drawing.Point(93, 395);
            this.buttonLetter31.Name = "buttonLetter31";
            this.buttonLetter31.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter31.TabIndex = 58;
            this.buttonLetter31.Text = "Я";
            this.buttonLetter31.UseVisualStyleBackColor = false;
            this.buttonLetter31.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter12
            // 
            this.buttonLetter12.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter12.BackgroundImage")));
            this.buttonLetter12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter12.FlatAppearance.BorderSize = 0;
            this.buttonLetter12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter12.ForeColor = System.Drawing.Color.White;
            this.buttonLetter12.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter12.Image")));
            this.buttonLetter12.Location = new System.Drawing.Point(381, 359);
            this.buttonLetter12.Name = "buttonLetter12";
            this.buttonLetter12.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter12.TabIndex = 57;
            this.buttonLetter12.Text = "Э";
            this.buttonLetter12.UseVisualStyleBackColor = false;
            this.buttonLetter12.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter13
            // 
            this.buttonLetter13.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter13.BackgroundImage")));
            this.buttonLetter13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter13.FlatAppearance.BorderSize = 0;
            this.buttonLetter13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter13.ForeColor = System.Drawing.Color.White;
            this.buttonLetter13.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter13.Image")));
            this.buttonLetter13.Location = new System.Drawing.Point(351, 359);
            this.buttonLetter13.Name = "buttonLetter13";
            this.buttonLetter13.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter13.TabIndex = 56;
            this.buttonLetter13.Text = "Ж";
            this.buttonLetter13.UseVisualStyleBackColor = false;
            this.buttonLetter13.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter14
            // 
            this.buttonLetter14.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter14.BackgroundImage")));
            this.buttonLetter14.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter14.FlatAppearance.BorderSize = 0;
            this.buttonLetter14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter14.ForeColor = System.Drawing.Color.White;
            this.buttonLetter14.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter14.Image")));
            this.buttonLetter14.Location = new System.Drawing.Point(321, 359);
            this.buttonLetter14.Name = "buttonLetter14";
            this.buttonLetter14.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter14.TabIndex = 55;
            this.buttonLetter14.Text = "Д";
            this.buttonLetter14.UseVisualStyleBackColor = false;
            this.buttonLetter14.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter15
            // 
            this.buttonLetter15.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter15.BackgroundImage")));
            this.buttonLetter15.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter15.FlatAppearance.BorderSize = 0;
            this.buttonLetter15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter15.ForeColor = System.Drawing.Color.White;
            this.buttonLetter15.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter15.Image")));
            this.buttonLetter15.Location = new System.Drawing.Point(291, 359);
            this.buttonLetter15.Name = "buttonLetter15";
            this.buttonLetter15.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter15.TabIndex = 54;
            this.buttonLetter15.Text = "Л";
            this.buttonLetter15.UseVisualStyleBackColor = false;
            this.buttonLetter15.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter16
            // 
            this.buttonLetter16.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter16.BackgroundImage")));
            this.buttonLetter16.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter16.FlatAppearance.BorderSize = 0;
            this.buttonLetter16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter16.ForeColor = System.Drawing.Color.White;
            this.buttonLetter16.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter16.Image")));
            this.buttonLetter16.Location = new System.Drawing.Point(261, 359);
            this.buttonLetter16.Name = "buttonLetter16";
            this.buttonLetter16.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter16.TabIndex = 53;
            this.buttonLetter16.Text = "О";
            this.buttonLetter16.UseVisualStyleBackColor = false;
            this.buttonLetter16.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter17
            // 
            this.buttonLetter17.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter17.BackgroundImage")));
            this.buttonLetter17.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter17.FlatAppearance.BorderSize = 0;
            this.buttonLetter17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter17.ForeColor = System.Drawing.Color.White;
            this.buttonLetter17.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter17.Image")));
            this.buttonLetter17.Location = new System.Drawing.Point(231, 359);
            this.buttonLetter17.Name = "buttonLetter17";
            this.buttonLetter17.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter17.TabIndex = 52;
            this.buttonLetter17.Text = "Р";
            this.buttonLetter17.UseVisualStyleBackColor = false;
            this.buttonLetter17.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter18
            // 
            this.buttonLetter18.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter18.BackgroundImage")));
            this.buttonLetter18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter18.FlatAppearance.BorderSize = 0;
            this.buttonLetter18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter18.ForeColor = System.Drawing.Color.White;
            this.buttonLetter18.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter18.Image")));
            this.buttonLetter18.Location = new System.Drawing.Point(201, 359);
            this.buttonLetter18.Name = "buttonLetter18";
            this.buttonLetter18.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter18.TabIndex = 51;
            this.buttonLetter18.Text = "П";
            this.buttonLetter18.UseVisualStyleBackColor = false;
            this.buttonLetter18.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter19
            // 
            this.buttonLetter19.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter19.BackgroundImage")));
            this.buttonLetter19.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter19.FlatAppearance.BorderSize = 0;
            this.buttonLetter19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter19.ForeColor = System.Drawing.Color.White;
            this.buttonLetter19.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter19.Image")));
            this.buttonLetter19.Location = new System.Drawing.Point(171, 359);
            this.buttonLetter19.Name = "buttonLetter19";
            this.buttonLetter19.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter19.TabIndex = 50;
            this.buttonLetter19.Text = "А";
            this.buttonLetter19.UseVisualStyleBackColor = false;
            this.buttonLetter19.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter20
            // 
            this.buttonLetter20.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter20.BackgroundImage")));
            this.buttonLetter20.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter20.FlatAppearance.BorderSize = 0;
            this.buttonLetter20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter20.ForeColor = System.Drawing.Color.White;
            this.buttonLetter20.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter20.Image")));
            this.buttonLetter20.Location = new System.Drawing.Point(141, 359);
            this.buttonLetter20.Name = "buttonLetter20";
            this.buttonLetter20.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter20.TabIndex = 49;
            this.buttonLetter20.Text = "В";
            this.buttonLetter20.UseVisualStyleBackColor = false;
            this.buttonLetter20.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter21
            // 
            this.buttonLetter21.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter21.BackgroundImage")));
            this.buttonLetter21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter21.FlatAppearance.BorderSize = 0;
            this.buttonLetter21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter21.ForeColor = System.Drawing.Color.White;
            this.buttonLetter21.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter21.Image")));
            this.buttonLetter21.Location = new System.Drawing.Point(111, 359);
            this.buttonLetter21.Name = "buttonLetter21";
            this.buttonLetter21.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter21.TabIndex = 48;
            this.buttonLetter21.Text = "Ы";
            this.buttonLetter21.UseVisualStyleBackColor = false;
            this.buttonLetter21.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter22
            // 
            this.buttonLetter22.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter22.BackgroundImage")));
            this.buttonLetter22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter22.FlatAppearance.BorderSize = 0;
            this.buttonLetter22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter22.ForeColor = System.Drawing.Color.White;
            this.buttonLetter22.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter22.Image")));
            this.buttonLetter22.Location = new System.Drawing.Point(81, 359);
            this.buttonLetter22.Name = "buttonLetter22";
            this.buttonLetter22.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter22.TabIndex = 47;
            this.buttonLetter22.Text = "Ф";
            this.buttonLetter22.UseVisualStyleBackColor = false;
            this.buttonLetter22.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter7
            // 
            this.buttonLetter7.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter7.BackgroundImage")));
            this.buttonLetter7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter7.FlatAppearance.BorderSize = 0;
            this.buttonLetter7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter7.ForeColor = System.Drawing.Color.White;
            this.buttonLetter7.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter7.Image")));
            this.buttonLetter7.Location = new System.Drawing.Point(395, 323);
            this.buttonLetter7.Name = "buttonLetter7";
            this.buttonLetter7.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter7.TabIndex = 46;
            this.buttonLetter7.Text = "Ъ";
            this.buttonLetter7.UseVisualStyleBackColor = false;
            this.buttonLetter7.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter8
            // 
            this.buttonLetter8.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter8.BackgroundImage")));
            this.buttonLetter8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter8.FlatAppearance.BorderSize = 0;
            this.buttonLetter8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter8.ForeColor = System.Drawing.Color.White;
            this.buttonLetter8.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter8.Image")));
            this.buttonLetter8.Location = new System.Drawing.Point(365, 323);
            this.buttonLetter8.Name = "buttonLetter8";
            this.buttonLetter8.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter8.TabIndex = 45;
            this.buttonLetter8.Text = "Х";
            this.buttonLetter8.UseVisualStyleBackColor = false;
            this.buttonLetter8.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter9
            // 
            this.buttonLetter9.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter9.BackgroundImage")));
            this.buttonLetter9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter9.FlatAppearance.BorderSize = 0;
            this.buttonLetter9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter9.ForeColor = System.Drawing.Color.White;
            this.buttonLetter9.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter9.Image")));
            this.buttonLetter9.Location = new System.Drawing.Point(335, 323);
            this.buttonLetter9.Name = "buttonLetter9";
            this.buttonLetter9.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter9.TabIndex = 44;
            this.buttonLetter9.Text = "З";
            this.buttonLetter9.UseVisualStyleBackColor = false;
            this.buttonLetter9.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter10
            // 
            this.buttonLetter10.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter10.BackgroundImage")));
            this.buttonLetter10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter10.FlatAppearance.BorderSize = 0;
            this.buttonLetter10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter10.ForeColor = System.Drawing.Color.White;
            this.buttonLetter10.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter10.Image")));
            this.buttonLetter10.Location = new System.Drawing.Point(305, 323);
            this.buttonLetter10.Name = "buttonLetter10";
            this.buttonLetter10.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter10.TabIndex = 43;
            this.buttonLetter10.Text = "Щ";
            this.buttonLetter10.UseVisualStyleBackColor = false;
            this.buttonLetter10.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter6
            // 
            this.buttonLetter6.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter6.BackgroundImage")));
            this.buttonLetter6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter6.FlatAppearance.BorderSize = 0;
            this.buttonLetter6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter6.ForeColor = System.Drawing.Color.White;
            this.buttonLetter6.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter6.Image")));
            this.buttonLetter6.Location = new System.Drawing.Point(275, 323);
            this.buttonLetter6.Name = "buttonLetter6";
            this.buttonLetter6.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter6.TabIndex = 42;
            this.buttonLetter6.Text = "Ш";
            this.buttonLetter6.UseVisualStyleBackColor = false;
            this.buttonLetter6.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter5
            // 
            this.buttonLetter5.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter5.BackgroundImage")));
            this.buttonLetter5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter5.FlatAppearance.BorderSize = 0;
            this.buttonLetter5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter5.ForeColor = System.Drawing.Color.White;
            this.buttonLetter5.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter5.Image")));
            this.buttonLetter5.Location = new System.Drawing.Point(245, 323);
            this.buttonLetter5.Name = "buttonLetter5";
            this.buttonLetter5.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter5.TabIndex = 41;
            this.buttonLetter5.Text = "Г";
            this.buttonLetter5.UseVisualStyleBackColor = false;
            this.buttonLetter5.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter4
            // 
            this.buttonLetter4.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter4.BackgroundImage")));
            this.buttonLetter4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter4.FlatAppearance.BorderSize = 0;
            this.buttonLetter4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter4.ForeColor = System.Drawing.Color.White;
            this.buttonLetter4.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter4.Image")));
            this.buttonLetter4.Location = new System.Drawing.Point(215, 323);
            this.buttonLetter4.Name = "buttonLetter4";
            this.buttonLetter4.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter4.TabIndex = 40;
            this.buttonLetter4.Text = "Н";
            this.buttonLetter4.UseVisualStyleBackColor = false;
            this.buttonLetter4.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter3
            // 
            this.buttonLetter3.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter3.BackgroundImage")));
            this.buttonLetter3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter3.FlatAppearance.BorderSize = 0;
            this.buttonLetter3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter3.ForeColor = System.Drawing.Color.White;
            this.buttonLetter3.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter3.Image")));
            this.buttonLetter3.Location = new System.Drawing.Point(185, 323);
            this.buttonLetter3.Name = "buttonLetter3";
            this.buttonLetter3.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter3.TabIndex = 39;
            this.buttonLetter3.Text = "Е";
            this.buttonLetter3.UseVisualStyleBackColor = false;
            this.buttonLetter3.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter2
            // 
            this.buttonLetter2.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter2.BackgroundImage")));
            this.buttonLetter2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter2.FlatAppearance.BorderSize = 0;
            this.buttonLetter2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter2.ForeColor = System.Drawing.Color.White;
            this.buttonLetter2.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter2.Image")));
            this.buttonLetter2.Location = new System.Drawing.Point(155, 323);
            this.buttonLetter2.Name = "buttonLetter2";
            this.buttonLetter2.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter2.TabIndex = 38;
            this.buttonLetter2.Text = "К";
            this.buttonLetter2.UseVisualStyleBackColor = false;
            this.buttonLetter2.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter1
            // 
            this.buttonLetter1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter1.BackgroundImage")));
            this.buttonLetter1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter1.FlatAppearance.BorderSize = 0;
            this.buttonLetter1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter1.ForeColor = System.Drawing.Color.White;
            this.buttonLetter1.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter1.Image")));
            this.buttonLetter1.Location = new System.Drawing.Point(125, 323);
            this.buttonLetter1.Name = "buttonLetter1";
            this.buttonLetter1.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter1.TabIndex = 37;
            this.buttonLetter1.Text = "У";
            this.buttonLetter1.UseVisualStyleBackColor = false;
            this.buttonLetter1.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter0
            // 
            this.buttonLetter0.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter0.BackgroundImage")));
            this.buttonLetter0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter0.FlatAppearance.BorderSize = 0;
            this.buttonLetter0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter0.ForeColor = System.Drawing.Color.White;
            this.buttonLetter0.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter0.Image")));
            this.buttonLetter0.Location = new System.Drawing.Point(95, 323);
            this.buttonLetter0.Name = "buttonLetter0";
            this.buttonLetter0.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter0.TabIndex = 36;
            this.buttonLetter0.Text = "Ц";
            this.buttonLetter0.UseVisualStyleBackColor = false;
            this.buttonLetter0.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // buttonLetter11
            // 
            this.buttonLetter11.BackColor = System.Drawing.Color.Transparent;
            this.buttonLetter11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLetter11.BackgroundImage")));
            this.buttonLetter11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLetter11.FlatAppearance.BorderSize = 0;
            this.buttonLetter11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLetter11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLetter11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetter11.ForeColor = System.Drawing.Color.White;
            this.buttonLetter11.Image = ((System.Drawing.Image)(resources.GetObject("buttonLetter11.Image")));
            this.buttonLetter11.Location = new System.Drawing.Point(65, 323);
            this.buttonLetter11.Name = "buttonLetter11";
            this.buttonLetter11.Size = new System.Drawing.Size(30, 30);
            this.buttonLetter11.TabIndex = 35;
            this.buttonLetter11.Text = "Й";
            this.buttonLetter11.UseVisualStyleBackColor = false;
            this.buttonLetter11.Click += new System.EventHandler(this.ClickOnLetter);
            // 
            // GameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
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
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer start;
        private System.Windows.Forms.Timer end;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLetter23;
        private System.Windows.Forms.Button buttonLetter24;
        private System.Windows.Forms.Button buttonLetter25;
        private System.Windows.Forms.Button buttonLetter26;
        private System.Windows.Forms.Button buttonLetter27;
        private System.Windows.Forms.Button buttonLetter28;
        private System.Windows.Forms.Button buttonLetter29;
        private System.Windows.Forms.Button buttonLetter30;
        private System.Windows.Forms.Button buttonLetter31;
        private System.Windows.Forms.Button buttonLetter12;
        private System.Windows.Forms.Button buttonLetter13;
        private System.Windows.Forms.Button buttonLetter14;
        private System.Windows.Forms.Button buttonLetter15;
        private System.Windows.Forms.Button buttonLetter16;
        private System.Windows.Forms.Button buttonLetter17;
        private System.Windows.Forms.Button buttonLetter18;
        private System.Windows.Forms.Button buttonLetter19;
        private System.Windows.Forms.Button buttonLetter20;
        private System.Windows.Forms.Button buttonLetter21;
        private System.Windows.Forms.Button buttonLetter22;
        private System.Windows.Forms.Button buttonLetter7;
        private System.Windows.Forms.Button buttonLetter8;
        private System.Windows.Forms.Button buttonLetter9;
        private System.Windows.Forms.Button buttonLetter10;
        private System.Windows.Forms.Button buttonLetter6;
        private System.Windows.Forms.Button buttonLetter5;
        private System.Windows.Forms.Button buttonLetter4;
        private System.Windows.Forms.Button buttonLetter3;
        private System.Windows.Forms.Button buttonLetter2;
        private System.Windows.Forms.Button buttonLetter1;
        private System.Windows.Forms.Button buttonLetter0;
        private System.Windows.Forms.Button buttonLetter11;
    }
}

