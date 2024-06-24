
namespace Project_Listening.Frontend.UserControls
{
    partial class UserControlAddEducational
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.checkBoxIsCreatorSpecialization = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic:";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxTopic.Location = new System.Drawing.Point(97, 35);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(129, 31);
            this.textBoxTopic.TabIndex = 1;
            // 
            // checkBoxIsCreatorSpecialization
            // 
            this.checkBoxIsCreatorSpecialization.AutoSize = true;
            this.checkBoxIsCreatorSpecialization.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxIsCreatorSpecialization.Location = new System.Drawing.Point(36, 80);
            this.checkBoxIsCreatorSpecialization.Name = "checkBoxIsCreatorSpecialization";
            this.checkBoxIsCreatorSpecialization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsCreatorSpecialization.Size = new System.Drawing.Size(186, 26);
            this.checkBoxIsCreatorSpecialization.TabIndex = 2;
            this.checkBoxIsCreatorSpecialization.Text = "Has Specialization ";
            this.checkBoxIsCreatorSpecialization.UseVisualStyleBackColor = true;
            // 
            // UserControlAddEducational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxIsCreatorSpecialization);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddEducational";
            this.Size = new System.Drawing.Size(267, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.CheckBox checkBoxIsCreatorSpecialization;
    }
}
