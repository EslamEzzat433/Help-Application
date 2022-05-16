
namespace VisualProgramingProject.Forms
{
    partial class Paint_Form
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
            this.btnWhite = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnBlack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btnWhite);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnWhite
            // 
            this.btnWhite.BorderRadius = 20;
            this.btnWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWhite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWhite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWhite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWhite.FillColor = System.Drawing.Color.White;
            this.btnWhite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWhite.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.Location = new System.Drawing.Point(179, 4);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.PressedColor = System.Drawing.Color.Brown;
            this.btnWhite.Size = new System.Drawing.Size(141, 60);
            this.btnWhite.TabIndex = 41;
            this.btnWhite.Text = "White Mode";
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClear.Location = new System.Drawing.Point(619, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClear.Size = new System.Drawing.Size(148, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BorderRadius = 20;
            this.btnBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBlack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBlack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBlack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBlack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBlack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBlack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(32, 4);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(141, 60);
            this.btnBlack.TabIndex = 41;
            this.btnBlack.Text = "Dark Mode";
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(336, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Brown;
            this.guna2Button1.Size = new System.Drawing.Size(141, 60);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Pen Color";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Paint_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 623);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paint_Form";
            this.Text = "Paint_Form";
            this.Load += new System.EventHandler(this.Paint_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnClear;
        private Guna.UI2.WinForms.Guna2Button btnWhite;
        private Guna.UI2.WinForms.Guna2Button btnBlack;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}