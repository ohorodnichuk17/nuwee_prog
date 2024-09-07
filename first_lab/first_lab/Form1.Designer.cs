namespace first_lab
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         pictureBox1 = new PictureBox();
         pictureBox2 = new PictureBox();
         textBoxRadius = new TextBox();
         textBoxArea = new TextBox();
         label1 = new Label();
         label2 = new Label();
         buttonFindArea = new Button();
         ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
         SuspendLayout();
         // 
         // pictureBox1
         // 
         pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
         pictureBox1.Location = new Point(206, -23);
         pictureBox1.Name = "pictureBox1";
         pictureBox1.Size = new Size(180, 185);
         pictureBox1.TabIndex = 0;
         pictureBox1.TabStop = false;
         // 
         // pictureBox2
         // 
         pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
         pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
         pictureBox2.Location = new Point(-2, -23);
         pictureBox2.Name = "pictureBox2";
         pictureBox2.Size = new Size(211, 185);
         pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
         pictureBox2.TabIndex = 1;
         pictureBox2.TabStop = false;
         // 
         // textBoxRadius
         // 
         textBoxRadius.Location = new Point(72, 169);
         textBoxRadius.Name = "textBoxRadius";
         textBoxRadius.Size = new Size(314, 27);
         textBoxRadius.TabIndex = 2;
         // 
         // textBoxArea
         // 
         textBoxArea.Location = new Point(72, 209);
         textBoxArea.Name = "textBoxArea";
         textBoxArea.Size = new Size(314, 27);
         textBoxArea.TabIndex = 3;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
         label1.Location = new Point(11, 165);
         label1.Name = "label1";
         label1.Size = new Size(55, 35);
         label1.TabIndex = 4;
         label1.Text = "R=";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
         label2.Location = new Point(12, 201);
         label2.Name = "label2";
         label2.Size = new Size(53, 35);
         label2.TabIndex = 5;
         label2.Text = "S=";
         // 
         // buttonFindArea
         // 
         buttonFindArea.Location = new Point(154, 262);
         buttonFindArea.Name = "buttonFindArea";
         buttonFindArea.Size = new Size(94, 29);
         buttonFindArea.TabIndex = 6;
         buttonFindArea.Text = "Find area";
         buttonFindArea.UseVisualStyleBackColor = true;
         buttonFindArea.Click += buttonFindArea_Click;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(407, 307);
         Controls.Add(buttonFindArea);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(textBoxArea);
         Controls.Add(textBoxRadius);
         Controls.Add(pictureBox2);
         Controls.Add(pictureBox1);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
         ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private PictureBox pictureBox1;
      private PictureBox pictureBox2;
      private TextBox textBoxRadius;
      private TextBox textBoxArea;
      private Label label1;
      private Label label2;
      private Button buttonFindArea;
   }
}
