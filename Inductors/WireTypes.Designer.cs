namespace Inductors
{
    partial class WireTypes
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
            this.add_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.listBox_wireTypes = new System.Windows.Forms.ListBox();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add_button.Location = new System.Drawing.Point(143, 33);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(142, 170);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(82, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete_button.Location = new System.Drawing.Point(143, 112);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(82, 23);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // listBox_wireTypes
            // 
            this.listBox_wireTypes.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_wireTypes.FormattingEnabled = true;
            this.listBox_wireTypes.HorizontalScrollbar = true;
            this.listBox_wireTypes.ItemHeight = 18;
            this.listBox_wireTypes.Location = new System.Drawing.Point(7, 7);
            this.listBox_wireTypes.Name = "listBox_wireTypes";
            this.listBox_wireTypes.Size = new System.Drawing.Size(112, 184);
            this.listBox_wireTypes.TabIndex = 5;
            this.listBox_wireTypes.SelectedIndexChanged += new System.EventHandler(this.listBox_wireTypes_SelectedIndexChanged);
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(143, 86);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.ReadOnly = true;
            this.textBox_delete.Size = new System.Drawing.Size(81, 20);
            this.textBox_delete.TabIndex = 6;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(143, 7);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(82, 20);
            this.textBox_add.TabIndex = 7;
            // 
            // WireTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 199);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.listBox_wireTypes);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WireTypes";
            this.Text = "Типы проводов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ListBox listBox_wireTypes;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.TextBox textBox_add;
    }
}