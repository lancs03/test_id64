namespace IdforBase64
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Akey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Dkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_encryption = new System.Windows.Forms.Button();
            this.bt_decrypt = new System.Windows.Forms.Button();
            this.la_cpuID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Akey
            // 
            this.tb_Akey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Akey.Location = new System.Drawing.Point(272, 221);
            this.tb_Akey.Multiline = true;
            this.tb_Akey.Name = "tb_Akey";
            this.tb_Akey.Size = new System.Drawing.Size(378, 78);
            this.tb_Akey.TabIndex = 8;
            this.tb_Akey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(89, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Activation Key :";
            // 
            // tb_Dkey
            // 
            this.tb_Dkey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Dkey.Location = new System.Drawing.Point(270, 74);
            this.tb_Dkey.Multiline = true;
            this.tb_Dkey.Name = "tb_Dkey";
            this.tb_Dkey.Size = new System.Drawing.Size(378, 70);
            this.tb_Dkey.TabIndex = 6;
            this.tb_Dkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Devive Key :";
            // 
            // bt_encryption
            // 
            this.bt_encryption.BackColor = System.Drawing.Color.Transparent;
            this.bt_encryption.BackgroundImage = global::IdforBase64.Properties.Resources.anniu2;
            this.bt_encryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_encryption.FlatAppearance.BorderSize = 0;
            this.bt_encryption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_encryption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_encryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_encryption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_encryption.Location = new System.Drawing.Point(170, 371);
            this.bt_encryption.Margin = new System.Windows.Forms.Padding(0);
            this.bt_encryption.Name = "bt_encryption";
            this.bt_encryption.Size = new System.Drawing.Size(187, 55);
            this.bt_encryption.TabIndex = 9;
            this.bt_encryption.Text = "Encryption";
            this.bt_encryption.UseVisualStyleBackColor = false;
            this.bt_encryption.Click += new System.EventHandler(this.bt_encryption_Click);
            this.bt_encryption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_encryption_MouseDown);
            this.bt_encryption.MouseLeave += new System.EventHandler(this.bt_encryption_MouseLeave);
            // 
            // bt_decrypt
            // 
            this.bt_decrypt.BackColor = System.Drawing.Color.Transparent;
            this.bt_decrypt.BackgroundImage = global::IdforBase64.Properties.Resources.anniu2;
            this.bt_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_decrypt.FlatAppearance.BorderSize = 0;
            this.bt_decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_decrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_decrypt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_decrypt.Location = new System.Drawing.Point(433, 371);
            this.bt_decrypt.Margin = new System.Windows.Forms.Padding(0);
            this.bt_decrypt.Name = "bt_decrypt";
            this.bt_decrypt.Size = new System.Drawing.Size(187, 55);
            this.bt_decrypt.TabIndex = 10;
            this.bt_decrypt.Text = "Decrypt";
            this.bt_decrypt.UseVisualStyleBackColor = false;
            this.bt_decrypt.Click += new System.EventHandler(this.bt_decrypt_Click);
            this.bt_decrypt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_decrypt_MouseDown);
            this.bt_decrypt.MouseEnter += new System.EventHandler(this.bt_decrypt_MouseEnter);
            this.bt_decrypt.MouseLeave += new System.EventHandler(this.bt_decrypt_MouseLeave);
            this.bt_decrypt.MouseHover += new System.EventHandler(this.bt_decrypt_MouseHover);
            // 
            // la_cpuID
            // 
            this.la_cpuID.AutoSize = true;
            this.la_cpuID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.la_cpuID.Location = new System.Drawing.Point(267, 150);
            this.la_cpuID.Name = "la_cpuID";
            this.la_cpuID.Size = new System.Drawing.Size(0, 19);
            this.la_cpuID.TabIndex = 11;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(774, 493);
            this.Controls.Add(this.la_cpuID);
            this.Controls.Add(this.bt_decrypt);
            this.Controls.Add(this.bt_encryption);
            this.Controls.Add(this.tb_Akey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Dkey);
            this.Controls.Add(this.label1);
            this.EffectBack = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Akey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Dkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_encryption;
        private System.Windows.Forms.Button bt_decrypt;
        private System.Windows.Forms.Label la_cpuID;
    }
}

