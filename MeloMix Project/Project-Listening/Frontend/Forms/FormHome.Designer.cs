
namespace Project_Listening.Frontend.Forms
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonAddPodcast = new System.Windows.Forms.Button();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.buttonPodcast = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddPodcast
            // 
            this.buttonAddPodcast.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonAddPodcast, "buttonAddPodcast");
            this.buttonAddPodcast.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddPodcast.Name = "buttonAddPodcast";
            this.buttonAddPodcast.UseVisualStyleBackColor = false;
            this.buttonAddPodcast.Click += new System.EventHandler(this.buttonAddPodcast_Click_1);
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonAddSong, "buttonAddSong");
            this.buttonAddSong.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.UseVisualStyleBackColor = false;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click_1);
            // 
            // buttonPodcast
            // 
            this.buttonPodcast.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonPodcast, "buttonPodcast");
            this.buttonPodcast.ForeColor = System.Drawing.Color.White;
            this.buttonPodcast.Name = "buttonPodcast";
            this.buttonPodcast.UseVisualStyleBackColor = false;
            this.buttonPodcast.Click += new System.EventHandler(this.buttonPodcast_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.buttonMusic, "buttonMusic");
            this.buttonMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Project_Listening.Properties.Resources.White_and_Grey_Minimalist_Headphone_Store_Desktop_Prototype__1_;
            this.Controls.Add(this.buttonAddPodcast);
            this.Controls.Add(this.buttonAddSong);
            this.Controls.Add(this.buttonPodcast);
            this.Controls.Add(this.buttonMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPodcast;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.Button buttonPodcast;
        private System.Windows.Forms.Button buttonMusic;
    }
}