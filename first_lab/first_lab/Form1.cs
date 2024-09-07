namespace first_lab
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void buttonFindArea_Click(object sender, EventArgs e)
      {
         try
         {
            double R = Convert.ToDouble(textBoxRadius.Text);

            if (R <= 0)
            {
               throw new Exception("Radius must be a positive number.");
            }

            double area = 4 * Math.PI * Math.Pow(R, 2);
            textBoxArea.Text = area.ToString();
         }
         catch
         {
            MessageBox.Show("Enter the correct values of radius", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
