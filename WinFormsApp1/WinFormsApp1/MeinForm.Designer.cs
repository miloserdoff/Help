namespace WinFormsApp1
{
    partial class MeinForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spravka = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            this.vxod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 124);
            this.panel1.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(582, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главный экран";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spravka
            // 
            this.spravka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.spravka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spravka.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.spravka.FlatAppearance.BorderSize = 0;
            this.spravka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.spravka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.spravka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spravka.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spravka.ForeColor = System.Drawing.Color.White;
            this.spravka.Location = new System.Drawing.Point(462, 321);
            this.spravka.Name = "spravka";
            this.spravka.Size = new System.Drawing.Size(136, 41);
            this.spravka.TabIndex = 11;
            this.spravka.Text = "Cправка";
            this.spravka.UseVisualStyleBackColor = false;
            this.spravka.Click += new System.EventHandler(this.spravka_Click_1);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(13)))), ((int)(((byte)(62)))));
            this.reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reg.FlatAppearance.BorderSize = 2;
            this.reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reg.ForeColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(354, 194);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(178, 69);
            this.reg.TabIndex = 11;
            this.reg.Text = "Регистрация";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click_1);
            // 
            // vxod
            // 
            this.vxod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(0)))));
            this.vxod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vxod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vxod.FlatAppearance.BorderSize = 2;
            this.vxod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.vxod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.vxod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vxod.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vxod.ForeColor = System.Drawing.Color.White;
            this.vxod.Location = new System.Drawing.Point(96, 194);
            this.vxod.Name = "vxod";
            this.vxod.Size = new System.Drawing.Size(178, 69);
            this.vxod.TabIndex = 11;
            this.vxod.Text = "Вход";
            this.vxod.UseVisualStyleBackColor = false;
            this.vxod.Click += new System.EventHandler(this.vxod_Click);
            // 
            // MeinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.vxod);
            this.Controls.Add(this.spravka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeinForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label closeButton;
        private Label label1;
        private Button spravka;
        private Button reg;
        private Button vxod;
    }
}