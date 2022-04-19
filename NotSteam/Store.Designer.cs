namespace NotSteam
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Steam_service-Logo.wine.png");
            this.imageList1.Images.SetKeyName(1, "back-arrow-icon-image-free-download-searchpng-arrow-gray-world-of-warcraft-transp" +
        "arent-png-530549_ccexpress.png");
            this.imageList1.Images.SetKeyName(2, "gta 5.jpg");
            this.imageList1.Images.SetKeyName(3, "bloons-td6-purple.jpg");
            this.imageList1.Images.SetKeyName(4, "Dying_Light.jpg");
            this.imageList1.Images.SetKeyName(5, "new world.jpg");
            this.imageList1.Images.SetKeyName(6, "cs1.6.jpg");
            this.imageList1.Images.SetKeyName(7, "pubg.jpg");
            this.imageList1.Images.SetKeyName(8, "sims4.jpg");
            this.imageList1.Images.SetKeyName(9, "csgo.png");
            this.imageList1.Images.SetKeyName(10, "Farming simulator.jpg");
            this.imageList1.Images.SetKeyName(11, "who\'s your daddy.jpg");
            this.imageList1.Images.SetKeyName(12, "unturned.jpg");
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Store";
            this.Text = "Store";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}