using Keras;
using Keras.Models;
using Numpy;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FlowerClassfier
{

    public partial class Form1 : Form
    {
        static BaseModel model;
        static string[] labes = new string[] { "daisy", "dandelion", "roses", "sunflowers", "tulips" };
        public Form1()
        {
            InitializeComponent();
            model = Keras.Models.Model.LoadModel("Models");
        }
        private NDarray softmax(Numpy.NDarray x)
        {
            return np.exp(x) / np.sum(np.exp(x), 0);
        }
        private void Recognize(string photo)
        {
            var shape = new Shape(new int[] { 180, 180 });
            var img = Keras.PreProcessing.Image.ImageUtil.LoadImg(photo, target_size: shape);
            var img_array = Keras.PreProcessing.Image.ImageUtil.ImageToArray(img);
            img_array = np.expand_dims(img_array, 0);
            var predictions = model.Predict(img_array);
            var score = softmax(predictions[0]);
            this.flower_name.Text = labes[(int)np.argmax(score)].ToString();
            this.Confidence.Text = ((float)np.max(score) * 100).ToString();
        }
        private void pickButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string photo = openFileDialog.FileName;
                    this.flower.Image = Image.FromFile(photo);
                    this.flower.SizeMode = PictureBoxSizeMode.StretchImage;
                    Recognize(photo);
                }
            }
        }
    }
}
