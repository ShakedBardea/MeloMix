
namespace Project_Listening.Frontend.Forms
{
    partial class FormMusic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllSong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllSong
            // 
            this.dataGridViewAllSong.AllowUserToAddRows = false;
            this.dataGridViewAllSong.AllowUserToDeleteRows = false;
            this.dataGridViewAllSong.AllowUserToResizeColumns = false;
            this.dataGridViewAllSong.AllowUserToResizeRows = false;
            this.dataGridViewAllSong.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllSong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllSong.GridColor = System.Drawing.Color.Black;
            this.dataGridViewAllSong.Location = new System.Drawing.Point(31, 334);
            this.dataGridViewAllSong.Name = "dataGridViewAllSong";
            this.dataGridViewAllSong.ReadOnly = true;
            this.dataGridViewAllSong.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewAllSong.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAllSong.RowTemplate.Height = 24;
            this.dataGridViewAllSong.Size = new System.Drawing.Size(604, 378);
            this.dataGridViewAllSong.TabIndex = 0;
            this.dataGridViewAllSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Listening.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.dataGridViewAllSong);
            this.DoubleBuffered = true;
            this.Name = "FormMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMusic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllSong;
    }
}