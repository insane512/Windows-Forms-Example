namespace WindowsFormsExample
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
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.lableOutput1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelOutput3 = new System.Windows.Forms.Label();
            this.labelOutput4 = new System.Windows.Forms.Label();
            this.labelOutput5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(127, 145);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(172, 20);
            this.firstNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // lastNameTxBox
            // 
            this.lastNameTxBox.Location = new System.Drawing.Point(127, 191);
            this.lastNameTxBox.Name = "lastNameTxBox";
            this.lastNameTxBox.Size = new System.Drawing.Size(172, 20);
            this.lastNameTxBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // addressTxBox
            // 
            this.addressTxBox.Location = new System.Drawing.Point(127, 235);
            this.addressTxBox.Name = "addressTxBox";
            this.addressTxBox.Size = new System.Drawing.Size(172, 20);
            this.addressTxBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // emailTxBox
            // 
            this.emailTxBox.Location = new System.Drawing.Point(127, 280);
            this.emailTxBox.Name = "emailTxBox";
            this.emailTxBox.Size = new System.Drawing.Size(172, 20);
            this.emailTxBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // phoneTxBox
            // 
            this.phoneTxBox.Location = new System.Drawing.Point(127, 322);
            this.phoneTxBox.Name = "phoneTxBox";
            this.phoneTxBox.Size = new System.Drawing.Size(172, 20);
            this.phoneTxBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(161, 378);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(259, 378);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // lableOutput1
            // 
            this.lableOutput1.AutoSize = true;
            this.lableOutput1.Location = new System.Drawing.Point(655, 151);
            this.lableOutput1.Name = "lableOutput1";
            this.lableOutput1.Size = new System.Drawing.Size(0, 13);
            this.lableOutput1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Output";
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Location = new System.Drawing.Point(655, 179);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(0, 13);
            this.labelOutput2.TabIndex = 14;
            // 
            // labelOutput3
            // 
            this.labelOutput3.AutoSize = true;
            this.labelOutput3.Location = new System.Drawing.Point(655, 208);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Size = new System.Drawing.Size(0, 13);
            this.labelOutput3.TabIndex = 15;
            // 
            // labelOutput4
            // 
            this.labelOutput4.AutoSize = true;
            this.labelOutput4.Location = new System.Drawing.Point(655, 235);
            this.labelOutput4.Name = "labelOutput4";
            this.labelOutput4.Size = new System.Drawing.Size(0, 13);
            this.labelOutput4.TabIndex = 16;
            // 
            // labelOutput5
            // 
            this.labelOutput5.AutoSize = true;
            this.labelOutput5.Location = new System.Drawing.Point(655, 262);
            this.labelOutput5.Name = "labelOutput5";
            this.labelOutput5.Size = new System.Drawing.Size(0, 13);
            this.labelOutput5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 638);
            this.Controls.Add(this.labelOutput5);
            this.Controls.Add(this.labelOutput4);
            this.Controls.Add(this.labelOutput3);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lableOutput1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneTxBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTxBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTxBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneTxBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lableOutput1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelOutput3;
        private System.Windows.Forms.Label labelOutput4;
        private System.Windows.Forms.Label labelOutput5;
    }
}

