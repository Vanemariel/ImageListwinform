namespace ImageList
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImgLFotos = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblIMAGENES = new System.Windows.Forms.Label();
            this.addImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImgLFotos
            // 
            this.ImgLFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLFotos.ImageStream")));
            this.ImgLFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLFotos.Images.SetKeyName(0, "cascada.jpg");
            this.ImgLFotos.Images.SetKeyName(1, "images.jpg");
            this.ImgLFotos.Images.SetKeyName(2, "arco iris.jpg");
            this.ImgLFotos.Images.SetKeyName(3, "jardin.jpg");
            this.ImgLFotos.Images.SetKeyName(4, "primavera.jpg");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "CAMBIAR IMAGEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIMAGENES
            // 
            this.lblIMAGENES.ImageIndex = 0;
            this.lblIMAGENES.ImageList = this.ImgLFotos;
            this.lblIMAGENES.Location = new System.Drawing.Point(130, 9);
            this.lblIMAGENES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIMAGENES.Name = "lblIMAGENES";
            this.lblIMAGENES.Size = new System.Drawing.Size(400, 369);
            this.lblIMAGENES.TabIndex = 1;
            this.lblIMAGENES.Text = "lblIMAGENES";
            this.lblIMAGENES.Click += new System.EventHandler(this.button1_Click);
            // 
            // addImage
            // 
            this.addImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImage.Location = new System.Drawing.Point(104, 452);
            this.addImage.Margin = new System.Windows.Forms.Padding(4);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(217, 48);
            this.addImage.TabIndex = 2;
            this.addImage.Text = "Agregar Img";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImageList);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(329, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar Img";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteImage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.lblIMAGENES);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIMAGENES;
        public System.Windows.Forms.ImageList ImgLFotos;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.Button button2;
    }
}

