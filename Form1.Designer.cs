
namespace double_pendulum
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
            this.components = new System.ComponentModel.Container();
            this.AnT1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.gB_input = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tB_tau = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tB_weight2 = new System.Windows.Forms.TextBox();
            this.button_watch = new System.Windows.Forms.Button();
            this.tB_weight1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.tB_w2 = new System.Windows.Forms.TextBox();
            this.tB_phi2 = new System.Windows.Forms.TextBox();
            this.tB_w1 = new System.Windows.Forms.TextBox();
            this.tB_phi1 = new System.Windows.Forms.TextBox();
            this.tB_length2 = new System.Windows.Forms.TextBox();
            this.tB_length1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_pause = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.AnT2 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.gB_output = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label_w2 = new System.Windows.Forms.Label();
            this.label_w1 = new System.Windows.Forms.Label();
            this.label_phi2 = new System.Windows.Forms.Label();
            this.label_phi1 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gB_input.SuspendLayout();
            this.gB_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnT1
            // 
            this.AnT1.AccumBits = ((byte)(0));
            this.AnT1.AutoCheckErrors = false;
            this.AnT1.AutoFinish = false;
            this.AnT1.AutoMakeCurrent = true;
            this.AnT1.AutoSwapBuffers = true;
            this.AnT1.BackColor = System.Drawing.Color.Black;
            this.AnT1.ColorBits = ((byte)(32));
            this.AnT1.DepthBits = ((byte)(16));
            this.AnT1.Location = new System.Drawing.Point(5, 5);
            this.AnT1.Name = "AnT1";
            this.AnT1.Size = new System.Drawing.Size(300, 300);
            this.AnT1.StencilBits = ((byte)(0));
            this.AnT1.TabIndex = 0;
            // 
            // gB_input
            // 
            this.gB_input.Controls.Add(this.label30);
            this.gB_input.Controls.Add(this.tB_tau);
            this.gB_input.Controls.Add(this.label29);
            this.gB_input.Controls.Add(this.label23);
            this.gB_input.Controls.Add(this.label22);
            this.gB_input.Controls.Add(this.label21);
            this.gB_input.Controls.Add(this.label20);
            this.gB_input.Controls.Add(this.label19);
            this.gB_input.Controls.Add(this.label18);
            this.gB_input.Controls.Add(this.label17);
            this.gB_input.Controls.Add(this.label16);
            this.gB_input.Controls.Add(this.tB_weight2);
            this.gB_input.Controls.Add(this.button_watch);
            this.gB_input.Controls.Add(this.tB_weight1);
            this.gB_input.Controls.Add(this.label7);
            this.gB_input.Controls.Add(this.label8);
            this.gB_input.Controls.Add(this.button_apply);
            this.gB_input.Controls.Add(this.tB_w2);
            this.gB_input.Controls.Add(this.tB_phi2);
            this.gB_input.Controls.Add(this.tB_w1);
            this.gB_input.Controls.Add(this.tB_phi1);
            this.gB_input.Controls.Add(this.tB_length2);
            this.gB_input.Controls.Add(this.tB_length1);
            this.gB_input.Controls.Add(this.label6);
            this.gB_input.Controls.Add(this.label5);
            this.gB_input.Controls.Add(this.label4);
            this.gB_input.Controls.Add(this.label3);
            this.gB_input.Controls.Add(this.label2);
            this.gB_input.Controls.Add(this.label1);
            this.gB_input.Location = new System.Drawing.Point(311, 5);
            this.gB_input.Name = "gB_input";
            this.gB_input.Size = new System.Drawing.Size(147, 300);
            this.gB_input.TabIndex = 1;
            this.gB_input.TabStop = false;
            this.gB_input.Text = "Входные данные:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(102, 221);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "с";
            // 
            // tB_tau
            // 
            this.tB_tau.Location = new System.Drawing.Point(62, 218);
            this.tB_tau.Name = "tB_tau";
            this.tB_tau.Size = new System.Drawing.Size(36, 20);
            this.tB_tau.TabIndex = 29;
            this.tB_tau.Text = "0,01";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "tau:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(99, 197);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "рад/с";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(99, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "рад/с";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(99, 171);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "°";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(102, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "°";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(102, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "кг";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(102, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "кг";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "см";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "см";
            // 
            // tB_weight2
            // 
            this.tB_weight2.Location = new System.Drawing.Point(63, 89);
            this.tB_weight2.Name = "tB_weight2";
            this.tB_weight2.Size = new System.Drawing.Size(35, 20);
            this.tB_weight2.TabIndex = 17;
            this.tB_weight2.Text = "1";
            // 
            // button_watch
            // 
            this.button_watch.Location = new System.Drawing.Point(20, 239);
            this.button_watch.Name = "button_watch";
            this.button_watch.Size = new System.Drawing.Size(85, 23);
            this.button_watch.TabIndex = 19;
            this.button_watch.Text = "Посмотреть";
            this.button_watch.UseVisualStyleBackColor = true;
            this.button_watch.Click += new System.EventHandler(this.button_watch_Click);
            // 
            // tB_weight1
            // 
            this.tB_weight1.Location = new System.Drawing.Point(63, 64);
            this.tB_weight1.Name = "tB_weight1";
            this.tB_weight1.Size = new System.Drawing.Size(35, 20);
            this.tB_weight1.TabIndex = 16;
            this.tB_weight1.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "m2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "m1:";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(20, 268);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(85, 23);
            this.button_apply.TabIndex = 13;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // tB_w2
            // 
            this.tB_w2.Location = new System.Drawing.Point(62, 194);
            this.tB_w2.Name = "tB_w2";
            this.tB_w2.Size = new System.Drawing.Size(36, 20);
            this.tB_w2.TabIndex = 12;
            this.tB_w2.Text = "0";
            // 
            // tB_phi2
            // 
            this.tB_phi2.Location = new System.Drawing.Point(62, 168);
            this.tB_phi2.Name = "tB_phi2";
            this.tB_phi2.Size = new System.Drawing.Size(36, 20);
            this.tB_phi2.TabIndex = 10;
            this.tB_phi2.Text = "180";
            // 
            // tB_w1
            // 
            this.tB_w1.Location = new System.Drawing.Point(63, 142);
            this.tB_w1.Name = "tB_w1";
            this.tB_w1.Size = new System.Drawing.Size(35, 20);
            this.tB_w1.TabIndex = 9;
            this.tB_w1.Text = "0";
            // 
            // tB_phi1
            // 
            this.tB_phi1.Location = new System.Drawing.Point(63, 115);
            this.tB_phi1.Name = "tB_phi1";
            this.tB_phi1.Size = new System.Drawing.Size(35, 20);
            this.tB_phi1.TabIndex = 8;
            this.tB_phi1.Text = "180";
            // 
            // tB_length2
            // 
            this.tB_length2.Location = new System.Drawing.Point(64, 38);
            this.tB_length2.Name = "tB_length2";
            this.tB_length2.Size = new System.Drawing.Size(34, 20);
            this.tB_length2.TabIndex = 7;
            this.tB_length2.Text = "10";
            // 
            // tB_length1
            // 
            this.tB_length1.Location = new System.Drawing.Point(64, 13);
            this.tB_length1.Name = "tB_length1";
            this.tB_length1.Size = new System.Drawing.Size(34, 20);
            this.tB_length1.TabIndex = 6;
            this.tB_length1.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "phi2(0):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "phi2\'(0):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "phi1\'(0):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "phi1(0):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "L2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "L1:";
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(21, 155);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(81, 23);
            this.button_pause.TabIndex = 18;
            this.button_pause.Text = "Пауза";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AnT2
            // 
            this.AnT2.AccumBits = ((byte)(0));
            this.AnT2.AutoCheckErrors = false;
            this.AnT2.AutoFinish = false;
            this.AnT2.AutoMakeCurrent = true;
            this.AnT2.AutoSwapBuffers = true;
            this.AnT2.BackColor = System.Drawing.Color.Black;
            this.AnT2.ColorBits = ((byte)(32));
            this.AnT2.DepthBits = ((byte)(16));
            this.AnT2.Location = new System.Drawing.Point(5, 311);
            this.AnT2.Name = "AnT2";
            this.AnT2.Size = new System.Drawing.Size(440, 220);
            this.AnT2.StencilBits = ((byte)(0));
            this.AnT2.TabIndex = 4;
            // 
            // gB_output
            // 
            this.gB_output.Controls.Add(this.button_stop);
            this.gB_output.Controls.Add(this.label28);
            this.gB_output.Controls.Add(this.label27);
            this.gB_output.Controls.Add(this.label26);
            this.gB_output.Controls.Add(this.label25);
            this.gB_output.Controls.Add(this.label24);
            this.gB_output.Controls.Add(this.button_pause);
            this.gB_output.Controls.Add(this.label_w2);
            this.gB_output.Controls.Add(this.label_w1);
            this.gB_output.Controls.Add(this.label_phi2);
            this.gB_output.Controls.Add(this.label_phi1);
            this.gB_output.Controls.Add(this.label_Time);
            this.gB_output.Controls.Add(this.label12);
            this.gB_output.Controls.Add(this.label13);
            this.gB_output.Controls.Add(this.label11);
            this.gB_output.Controls.Add(this.label10);
            this.gB_output.Controls.Add(this.label9);
            this.gB_output.Location = new System.Drawing.Point(464, 5);
            this.gB_output.Name = "gB_output";
            this.gB_output.Size = new System.Drawing.Size(119, 223);
            this.gB_output.TabIndex = 5;
            this.gB_output.TabStop = false;
            this.gB_output.Text = "Выходные данные:";
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(21, 184);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(81, 23);
            this.button_stop.TabIndex = 31;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(82, 131);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "рад/с";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(82, 105);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "рад/с";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(79, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "°";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(79, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "°";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(100, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 28;
            this.label24.Text = "с";
            // 
            // label_w2
            // 
            this.label_w2.AutoSize = true;
            this.label_w2.Location = new System.Drawing.Point(42, 131);
            this.label_w2.Name = "label_w2";
            this.label_w2.Size = new System.Drawing.Size(13, 13);
            this.label_w2.TabIndex = 9;
            this.label_w2.Text = "0";
            // 
            // label_w1
            // 
            this.label_w1.AutoSize = true;
            this.label_w1.Location = new System.Drawing.Point(42, 105);
            this.label_w1.Name = "label_w1";
            this.label_w1.Size = new System.Drawing.Size(13, 13);
            this.label_w1.TabIndex = 8;
            this.label_w1.Text = "0";
            // 
            // label_phi2
            // 
            this.label_phi2.AutoSize = true;
            this.label_phi2.Location = new System.Drawing.Point(55, 80);
            this.label_phi2.Name = "label_phi2";
            this.label_phi2.Size = new System.Drawing.Size(13, 13);
            this.label_phi2.TabIndex = 7;
            this.label_phi2.Text = "0";
            // 
            // label_phi1
            // 
            this.label_phi1.AutoSize = true;
            this.label_phi1.Location = new System.Drawing.Point(55, 54);
            this.label_phi1.Name = "label_phi1";
            this.label_phi1.Size = new System.Drawing.Size(13, 13);
            this.label_phi1.TabIndex = 6;
            this.label_phi1.Text = "0";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(55, 29);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(13, 13);
            this.label_Time.TabIndex = 5;
            this.label_Time.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "w2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "w1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "phi2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "phi1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Время:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 536);
            this.Controls.Add(this.gB_output);
            this.Controls.Add(this.AnT2);
            this.Controls.Add(this.gB_input);
            this.Controls.Add(this.AnT1);
            this.Name = "Form1";
            this.Text = "Двойной маятник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB_input.ResumeLayout(false);
            this.gB_input.PerformLayout();
            this.gB_output.ResumeLayout(false);
            this.gB_output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT1;
        private System.Windows.Forms.GroupBox gB_input;
        private System.Windows.Forms.TextBox tB_length1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox tB_w2;
        private System.Windows.Forms.TextBox tB_phi2;
        private System.Windows.Forms.TextBox tB_w1;
        private System.Windows.Forms.TextBox tB_phi1;
        private System.Windows.Forms.TextBox tB_length2;
        private System.Windows.Forms.TextBox tB_weight2;
        private System.Windows.Forms.TextBox tB_weight1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_pause;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT2;
        private System.Windows.Forms.GroupBox gB_output;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_watch;
        private System.Windows.Forms.Label label_w2;
        private System.Windows.Forms.Label label_w1;
        private System.Windows.Forms.Label label_phi2;
        private System.Windows.Forms.Label label_phi1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tB_tau;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label30;
    }
}

