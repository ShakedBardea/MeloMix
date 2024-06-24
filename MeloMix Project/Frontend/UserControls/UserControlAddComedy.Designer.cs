
namespace Project_Listening.Frontend.UserControls
{
    partial class UserControlAddComedy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxIsComedian = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxIsComedian
            // 
            this.checkBoxIsComedian.AutoSize = true;
            this.checkBoxIsComedian.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxIsComedian.Location = new System.Drawing.Point(45, 26);
            this.checkBoxIsComedian.Name = "checkBoxIsComedian";
            this.checkBoxIsComedian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsComedian.Size = new System.Drawing.Size(137, 26);
            this.checkBoxIsComedian.TabIndex = 0;
            this.checkBoxIsComedian.Text = "Is Comedian";
            this.checkBoxIsComedian.UseVisualStyleBackColor = true;
            this.checkBoxIsComedian.CheckedChanged += new System.EventHandler(this.checkBoxIsComedian_CheckedChanged);
            // 
            // UserControlAddComedy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxIsComedian);
            this.Name = "UserControlAddComedy";
            this.Size = new System.Drawing.Size(261, 153);
            this.Load += new System.EventHandler(this.UserControlAddComedy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsComedian;
    }
}
