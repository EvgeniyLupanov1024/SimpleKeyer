namespace SimpleKeyer
{
    partial class KeyerWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogPickImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.textBoxRedValue = new System.Windows.Forms.TextBox();
            this.textBoxGreenValue = new System.Windows.Forms.TextBox();
            this.textBoxBlueValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSelecdedColorView = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.panelFotter = new System.Windows.Forms.Panel();
            this.pictureBoxImageOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageIn = new System.Windows.Forms.PictureBox();
            this.panelImages = new System.Windows.Forms.Panel();
            this.progressBarCutingImage = new System.Windows.Forms.ProgressBar();
            this.panelHeader.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelFotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIn)).BeginInit();
            this.panelImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.Location = new System.Drawing.Point(-1, 31);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(134, 40);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Open image";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(636, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 42);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogPickImage
            // 
            this.openFileDialogPickImage.Filter = "images|*.png";
            // 
            // saveFileDialogSaveImage
            // 
            this.saveFileDialogSaveImage.Filter = "images|*.png";
            // 
            // textBoxRedValue
            // 
            this.textBoxRedValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRedValue.Location = new System.Drawing.Point(73, 13);
            this.textBoxRedValue.Name = "textBoxRedValue";
            this.textBoxRedValue.ReadOnly = true;
            this.textBoxRedValue.Size = new System.Drawing.Size(52, 34);
            this.textBoxRedValue.TabIndex = 5;
            this.textBoxRedValue.Text = "0";
            // 
            // textBoxGreenValue
            // 
            this.textBoxGreenValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGreenValue.Location = new System.Drawing.Point(215, 14);
            this.textBoxGreenValue.Name = "textBoxGreenValue";
            this.textBoxGreenValue.ReadOnly = true;
            this.textBoxGreenValue.Size = new System.Drawing.Size(52, 34);
            this.textBoxGreenValue.TabIndex = 5;
            this.textBoxGreenValue.Text = "0";
            // 
            // textBoxBlueValue
            // 
            this.textBoxBlueValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBlueValue.Location = new System.Drawing.Point(337, 14);
            this.textBoxBlueValue.Name = "textBoxBlueValue";
            this.textBoxBlueValue.ReadOnly = true;
            this.textBoxBlueValue.Size = new System.Drawing.Size(52, 34);
            this.textBoxBlueValue.TabIndex = 5;
            this.textBoxBlueValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(278, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue:";
            // 
            // panelSelecdedColorView
            // 
            this.panelSelecdedColorView.BackColor = System.Drawing.Color.Black;
            this.panelSelecdedColorView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelecdedColorView.Location = new System.Drawing.Point(413, 3);
            this.panelSelecdedColorView.Name = "panelSelecdedColorView";
            this.panelSelecdedColorView.Size = new System.Drawing.Size(55, 54);
            this.panelSelecdedColorView.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.Controls.Add(this.buttonOpenFile);
            this.panelHeader.Location = new System.Drawing.Point(100, 53);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(769, 74);
            this.panelHeader.TabIndex = 9;
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.Salmon;
            this.panelTools.Controls.Add(this.panelSelecdedColorView);
            this.panelTools.Controls.Add(this.label3);
            this.panelTools.Controls.Add(this.textBoxBlueValue);
            this.panelTools.Controls.Add(this.label1);
            this.panelTools.Controls.Add(this.textBoxRedValue);
            this.panelTools.Controls.Add(this.textBoxGreenValue);
            this.panelTools.Controls.Add(this.label2);
            this.panelTools.Location = new System.Drawing.Point(100, 133);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(471, 60);
            this.panelTools.TabIndex = 10;
            // 
            // panelFotter
            // 
            this.panelFotter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFotter.Controls.Add(this.buttonSave);
            this.panelFotter.Location = new System.Drawing.Point(100, 480);
            this.panelFotter.Name = "panelFotter";
            this.panelFotter.Size = new System.Drawing.Size(769, 70);
            this.panelFotter.TabIndex = 12;
            // 
            // pictureBoxImageOut
            // 
            this.pictureBoxImageOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImageOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.pictureBoxImageOut.BackgroundImage = global::SimpleKeyer.Properties.Resources.cherno_belie_kvadrati_2;
            this.pictureBoxImageOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageOut.Location = new System.Drawing.Point(388, -1);
            this.pictureBoxImageOut.Name = "pictureBoxImageOut";
            this.pictureBoxImageOut.Size = new System.Drawing.Size(382, 277);
            this.pictureBoxImageOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageOut.TabIndex = 1;
            this.pictureBoxImageOut.TabStop = false;
            // 
            // pictureBoxImageIn
            // 
            this.pictureBoxImageIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImageIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.pictureBoxImageIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxImageIn.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxImageIn.Name = "pictureBoxImageIn";
            this.pictureBoxImageIn.Size = new System.Drawing.Size(382, 277);
            this.pictureBoxImageIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageIn.TabIndex = 0;
            this.pictureBoxImageIn.TabStop = false;
            this.pictureBoxImageIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImageIn_MouseDown);
            // 
            // panelImages
            // 
            this.panelImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelImages.Controls.Add(this.progressBarCutingImage);
            this.panelImages.Controls.Add(this.pictureBoxImageIn);
            this.panelImages.Controls.Add(this.pictureBoxImageOut);
            this.panelImages.Location = new System.Drawing.Point(100, 199);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(769, 275);
            this.panelImages.TabIndex = 11;
            this.panelImages.Resize += new System.EventHandler(this.panelImages_Resize);
            // 
            // progressBarCutingImage
            // 
            this.progressBarCutingImage.ForeColor = System.Drawing.Color.DarkOrange;
            this.progressBarCutingImage.Location = new System.Drawing.Point(396, 6);
            this.progressBarCutingImage.Name = "progressBarCutingImage";
            this.progressBarCutingImage.Size = new System.Drawing.Size(364, 10);
            this.progressBarCutingImage.TabIndex = 2;
            this.progressBarCutingImage.UseWaitCursor = true;
            this.progressBarCutingImage.Visible = false;
            // 
            // KeyerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(969, 600);
            this.Controls.Add(this.panelFotter);
            this.Controls.Add(this.panelImages);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.MinimumSize = new System.Drawing.Size(985, 639);
            this.Name = "KeyerWindow";
            this.Padding = new System.Windows.Forms.Padding(100, 50, 100, 50);
            this.Text = "Keyer";
            this.panelHeader.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.panelFotter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageIn)).EndInit();
            this.panelImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogPickImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveImage;
        private System.Windows.Forms.TextBox textBoxRedValue;
        private System.Windows.Forms.TextBox textBoxGreenValue;
        private System.Windows.Forms.TextBox textBoxBlueValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSelecdedColorView;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelFotter;
        private System.Windows.Forms.PictureBox pictureBoxImageOut;
        private System.Windows.Forms.PictureBox pictureBoxImageIn;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.ProgressBar progressBarCutingImage;
    }
}

