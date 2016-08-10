namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.m_ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.m_ButtonLogin.Location = new System.Drawing.Point(211, 27);
            this.m_ButtonLogin.Name = "ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(357, 84);
            this.m_ButtonLogin.TabIndex = 2;
            this.m_ButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.m_ButtonLogin.UseVisualStyleBackColor = true;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C16_Ex01_Yoni_301812095_Idan_301911103.Properties.Resources.FacebookLogoCover;
            this.ClientSize = new System.Drawing.Size(778, 317);
            this.Controls.Add(this.m_ButtonLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonLogin;
    }
}