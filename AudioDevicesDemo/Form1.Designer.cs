
namespace AudioDevicesDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.RecordingDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.PlaybackDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recording Device";
            // 
            // RecordingDeviceComboBox
            // 
            this.RecordingDeviceComboBox.FormattingEnabled = true;
            this.RecordingDeviceComboBox.Location = new System.Drawing.Point(269, 124);
            this.RecordingDeviceComboBox.Name = "RecordingDeviceComboBox";
            this.RecordingDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            this.RecordingDeviceComboBox.TabIndex = 1;
            // 
            // PlaybackDeviceComboBox
            // 
            this.PlaybackDeviceComboBox.FormattingEnabled = true;
            this.PlaybackDeviceComboBox.Location = new System.Drawing.Point(269, 211);
            this.PlaybackDeviceComboBox.Name = "PlaybackDeviceComboBox";
            this.PlaybackDeviceComboBox.Size = new System.Drawing.Size(397, 28);
            this.PlaybackDeviceComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playback Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlaybackDeviceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecordingDeviceComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RecordingDeviceComboBox;
        private System.Windows.Forms.ComboBox PlaybackDeviceComboBox;
        private System.Windows.Forms.Label label2;
    }
}

