namespace RSAForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblBanRo = new Label();
            lblBanMa = new Label();
            txtBanRo1 = new TextBox();
            txtBanMa1 = new TextBox();
            btnFileBanRo = new Button();
            btnMaHoa = new Button();
            btnChuyen = new Button();
            btnLuu = new Button();
            label2 = new Label();
            lblBanMa2 = new Label();
            txtBanMa2 = new TextBox();
            btnFile2 = new Button();
            lblBanRo2 = new Label();
            txtBanRo2 = new TextBox();
            btnGiaiMa = new Button();
            btnLuu2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 39);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa";
            // 
            // lblBanRo
            // 
            lblBanRo.AutoSize = true;
            lblBanRo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanRo.Location = new Point(46, 100);
            lblBanRo.Name = "lblBanRo";
            lblBanRo.Size = new Size(60, 23);
            lblBanRo.TabIndex = 1;
            lblBanRo.Text = "Bản rõ";
            // 
            // lblBanMa
            // 
            lblBanMa.AutoSize = true;
            lblBanMa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanMa.Location = new Point(46, 256);
            lblBanMa.Name = "lblBanMa";
            lblBanMa.Size = new Size(68, 23);
            lblBanMa.TabIndex = 2;
            lblBanMa.Text = "Bản mã";
            // 
            // txtBanRo1
            // 
            txtBanRo1.Location = new Point(147, 88);
            txtBanRo1.Multiline = true;
            txtBanRo1.Name = "txtBanRo1";
            txtBanRo1.Size = new Size(186, 56);
            txtBanRo1.TabIndex = 3;
            // 
            // txtBanMa1
            // 
            txtBanMa1.Location = new Point(147, 247);
            txtBanMa1.Multiline = true;
            txtBanMa1.Name = "txtBanMa1";
            txtBanMa1.ReadOnly = true;
            txtBanMa1.Size = new Size(186, 56);
            txtBanMa1.TabIndex = 4;
            // 
            // btnFileBanRo
            // 
            btnFileBanRo.BackColor = SystemColors.ActiveCaption;
            btnFileBanRo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileBanRo.Location = new Point(398, 106);
            btnFileBanRo.Name = "btnFileBanRo";
            btnFileBanRo.Size = new Size(94, 29);
            btnFileBanRo.TabIndex = 5;
            btnFileBanRo.Text = "File";
            btnFileBanRo.UseVisualStyleBackColor = false;
            btnFileBanRo.Click += btnFileBanRo_Click;
            // 
            // btnMaHoa
            // 
            btnMaHoa.BackColor = SystemColors.ActiveCaption;
            btnMaHoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaHoa.Location = new Point(206, 169);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(94, 29);
            btnMaHoa.TabIndex = 6;
            btnMaHoa.Text = "Mã hóa";
            btnMaHoa.UseVisualStyleBackColor = false;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // btnChuyen
            // 
            btnChuyen.BackColor = SystemColors.ActiveCaption;
            btnChuyen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnChuyen.Location = new Point(398, 239);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(94, 29);
            btnChuyen.TabIndex = 7;
            btnChuyen.Text = "Chuyển";
            btnChuyen.UseVisualStyleBackColor = false;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ActiveCaption;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(398, 285);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(614, 53);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 9;
            label2.Text = "Giải mã";
            // 
            // lblBanMa2
            // 
            lblBanMa2.AutoSize = true;
            lblBanMa2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanMa2.Location = new Point(590, 108);
            lblBanMa2.Name = "lblBanMa2";
            lblBanMa2.Size = new Size(68, 23);
            lblBanMa2.TabIndex = 10;
            lblBanMa2.Text = "Bản mã";
            // 
            // txtBanMa2
            // 
            txtBanMa2.Location = new Point(720, 99);
            txtBanMa2.Multiline = true;
            txtBanMa2.Name = "txtBanMa2";
            txtBanMa2.Size = new Size(186, 56);
            txtBanMa2.TabIndex = 11;
            txtBanMa2.TextChanged += txtBanMa2_TextChanged;
            // 
            // btnFile2
            // 
            btnFile2.BackColor = SystemColors.ActiveCaption;
            btnFile2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnFile2.Location = new Point(924, 102);
            btnFile2.Name = "btnFile2";
            btnFile2.Size = new Size(94, 29);
            btnFile2.TabIndex = 12;
            btnFile2.Text = "File";
            btnFile2.UseVisualStyleBackColor = false;
            btnFile2.Click += btnFile2_Click;
            // 
            // lblBanRo2
            // 
            lblBanRo2.AutoSize = true;
            lblBanRo2.BackColor = Color.Transparent;
            lblBanRo2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanRo2.Location = new Point(590, 272);
            lblBanRo2.Name = "lblBanRo2";
            lblBanRo2.Size = new Size(60, 23);
            lblBanRo2.TabIndex = 13;
            lblBanRo2.Text = "Bản rõ";
            // 
            // txtBanRo2
            // 
            txtBanRo2.Location = new Point(720, 247);
            txtBanRo2.Multiline = true;
            txtBanRo2.Name = "txtBanRo2";
            txtBanRo2.ReadOnly = true;
            txtBanRo2.Size = new Size(186, 56);
            txtBanRo2.TabIndex = 14;
            // 
            // btnGiaiMa
            // 
            btnGiaiMa.BackColor = SystemColors.ActiveCaption;
            btnGiaiMa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiaiMa.Location = new Point(769, 167);
            btnGiaiMa.Name = "btnGiaiMa";
            btnGiaiMa.Size = new Size(94, 29);
            btnGiaiMa.TabIndex = 15;
            btnGiaiMa.Text = "Giải mã";
            btnGiaiMa.UseVisualStyleBackColor = false;
            btnGiaiMa.Click += btnGiaiMa_Click;
            // 
            // btnLuu2
            // 
            btnLuu2.BackColor = SystemColors.ActiveCaption;
            btnLuu2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu2.Location = new Point(924, 274);
            btnLuu2.Name = "btnLuu2";
            btnLuu2.Size = new Size(94, 29);
            btnLuu2.TabIndex = 16;
            btnLuu2.Text = "Lưu";
            btnLuu2.UseVisualStyleBackColor = false;
            btnLuu2.Click += btnLuu2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1041, 450);
            Controls.Add(btnLuu2);
            Controls.Add(btnGiaiMa);
            Controls.Add(txtBanRo2);
            Controls.Add(lblBanRo2);
            Controls.Add(btnFile2);
            Controls.Add(txtBanMa2);
            Controls.Add(lblBanMa2);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Controls.Add(btnChuyen);
            Controls.Add(btnMaHoa);
            Controls.Add(btnFileBanRo);
            Controls.Add(txtBanMa1);
            Controls.Add(txtBanRo1);
            Controls.Add(lblBanMa);
            Controls.Add(lblBanRo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RSA_Encrypt-Decrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBanRo;
        private Label lblBanMa;
        private TextBox txtBanRo1;
        private TextBox txtBanMa1;
        private Button btnFileBanRo;
        private Button btnMaHoa;
        private Button btnChuyen;
        private Button btnLuu;
        private Label label2;
        private Label lblBanMa2;
        private TextBox txtBanMa2;
        private Button btnFile2;
        private Label lblBanRo2;
        private TextBox txtBanRo2;
        private Button btnGiaiMa;
        private Button btnLuu2;
    }
}