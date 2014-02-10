namespace MyLittlePhotoshop
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.filtersSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.greyscaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianButton = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkifyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(0, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.filtersSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 24);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // filtersSplitButton
            // 
            this.filtersSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtersSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyscaleButton,
            this.pinkifyButton,
            this.binarizeButton,
            this.invertColorsButton,
            this.mirrorToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.edgeDetectButton});
            this.filtersSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("filtersSplitButton.Image")));
            this.filtersSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtersSplitButton.Name = "filtersSplitButton";
            this.filtersSplitButton.Size = new System.Drawing.Size(64, 24);
            this.filtersSplitButton.Text = "Filters";
            this.filtersSplitButton.ButtonClick += new System.EventHandler(this.filtersSplitButton_ButtonClick);
            // 
            // greyscaleButton
            // 
            this.greyscaleButton.Name = "greyscaleButton";
            this.greyscaleButton.Size = new System.Drawing.Size(160, 24);
            this.greyscaleButton.Text = "Greyscale";
            this.greyscaleButton.Click += new System.EventHandler(this.greyscaleButton_Click);
            // 
            // invertColorsButton
            // 
            this.invertColorsButton.Name = "invertColorsButton";
            this.invertColorsButton.Size = new System.Drawing.Size(160, 24);
            this.invertColorsButton.Text = "Invert colors";
            this.invertColorsButton.Click += new System.EventHandler(this.invertColorsButton_Click);
            // 
            // mirrorToolStripMenuItem
            // 
            this.mirrorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalButton,
            this.horizontalButton});
            this.mirrorToolStripMenuItem.Name = "mirrorToolStripMenuItem";
            this.mirrorToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.mirrorToolStripMenuItem.Text = "Mirror";
            // 
            // verticalButton
            // 
            this.verticalButton.Name = "verticalButton";
            this.verticalButton.Size = new System.Drawing.Size(152, 24);
            this.verticalButton.Text = "Vertical";
            this.verticalButton.Click += new System.EventHandler(this.verticalButton_Click);
            // 
            // horizontalButton
            // 
            this.horizontalButton.Name = "horizontalButton";
            this.horizontalButton.Size = new System.Drawing.Size(152, 24);
            this.horizontalButton.Text = "Horizontal";
            this.horizontalButton.Click += new System.EventHandler(this.horizontalButton_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageButton,
            this.gaussianButton});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // averageButton
            // 
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(152, 24);
            this.averageButton.Text = "Average";
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // gaussianButton
            // 
            this.gaussianButton.Name = "gaussianButton";
            this.gaussianButton.Size = new System.Drawing.Size(152, 24);
            this.gaussianButton.Text = "Gaussian";
            this.gaussianButton.Click += new System.EventHandler(this.gaussianButton_Click);
            // 
            // binarizeButton
            // 
            this.binarizeButton.Name = "binarizeButton";
            this.binarizeButton.Size = new System.Drawing.Size(160, 24);
            this.binarizeButton.Text = "Binarize";
            this.binarizeButton.Click += new System.EventHandler(this.binarizeButton_Click);
            // 
            // pinkifyButton
            // 
            this.pinkifyButton.Name = "pinkifyButton";
            this.pinkifyButton.Size = new System.Drawing.Size(160, 24);
            this.pinkifyButton.Text = "Pinkify";
            this.pinkifyButton.Click += new System.EventHandler(this.pinkifyButton_Click);
            // 
            // edgeDetectButton
            // 
            this.edgeDetectButton.Name = "edgeDetectButton";
            this.edgeDetectButton.Size = new System.Drawing.Size(160, 24);
            this.edgeDetectButton.Text = "Edge Detect";
            this.edgeDetectButton.Click += new System.EventHandler(this.edgeDetectButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(49, 24);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "Image (*.png)|*.png";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Images (*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 796);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "My Little Photoshop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSplitButton filtersSplitButton;
        private System.Windows.Forms.ToolStripMenuItem greyscaleButton;
        private System.Windows.Forms.ToolStripMenuItem pinkifyButton;
        private System.Windows.Forms.ToolStripMenuItem binarizeButton;
        private System.Windows.Forms.ToolStripMenuItem invertColorsButton;
        private System.Windows.Forms.ToolStripMenuItem mirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalButton;
        private System.Windows.Forms.ToolStripMenuItem horizontalButton;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageButton;
        private System.Windows.Forms.ToolStripMenuItem gaussianButton;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

