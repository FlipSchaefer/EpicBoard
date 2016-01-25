namespace EpicBoard
{
    partial class BoardWindow
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.soundboard = new System.Windows.Forms.TabPage();
            this.sound1 = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.TabPage();
            this.browseButton = new System.Windows.Forms.Button();
            this.soundFolderTextBox = new System.Windows.Forms.TextBox();
            this.KeyButton12 = new System.Windows.Forms.Button();
            this.KeyButton11 = new System.Windows.Forms.Button();
            this.KeyButton10 = new System.Windows.Forms.Button();
            this.KeyButton9 = new System.Windows.Forms.Button();
            this.KeyButton8 = new System.Windows.Forms.Button();
            this.KeyButton7 = new System.Windows.Forms.Button();
            this.KeyButton6 = new System.Windows.Forms.Button();
            this.KeyButton5 = new System.Windows.Forms.Button();
            this.KeyButton4 = new System.Windows.Forms.Button();
            this.KeyButton3 = new System.Windows.Forms.Button();
            this.KeyButton2 = new System.Windows.Forms.Button();
            this.KeyButton1 = new System.Windows.Forms.Button();
            this.inputComboBox = new System.Windows.Forms.ComboBox();
            this.outputComboBox = new System.Windows.Forms.ComboBox();
            this.buttonLabel12 = new System.Windows.Forms.Label();
            this.buttonLabel11 = new System.Windows.Forms.Label();
            this.buttonLabel10 = new System.Windows.Forms.Label();
            this.buttonLabel9 = new System.Windows.Forms.Label();
            this.buttonLabel8 = new System.Windows.Forms.Label();
            this.buttonLabel7 = new System.Windows.Forms.Label();
            this.buttonLabel6 = new System.Windows.Forms.Label();
            this.buttonLabel5 = new System.Windows.Forms.Label();
            this.buttonLabel4 = new System.Windows.Forms.Label();
            this.buttonLabel3 = new System.Windows.Forms.Label();
            this.buttonLabel2 = new System.Windows.Forms.Label();
            this.buttonLabel1 = new System.Windows.Forms.Label();
            this.keyBindingLabel = new System.Windows.Forms.Label();
            this.soundFolderLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.hardwareLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.test = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.soundboard.SuspendLayout();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.soundboard);
            this.tabControl.Controls.Add(this.options);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(656, 533);
            this.tabControl.TabIndex = 0;
            // 
            // soundboard
            // 
            this.soundboard.Controls.Add(this.sound1);
            this.soundboard.Location = new System.Drawing.Point(4, 22);
            this.soundboard.Name = "soundboard";
            this.soundboard.Padding = new System.Windows.Forms.Padding(3);
            this.soundboard.Size = new System.Drawing.Size(648, 507);
            this.soundboard.TabIndex = 0;
            this.soundboard.Text = "Soundboard";
            this.soundboard.UseVisualStyleBackColor = true;
            // 
            // sound1
            // 
            this.sound1.Location = new System.Drawing.Point(7, 7);
            this.sound1.Name = "sound1";
            this.sound1.Size = new System.Drawing.Size(635, 494);
            this.sound1.TabIndex = 0;
            this.sound1.Text = "Button 1 - no Sound";
            this.sound1.UseVisualStyleBackColor = true;
            this.sound1.Click += new System.EventHandler(this.sound1_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.test);
            this.options.Controls.Add(this.browseButton);
            this.options.Controls.Add(this.soundFolderTextBox);
            this.options.Controls.Add(this.KeyButton12);
            this.options.Controls.Add(this.KeyButton11);
            this.options.Controls.Add(this.KeyButton10);
            this.options.Controls.Add(this.KeyButton9);
            this.options.Controls.Add(this.KeyButton8);
            this.options.Controls.Add(this.KeyButton7);
            this.options.Controls.Add(this.KeyButton6);
            this.options.Controls.Add(this.KeyButton5);
            this.options.Controls.Add(this.KeyButton4);
            this.options.Controls.Add(this.KeyButton3);
            this.options.Controls.Add(this.KeyButton2);
            this.options.Controls.Add(this.KeyButton1);
            this.options.Controls.Add(this.inputComboBox);
            this.options.Controls.Add(this.outputComboBox);
            this.options.Controls.Add(this.buttonLabel12);
            this.options.Controls.Add(this.buttonLabel11);
            this.options.Controls.Add(this.buttonLabel10);
            this.options.Controls.Add(this.buttonLabel9);
            this.options.Controls.Add(this.buttonLabel8);
            this.options.Controls.Add(this.buttonLabel7);
            this.options.Controls.Add(this.buttonLabel6);
            this.options.Controls.Add(this.buttonLabel5);
            this.options.Controls.Add(this.buttonLabel4);
            this.options.Controls.Add(this.buttonLabel3);
            this.options.Controls.Add(this.buttonLabel2);
            this.options.Controls.Add(this.buttonLabel1);
            this.options.Controls.Add(this.keyBindingLabel);
            this.options.Controls.Add(this.soundFolderLabel);
            this.options.Controls.Add(this.inputLabel);
            this.options.Controls.Add(this.outputLabel);
            this.options.Controls.Add(this.hardwareLabel);
            this.options.Location = new System.Drawing.Point(4, 22);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(3);
            this.options.Size = new System.Drawing.Size(648, 507);
            this.options.TabIndex = 1;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(10, 191);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 32;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // soundFolderTextBox
            // 
            this.soundFolderTextBox.Location = new System.Drawing.Point(10, 164);
            this.soundFolderTextBox.Name = "soundFolderTextBox";
            this.soundFolderTextBox.Size = new System.Drawing.Size(330, 20);
            this.soundFolderTextBox.TabIndex = 31;
            // 
            // KeyButton12
            // 
            this.KeyButton12.Location = new System.Drawing.Point(290, 436);
            this.KeyButton12.Name = "KeyButton12";
            this.KeyButton12.Size = new System.Drawing.Size(62, 23);
            this.KeyButton12.TabIndex = 30;
            this.KeyButton12.Text = "unbound";
            this.KeyButton12.UseVisualStyleBackColor = true;
            // 
            // KeyButton11
            // 
            this.KeyButton11.Location = new System.Drawing.Point(200, 436);
            this.KeyButton11.Name = "KeyButton11";
            this.KeyButton11.Size = new System.Drawing.Size(62, 23);
            this.KeyButton11.TabIndex = 29;
            this.KeyButton11.Text = "unbound";
            this.KeyButton11.UseVisualStyleBackColor = true;
            // 
            // KeyButton10
            // 
            this.KeyButton10.Location = new System.Drawing.Point(100, 436);
            this.KeyButton10.Name = "KeyButton10";
            this.KeyButton10.Size = new System.Drawing.Size(62, 23);
            this.KeyButton10.TabIndex = 28;
            this.KeyButton10.Text = "unbound";
            this.KeyButton10.UseVisualStyleBackColor = true;
            // 
            // KeyButton9
            // 
            this.KeyButton9.Location = new System.Drawing.Point(10, 436);
            this.KeyButton9.Name = "KeyButton9";
            this.KeyButton9.Size = new System.Drawing.Size(62, 23);
            this.KeyButton9.TabIndex = 27;
            this.KeyButton9.Text = "unbound";
            this.KeyButton9.UseVisualStyleBackColor = true;
            // 
            // KeyButton8
            // 
            this.KeyButton8.Location = new System.Drawing.Point(290, 366);
            this.KeyButton8.Name = "KeyButton8";
            this.KeyButton8.Size = new System.Drawing.Size(62, 23);
            this.KeyButton8.TabIndex = 26;
            this.KeyButton8.Text = "unbound";
            this.KeyButton8.UseVisualStyleBackColor = true;
            // 
            // KeyButton7
            // 
            this.KeyButton7.Location = new System.Drawing.Point(200, 366);
            this.KeyButton7.Name = "KeyButton7";
            this.KeyButton7.Size = new System.Drawing.Size(62, 23);
            this.KeyButton7.TabIndex = 25;
            this.KeyButton7.Text = "unbound";
            this.KeyButton7.UseVisualStyleBackColor = true;
            // 
            // KeyButton6
            // 
            this.KeyButton6.Location = new System.Drawing.Point(100, 366);
            this.KeyButton6.Name = "KeyButton6";
            this.KeyButton6.Size = new System.Drawing.Size(62, 23);
            this.KeyButton6.TabIndex = 24;
            this.KeyButton6.Text = "unbound";
            this.KeyButton6.UseVisualStyleBackColor = true;
            // 
            // KeyButton5
            // 
            this.KeyButton5.Location = new System.Drawing.Point(10, 366);
            this.KeyButton5.Name = "KeyButton5";
            this.KeyButton5.Size = new System.Drawing.Size(62, 23);
            this.KeyButton5.TabIndex = 23;
            this.KeyButton5.Text = "unbound";
            this.KeyButton5.UseVisualStyleBackColor = true;
            // 
            // KeyButton4
            // 
            this.KeyButton4.Location = new System.Drawing.Point(290, 297);
            this.KeyButton4.Name = "KeyButton4";
            this.KeyButton4.Size = new System.Drawing.Size(62, 23);
            this.KeyButton4.TabIndex = 22;
            this.KeyButton4.Text = "unbound";
            this.KeyButton4.UseVisualStyleBackColor = true;
            // 
            // KeyButton3
            // 
            this.KeyButton3.Location = new System.Drawing.Point(200, 297);
            this.KeyButton3.Name = "KeyButton3";
            this.KeyButton3.Size = new System.Drawing.Size(62, 23);
            this.KeyButton3.TabIndex = 21;
            this.KeyButton3.Text = "unbound";
            this.KeyButton3.UseVisualStyleBackColor = true;
            // 
            // KeyButton2
            // 
            this.KeyButton2.Location = new System.Drawing.Point(100, 297);
            this.KeyButton2.Name = "KeyButton2";
            this.KeyButton2.Size = new System.Drawing.Size(62, 23);
            this.KeyButton2.TabIndex = 20;
            this.KeyButton2.Text = "unbound";
            this.KeyButton2.UseVisualStyleBackColor = true;
            // 
            // KeyButton1
            // 
            this.KeyButton1.Location = new System.Drawing.Point(10, 297);
            this.KeyButton1.Name = "KeyButton1";
            this.KeyButton1.Size = new System.Drawing.Size(65, 23);
            this.KeyButton1.TabIndex = 19;
            this.KeyButton1.Text = "unbound";
            this.KeyButton1.UseVisualStyleBackColor = true;
            // 
            // inputComboBox
            // 
            this.inputComboBox.FormattingEnabled = true;
            this.inputComboBox.Location = new System.Drawing.Point(10, 107);
            this.inputComboBox.Name = "inputComboBox";
            this.inputComboBox.Size = new System.Drawing.Size(330, 21);
            this.inputComboBox.TabIndex = 18;
            this.inputComboBox.Text = "Select Sound Input";
            this.inputComboBox.SelectedIndexChanged += new System.EventHandler(this.inputComboBox_SelectedIndexChanged);
            // 
            // outputComboBox
            // 
            this.outputComboBox.FormattingEnabled = true;
            this.outputComboBox.Location = new System.Drawing.Point(10, 54);
            this.outputComboBox.Name = "outputComboBox";
            this.outputComboBox.Size = new System.Drawing.Size(330, 21);
            this.outputComboBox.TabIndex = 17;
            this.outputComboBox.Text = "Select Sound Output";
            this.outputComboBox.SelectedIndexChanged += new System.EventHandler(this.outputComboBox_SelectedIndexChanged);
            // 
            // buttonLabel12
            // 
            this.buttonLabel12.AutoSize = true;
            this.buttonLabel12.Location = new System.Drawing.Point(287, 420);
            this.buttonLabel12.Name = "buttonLabel12";
            this.buttonLabel12.Size = new System.Drawing.Size(53, 13);
            this.buttonLabel12.TabIndex = 16;
            this.buttonLabel12.Text = "Button 12";
            // 
            // buttonLabel11
            // 
            this.buttonLabel11.AutoSize = true;
            this.buttonLabel11.Location = new System.Drawing.Point(197, 420);
            this.buttonLabel11.Name = "buttonLabel11";
            this.buttonLabel11.Size = new System.Drawing.Size(53, 13);
            this.buttonLabel11.TabIndex = 15;
            this.buttonLabel11.Text = "Button 11";
            // 
            // buttonLabel10
            // 
            this.buttonLabel10.AutoSize = true;
            this.buttonLabel10.Location = new System.Drawing.Point(97, 420);
            this.buttonLabel10.Name = "buttonLabel10";
            this.buttonLabel10.Size = new System.Drawing.Size(53, 13);
            this.buttonLabel10.TabIndex = 14;
            this.buttonLabel10.Text = "Button 10";
            // 
            // buttonLabel9
            // 
            this.buttonLabel9.AutoSize = true;
            this.buttonLabel9.Location = new System.Drawing.Point(7, 420);
            this.buttonLabel9.Name = "buttonLabel9";
            this.buttonLabel9.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel9.TabIndex = 13;
            this.buttonLabel9.Text = "Button 9";
            // 
            // buttonLabel8
            // 
            this.buttonLabel8.AutoSize = true;
            this.buttonLabel8.Location = new System.Drawing.Point(287, 350);
            this.buttonLabel8.Name = "buttonLabel8";
            this.buttonLabel8.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel8.TabIndex = 12;
            this.buttonLabel8.Text = "Button 8";
            // 
            // buttonLabel7
            // 
            this.buttonLabel7.AutoSize = true;
            this.buttonLabel7.Location = new System.Drawing.Point(197, 350);
            this.buttonLabel7.Name = "buttonLabel7";
            this.buttonLabel7.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel7.TabIndex = 11;
            this.buttonLabel7.Text = "Button 7";
            // 
            // buttonLabel6
            // 
            this.buttonLabel6.AutoSize = true;
            this.buttonLabel6.Location = new System.Drawing.Point(97, 350);
            this.buttonLabel6.Name = "buttonLabel6";
            this.buttonLabel6.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel6.TabIndex = 10;
            this.buttonLabel6.Text = "Button 6";
            // 
            // buttonLabel5
            // 
            this.buttonLabel5.AutoSize = true;
            this.buttonLabel5.Location = new System.Drawing.Point(7, 350);
            this.buttonLabel5.Name = "buttonLabel5";
            this.buttonLabel5.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel5.TabIndex = 9;
            this.buttonLabel5.Text = "Button 5";
            // 
            // buttonLabel4
            // 
            this.buttonLabel4.AutoSize = true;
            this.buttonLabel4.Location = new System.Drawing.Point(287, 280);
            this.buttonLabel4.Name = "buttonLabel4";
            this.buttonLabel4.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel4.TabIndex = 8;
            this.buttonLabel4.Text = "Button 4";
            // 
            // buttonLabel3
            // 
            this.buttonLabel3.AutoSize = true;
            this.buttonLabel3.Location = new System.Drawing.Point(197, 280);
            this.buttonLabel3.Name = "buttonLabel3";
            this.buttonLabel3.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel3.TabIndex = 7;
            this.buttonLabel3.Text = "Button 3";
            // 
            // buttonLabel2
            // 
            this.buttonLabel2.AutoSize = true;
            this.buttonLabel2.Location = new System.Drawing.Point(97, 280);
            this.buttonLabel2.Name = "buttonLabel2";
            this.buttonLabel2.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel2.TabIndex = 6;
            this.buttonLabel2.Text = "Button 2";
            // 
            // buttonLabel1
            // 
            this.buttonLabel1.AutoSize = true;
            this.buttonLabel1.Location = new System.Drawing.Point(7, 280);
            this.buttonLabel1.Name = "buttonLabel1";
            this.buttonLabel1.Size = new System.Drawing.Size(47, 13);
            this.buttonLabel1.TabIndex = 5;
            this.buttonLabel1.Text = "Button 1";
            // 
            // keyBindingLabel
            // 
            this.keyBindingLabel.AutoSize = true;
            this.keyBindingLabel.Location = new System.Drawing.Point(7, 250);
            this.keyBindingLabel.Name = "keyBindingLabel";
            this.keyBindingLabel.Size = new System.Drawing.Size(70, 13);
            this.keyBindingLabel.TabIndex = 4;
            this.keyBindingLabel.Text = "Key bindings:";
            // 
            // soundFolderLabel
            // 
            this.soundFolderLabel.AutoSize = true;
            this.soundFolderLabel.Location = new System.Drawing.Point(7, 147);
            this.soundFolderLabel.Name = "soundFolderLabel";
            this.soundFolderLabel.Size = new System.Drawing.Size(73, 13);
            this.soundFolderLabel.TabIndex = 3;
            this.soundFolderLabel.Text = "Sound Folder:";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(7, 90);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(68, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Sound Input:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(7, 37);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(76, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Sound Output:";
            // 
            // hardwareLabel
            // 
            this.hardwareLabel.AutoSize = true;
            this.hardwareLabel.Location = new System.Drawing.Point(7, 3);
            this.hardwareLabel.Name = "hardwareLabel";
            this.hardwareLabel.Size = new System.Drawing.Size(71, 13);
            this.hardwareLabel.TabIndex = 0;
            this.hardwareLabel.Text = "HARDWARE";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(567, 7);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 33;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // BoardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 558);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BoardWindow";
            this.Text = "EpicSoundBoard";
            this.tabControl.ResumeLayout(false);
            this.soundboard.ResumeLayout(false);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage soundboard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage options;
        private System.Windows.Forms.Button KeyButton12;
        private System.Windows.Forms.Button KeyButton11;
        private System.Windows.Forms.Button KeyButton10;
        private System.Windows.Forms.Button KeyButton9;
        private System.Windows.Forms.Button KeyButton8;
        private System.Windows.Forms.Button KeyButton7;
        private System.Windows.Forms.Button KeyButton6;
        private System.Windows.Forms.Button KeyButton5;
        private System.Windows.Forms.Button KeyButton4;
        private System.Windows.Forms.Button KeyButton3;
        private System.Windows.Forms.Button KeyButton2;
        private System.Windows.Forms.Button KeyButton1;
        private System.Windows.Forms.ComboBox inputComboBox;
        private System.Windows.Forms.ComboBox outputComboBox;
        private System.Windows.Forms.Label buttonLabel12;
        private System.Windows.Forms.Label buttonLabel11;
        private System.Windows.Forms.Label buttonLabel10;
        private System.Windows.Forms.Label buttonLabel9;
        private System.Windows.Forms.Label buttonLabel8;
        private System.Windows.Forms.Label buttonLabel7;
        private System.Windows.Forms.Label buttonLabel6;
        private System.Windows.Forms.Label buttonLabel5;
        private System.Windows.Forms.Label buttonLabel4;
        private System.Windows.Forms.Label buttonLabel3;
        private System.Windows.Forms.Label buttonLabel2;
        private System.Windows.Forms.Label buttonLabel1;
        private System.Windows.Forms.Label keyBindingLabel;
        private System.Windows.Forms.Label soundFolderLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label hardwareLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox soundFolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button sound1;
        private System.Windows.Forms.Button test;
    }
}

