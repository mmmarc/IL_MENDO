﻿namespace IL_MENDO.ABM_Chofer
{
    partial class chofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chofer));
            this.button1 = new System.Windows.Forms.Button();
            this.abm_chofer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(315, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "DAR DE BAJA UN CHOFER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // abm_chofer
            // 
            this.abm_chofer.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_chofer.Location = new System.Drawing.Point(315, 157);
            this.abm_chofer.Name = "abm_chofer";
            this.abm_chofer.Size = new System.Drawing.Size(186, 52);
            this.abm_chofer.TabIndex = 0;
            this.abm_chofer.Text = "DAR DE ALTA UN CHOFER";
            this.abm_chofer.UseVisualStyleBackColor = false;
            this.abm_chofer.Click += new System.EventHandler(this.abm_chofer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(315, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 52);
            this.button3.TabIndex = 1;
            this.button3.Text = "MODIFICAR UN CHOFER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.abm_chofer);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Choferes";
            this.Load += new System.EventHandler(this.chofer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button abm_chofer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}