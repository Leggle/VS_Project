namespace WinFormTest
{
    partial class Form1
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
            this.Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.AName = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Destroy = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.SetMB = new System.Windows.Forms.Button();
            this.GetMB = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(34, 145);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(196, 51);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(34, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(136, 31);
            this.ID.TabIndex = 2;
            // 
            // AName
            // 
            this.AName.Location = new System.Drawing.Point(199, 91);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(136, 31);
            this.AName.TabIndex = 2;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(352, 91);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(136, 31);
            this.Balance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balance";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Destroy
            // 
            this.Destroy.Location = new System.Drawing.Point(292, 145);
            this.Destroy.Name = "Destroy";
            this.Destroy.Size = new System.Drawing.Size(196, 51);
            this.Destroy.TabIndex = 0;
            this.Destroy.Text = "Destroy";
            this.Destroy.UseVisualStyleBackColor = true;
            this.Destroy.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(34, 242);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(196, 51);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetMB
            // 
            this.SetMB.Location = new System.Drawing.Point(34, 335);
            this.SetMB.Name = "SetMB";
            this.SetMB.Size = new System.Drawing.Size(196, 51);
            this.SetMB.TabIndex = 0;
            this.SetMB.Text = "Set MB";
            this.SetMB.UseVisualStyleBackColor = true;
            this.SetMB.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetMB
            // 
            this.GetMB.Location = new System.Drawing.Point(34, 434);
            this.GetMB.Name = "GetMB";
            this.GetMB.Size = new System.Drawing.Size(196, 51);
            this.GetMB.TabIndex = 0;
            this.GetMB.Text = "Get MB";
            this.GetMB.UseVisualStyleBackColor = true;
            this.GetMB.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 31);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 335);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 31);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(292, 434);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 31);
            this.textBox6.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 649);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.AName);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetMB);
            this.Controls.Add(this.SetMB);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Destroy);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox AName;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Destroy;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button SetMB;
        private System.Windows.Forms.Button GetMB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

