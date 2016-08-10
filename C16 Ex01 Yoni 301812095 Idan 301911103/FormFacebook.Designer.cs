using System;
using System.Drawing;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    partial class FormFacebook
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
            this.CoverpictureBox = new System.Windows.Forms.PictureBox();
            this.ProfielpictureBox = new System.Windows.Forms.PictureBox();
            this.FirsrNamelabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.PostextBox = new System.Windows.Forms.TextBox();
            this.PostButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FriendpictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxWall = new System.Windows.Forms.ListBox();
            this.labelLikeNumberToPost = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchLikers = new System.Windows.Forms.TextBox();
            this.pictureBoxWall = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLoadPosta = new System.Windows.Forms.Button();
            this.textBoxBlessing = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIsFemaleBlessing = new System.Windows.Forms.CheckBox();
            this.buttonBlessFriends = new System.Windows.Forms.Button();
            this.buttonSaveBlessing = new System.Windows.Forms.Button();
            this.listBoxGreeting = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoverpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfielpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).BeginInit();
            this.SuspendLayout();
            // 
            // CoverpictureBox
            // 
            this.CoverpictureBox.Location = new System.Drawing.Point(1, 0);
            this.CoverpictureBox.Name = "CoverpictureBox";
            this.CoverpictureBox.Size = new System.Drawing.Size(574, 518);
            this.CoverpictureBox.TabIndex = 0;
            this.CoverpictureBox.TabStop = false;
            // 
            // ProfielpictureBox
            // 
            this.ProfielpictureBox.Location = new System.Drawing.Point(27, 31);
            this.ProfielpictureBox.Name = "ProfielpictureBox";
            this.ProfielpictureBox.Size = new System.Drawing.Size(180, 189);
            this.ProfielpictureBox.TabIndex = 1;
            this.ProfielpictureBox.TabStop = false;
            // 
            // FirsrNamelabel
            // 
            this.FirsrNamelabel.AutoSize = true;
            this.FirsrNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.FirsrNamelabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirsrNamelabel.Location = new System.Drawing.Point(213, 31);
            this.FirsrNamelabel.Name = "FirsrNamelabel";
            this.FirsrNamelabel.Size = new System.Drawing.Size(69, 24);
            this.FirsrNamelabel.TabIndex = 3;
            this.FirsrNamelabel.Text = "label2";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.LastNamelabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.Location = new System.Drawing.Point(215, 65);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(69, 24);
            this.LastNamelabel.TabIndex = 4;
            this.LastNamelabel.Text = "label3";
            // 
            // PostextBox
            // 
            this.PostextBox.Location = new System.Drawing.Point(1012, 12);
            this.PostextBox.Multiline = true;
            this.PostextBox.Name = "PostextBox";
            this.PostextBox.Size = new System.Drawing.Size(304, 43);
            this.PostextBox.TabIndex = 5;
            this.PostextBox.Text = "Whats on your mind ? ";
            this.PostextBox.MouseEnter += new System.EventHandler(this.PostextBox_MouseEnter);
            // 
            // PostButton
            // 
            this.PostButton.BackgroundImage = global::C16_Ex01_Yoni_301812095_Idan_301911103.Properties.Resources.tumblr_post_button;
            this.PostButton.Location = new System.Drawing.Point(1226, 65);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(90, 49);
            this.PostButton.TabIndex = 6;
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Post here";
            // 
            // FriendpictureBox
            // 
            this.FriendpictureBox.Location = new System.Drawing.Point(1172, 128);
            this.FriendpictureBox.Name = "FriendpictureBox";
            this.FriendpictureBox.Size = new System.Drawing.Size(165, 156);
            this.FriendpictureBox.TabIndex = 9;
            this.FriendpictureBox.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(1012, 128);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(141, 160);
            this.listBoxFriends.TabIndex = 10;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1034, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Friends";
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.Location = new System.Drawing.Point(1175, 333);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(141, 186);
            this.listBoxSearchResults.TabIndex = 12;
            this.listBoxSearchResults.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchResults_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1172, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Likers search result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wall";
            // 
            // listBoxWall
            // 
            this.listBoxWall.FormattingEnabled = true;
            this.listBoxWall.Location = new System.Drawing.Point(581, 73);
            this.listBoxWall.Name = "listBoxWall";
            this.listBoxWall.Size = new System.Drawing.Size(398, 199);
            this.listBoxWall.TabIndex = 17;
            this.listBoxWall.SelectedIndexChanged += new System.EventHandler(this.listBoxWall_SelectedIndexChanged);
            // 
            // labelLikeNumberToPost
            // 
            this.labelLikeNumberToPost.AutoSize = true;
            this.labelLikeNumberToPost.BackColor = System.Drawing.Color.Transparent;
            this.labelLikeNumberToPost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeNumberToPost.Location = new System.Drawing.Point(744, 278);
            this.labelLikeNumberToPost.Name = "labelLikeNumberToPost";
            this.labelLikeNumberToPost.Size = new System.Drawing.Size(0, 24);
            this.labelLikeNumberToPost.TabIndex = 19;
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.Location = new System.Drawing.Point(581, 333);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(191, 186);
            this.listBoxPostComments.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Likes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Comments";
            // 
            // textBoxSearchLikers
            // 
            this.textBoxSearchLikers.Location = new System.Drawing.Point(988, 317);
            this.textBoxSearchLikers.Name = "textBoxSearchLikers";
            this.textBoxSearchLikers.Size = new System.Drawing.Size(165, 20);
            this.textBoxSearchLikers.TabIndex = 23;
            this.textBoxSearchLikers.TextChanged += new System.EventHandler(this.textBoxSearchLikers_TextChanged);
            // 
            // pictureBoxWall
            // 
            this.pictureBoxWall.Location = new System.Drawing.Point(788, 333);
            this.pictureBoxWall.Name = "pictureBoxWall";
            this.pictureBoxWall.Size = new System.Drawing.Size(165, 185);
            this.pictureBoxWall.TabIndex = 24;
            this.pictureBoxWall.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(990, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 11);
            this.label7.TabIndex = 25;
            this.label7.Text = "search friend who liked your post";
            // 
            // buttonLoadPosta
            // 
            this.buttonLoadPosta.Location = new System.Drawing.Point(581, 46);
            this.buttonLoadPosta.Name = "buttonLoadPosta";
            this.buttonLoadPosta.Size = new System.Drawing.Size(120, 23);
            this.buttonLoadPosta.TabIndex = 26;
            this.buttonLoadPosta.Text = "Load more posts";
            this.buttonLoadPosta.UseVisualStyleBackColor = true;
            this.buttonLoadPosta.Click += new System.EventHandler(this.buttonLoadPosta_Click);
            // 
            // textBoxBlessing
            // 
            this.textBoxBlessing.Location = new System.Drawing.Point(1, 552);
            this.textBoxBlessing.Multiline = true;
            this.textBoxBlessing.Name = "textBoxBlessing";
            this.textBoxBlessing.Size = new System.Drawing.Size(574, 47);
            this.textBoxBlessing.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Add new blesing to save";
            // 
            // checkBoxIsFemaleBlessing
            // 
            this.checkBoxIsFemaleBlessing.AutoSize = true;
            this.checkBoxIsFemaleBlessing.Location = new System.Drawing.Point(275, 528);
            this.checkBoxIsFemaleBlessing.Name = "checkBoxIsFemaleBlessing";
            this.checkBoxIsFemaleBlessing.Size = new System.Drawing.Size(75, 17);
            this.checkBoxIsFemaleBlessing.TabIndex = 29;
            this.checkBoxIsFemaleBlessing.Text = "For female";
            this.checkBoxIsFemaleBlessing.UseVisualStyleBackColor = true;
            // 
            // buttonBlessFriends
            // 
            this.buttonBlessFriends.Location = new System.Drawing.Point(1107, 541);
            this.buttonBlessFriends.Name = "buttonBlessFriends";
            this.buttonBlessFriends.Size = new System.Drawing.Size(209, 49);
            this.buttonBlessFriends.TabIndex = 30;
            this.buttonBlessFriends.Text = "Bless freinds that have birthday today";
            this.buttonBlessFriends.UseVisualStyleBackColor = true;
            this.buttonBlessFriends.Click += new System.EventHandler(this.buttonBlessFriends_Click);
            // 
            // buttonSaveBlessing
            // 
            this.buttonSaveBlessing.Location = new System.Drawing.Point(596, 552);
            this.buttonSaveBlessing.Name = "buttonSaveBlessing";
            this.buttonSaveBlessing.Size = new System.Drawing.Size(209, 45);
            this.buttonSaveBlessing.TabIndex = 31;
            this.buttonSaveBlessing.Text = "Save this Blessing";
            this.buttonSaveBlessing.UseVisualStyleBackColor = true;
            this.buttonSaveBlessing.Click += new System.EventHandler(this.buttonSaveBlessing_Click);
            // 
            // listBoxGreeting
            // 
            this.listBoxGreeting.FormattingEnabled = true;
            this.listBoxGreeting.Location = new System.Drawing.Point(978, 398);
            this.listBoxGreeting.Name = "listBoxGreeting";
            this.listBoxGreeting.Size = new System.Drawing.Size(191, 121);
            this.listBoxGreeting.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(974, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Who recived a greeting";
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 602);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxGreeting);
            this.Controls.Add(this.buttonSaveBlessing);
            this.Controls.Add(this.buttonBlessFriends);
            this.Controls.Add(this.checkBoxIsFemaleBlessing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBlessing);
            this.Controls.Add(this.buttonLoadPosta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBoxWall);
            this.Controls.Add(this.textBoxSearchLikers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.labelLikeNumberToPost);
            this.Controls.Add(this.listBoxWall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSearchResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.FriendpictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.PostextBox);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirsrNamelabel);
            this.Controls.Add(this.ProfielpictureBox);
            this.Controls.Add(this.CoverpictureBox);
            this.Name = "FormFacebook";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CoverpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfielpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.PictureBox CoverpictureBox;
        private System.Windows.Forms.PictureBox ProfielpictureBox;
        private System.Windows.Forms.Label FirsrNamelabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.TextBox PostextBox;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FriendpictureBox;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxWall;
        private System.Windows.Forms.Label labelLikeNumberToPost;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchLikers;
        private System.Windows.Forms.PictureBox pictureBoxWall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLoadPosta;
        private System.Windows.Forms.TextBox textBoxBlessing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxIsFemaleBlessing;
        private System.Windows.Forms.Button buttonBlessFriends;
        private System.Windows.Forms.Button buttonSaveBlessing;
        private System.Windows.Forms.ListBox listBoxGreeting;
        private System.Windows.Forms.Label label9;
    }
}

