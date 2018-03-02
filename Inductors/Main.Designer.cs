namespace Inductors
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WireTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_section_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_example = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_diameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_section_width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_between_sections = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_num = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_different = new System.Windows.Forms.RadioButton();
            this.radioButton_same = new System.Windows.Forms.RadioButton();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_wire_type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_wire_diameter = new System.Windows.Forms.ComboBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label_sectionNumError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_num)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.MethodToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WireTypesToolStripMenuItem,
            this.ReadmeToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // WireTypesToolStripMenuItem
            // 
            this.WireTypesToolStripMenuItem.Name = "WireTypesToolStripMenuItem";
            this.WireTypesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.WireTypesToolStripMenuItem.Text = "Ввести новый провод";
            this.WireTypesToolStripMenuItem.Click += new System.EventHandler(this.WireTypesToolStripMenuItem_Click);
            // 
            // ReadmeToolStripMenuItem
            // 
            this.ReadmeToolStripMenuItem.Name = "ReadmeToolStripMenuItem";
            this.ReadmeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ReadmeToolStripMenuItem.Text = "Подробности";
            this.ReadmeToolStripMenuItem.Click += new System.EventHandler(this.ReadmeToolStripMenuItem_Click);
            // 
            // MethodToolStripMenuItem
            // 
            this.MethodToolStripMenuItem.Name = "MethodToolStripMenuItem";
            this.MethodToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.MethodToolStripMenuItem.Text = "Методика расчета";
            this.MethodToolStripMenuItem.Click += new System.EventHandler(this.MethodToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число секций";
            // 
            // textBox_section_num
            // 
            this.textBox_section_num.Location = new System.Drawing.Point(163, 0);
            this.textBox_section_num.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_section_num.Multiline = true;
            this.textBox_section_num.Name = "textBox_section_num";
            this.textBox_section_num.Size = new System.Drawing.Size(92, 22);
            this.textBox_section_num.TabIndex = 2;
            this.textBox_section_num.TextChanged += new System.EventHandler(this.textBox_section_num_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(318, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Одинаковое";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(318, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число витков в секциях";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(462, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Разное";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_reset.Location = new System.Drawing.Point(758, 0);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(117, 30);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Обнулить";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_example
            // 
            this.button_example.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_example.Location = new System.Drawing.Point(613, 0);
            this.button_example.Margin = new System.Windows.Forms.Padding(4);
            this.button_example.Name = "button_example";
            this.button_example.Size = new System.Drawing.Size(117, 30);
            this.button_example.TabIndex = 9;
            this.button_example.Text = "Пример";
            this.button_example.UseVisualStyleBackColor = false;
            this.button_example.Click += new System.EventHandler(this.button_example_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Диаметр каркаса";
            // 
            // textBox_diameter
            // 
            this.textBox_diameter.BackColor = System.Drawing.Color.White;
            this.textBox_diameter.Location = new System.Drawing.Point(163, 45);
            this.textBox_diameter.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_diameter.Name = "textBox_diameter";
            this.textBox_diameter.Size = new System.Drawing.Size(92, 22);
            this.textBox_diameter.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(7, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ширина секций";
            // 
            // textBox_section_width
            // 
            this.textBox_section_width.Location = new System.Drawing.Point(163, 90);
            this.textBox_section_width.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_section_width.Name = "textBox_section_width";
            this.textBox_section_width.Size = new System.Drawing.Size(92, 22);
            this.textBox_section_width.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(7, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Расстояние \r\nмежду секциями";
            // 
            // textBox_between_sections
            // 
            this.textBox_between_sections.BackColor = System.Drawing.Color.White;
            this.textBox_between_sections.Location = new System.Drawing.Point(163, 135);
            this.textBox_between_sections.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_between_sections.Name = "textBox_between_sections";
            this.textBox_between_sections.Size = new System.Drawing.Size(92, 22);
            this.textBox_between_sections.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(262, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(262, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Location = new System.Drawing.Point(262, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "мм";
            // 
            // dataGridView_num
            // 
            this.dataGridView_num.AllowUserToAddRows = false;
            this.dataGridView_num.AllowUserToDeleteRows = false;
            this.dataGridView_num.AllowUserToResizeColumns = false;
            this.dataGridView_num.AllowUserToResizeRows = false;
            this.dataGridView_num.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_num.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_num.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_num.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_num.ColumnHeadersVisible = false;
            this.dataGridView_num.Location = new System.Drawing.Point(334, 65);
            this.dataGridView_num.Name = "dataGridView_num";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_num.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_num.RowHeadersWidth = 53;
            this.dataGridView_num.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_num.Size = new System.Drawing.Size(173, 92);
            this.dataGridView_num.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.radioButton_different);
            this.panel1.Controls.Add(this.radioButton_same);
            this.panel1.Location = new System.Drawing.Point(340, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 18);
            this.panel1.TabIndex = 22;
            // 
            // radioButton_different
            // 
            this.radioButton_different.AutoSize = true;
            this.radioButton_different.Location = new System.Drawing.Point(150, 2);
            this.radioButton_different.Name = "radioButton_different";
            this.radioButton_different.Size = new System.Drawing.Size(14, 13);
            this.radioButton_different.TabIndex = 24;
            this.radioButton_different.TabStop = true;
            this.radioButton_different.UseVisualStyleBackColor = true;
            this.radioButton_different.CheckedChanged += new System.EventHandler(this.radioButton_different_CheckedChanged);
            // 
            // radioButton_same
            // 
            this.radioButton_same.AutoSize = true;
            this.radioButton_same.Location = new System.Drawing.Point(15, 2);
            this.radioButton_same.Name = "radioButton_same";
            this.radioButton_same.Size = new System.Drawing.Size(14, 13);
            this.radioButton_same.TabIndex = 23;
            this.radioButton_same.TabStop = true;
            this.radioButton_same.UseVisualStyleBackColor = true;
            this.radioButton_same.CheckedChanged += new System.EventHandler(this.radioButton_different_CheckedChanged);
            // 
            // button_calculate
            // 
            this.button_calculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_calculate.Location = new System.Drawing.Point(758, 127);
            this.button_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(117, 30);
            this.button_calculate.TabIndex = 23;
            this.button_calculate.Text = "Рассчитать";
            this.button_calculate.UseVisualStyleBackColor = false;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Location = new System.Drawing.Point(569, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Тип";
            // 
            // comboBox_wire_type
            // 
            this.comboBox_wire_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wire_type.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_wire_type.FormattingEnabled = true;
            this.comboBox_wire_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_wire_type.Location = new System.Drawing.Point(609, 89);
            this.comboBox_wire_type.Name = "comboBox_wire_type";
            this.comboBox_wire_type.Size = new System.Drawing.Size(121, 26);
            this.comboBox_wire_type.TabIndex = 25;
            this.comboBox_wire_type.SelectionChangeCommitted += new System.EventHandler(this.comboBox_wire_type_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Location = new System.Drawing.Point(533, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 30);
            this.label13.TabIndex = 26;
            this.label13.Text = "Диаметр\r\nпо меди";
            // 
            // comboBox_wire_diameter
            // 
            this.comboBox_wire_diameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wire_diameter.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_wire_diameter.FormattingEnabled = true;
            this.comboBox_wire_diameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_wire_diameter.Location = new System.Drawing.Point(609, 131);
            this.comboBox_wire_diameter.Name = "comboBox_wire_diameter";
            this.comboBox_wire_diameter.Size = new System.Drawing.Size(121, 26);
            this.comboBox_wire_diameter.TabIndex = 27;
            this.comboBox_wire_diameter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_wire_diameter_SelectionChangeCommitted);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result.Location = new System.Drawing.Point(759, 65);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(117, 51);
            this.label_result.TabIndex = 28;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(773, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Результат";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label_sectionNumError);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label_result);
            this.panel2.Controls.Add(this.comboBox_wire_diameter);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox_wire_type);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button_calculate);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dataGridView_num);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_between_sections);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_section_width);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_diameter);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_example);
            this.panel2.Controls.Add(this.button_reset);
            this.panel2.Controls.Add(this.textBox_section_num);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 166);
            this.panel2.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Провод";
            // 
            // label_sectionNumError
            // 
            this.label_sectionNumError.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sectionNumError.Location = new System.Drawing.Point(8, 26);
            this.label_sectionNumError.Name = "label_sectionNumError";
            this.label_sectionNumError.Size = new System.Drawing.Size(307, 18);
            this.label_sectionNumError.TabIndex = 30;
            this.label_sectionNumError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(880, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Калькулятор для расчета индуктивности многосекционных катушек и дросселей с намот" +
                "кой \"Универсаль\"";
            // 
            // panelDraw
            // 
            this.panelDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDraw.AutoScroll = true;
            this.panelDraw.AutoSize = true;
            this.panelDraw.Location = new System.Drawing.Point(0, 245);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(887, 214);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            this.panelDraw.Resize += new System.EventHandler(this.panelDraw_Resize);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(896, 464);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Расчет индуктивности катушек \"Универсаль\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_num)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_section_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_example;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_diameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_section_width;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_between_sections;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_different;
        private System.Windows.Forms.RadioButton radioButton_same;
        private System.Windows.Forms.DataGridView dataGridView_num;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_wire_type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_wire_diameter;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label_sectionNumError;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WireTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReadmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MethodToolStripMenuItem;
        private System.Windows.Forms.Label label11;

    }
}

