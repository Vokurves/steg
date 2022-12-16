using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Steganography1241421
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        public static Bitmap EmbedText(string text, Bitmap bmp)
        {
            State state = State.Hiding;
            int charIndex = 0;
            int charValue = 0;
            long pixelElementIndex = 0;
            int zeros = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for (int n = 0; n < 3; n++)
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                return bmp;
                            }

                            if (charIndex >= text.Length)
                            {
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        R += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }

        public static string ExtractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {                                  
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = ReverseBits(charValue);
                            
                            if (charValue == 0)
                            {
                                return extractedText;
                            }
                            
                            char c = (char)charValue;
                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }

        public static int ReverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP)|*.BMP";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void EnscryptButton_Click(object sender, EventArgs e)
        {
            if (messageBox.Text != null)
            {
                string message = messageBox.Text;

                if (image.Image != null)
                {
                    Bitmap enscryptedImage = EmbedText(message, (Bitmap)image.Image);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Сохранить картинку как...";
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.CheckPathExists = true;
                    saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP";
                    saveFileDialog.ShowHelp = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            enscryptedImage.Save(saveFileDialog.FileName);
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    descryptedMessage.Text = "Отсутствует картинка.";
                }
            }
            else
            {
                descryptedMessage.Text = "Отсутствует текст.";
            }
        }


        private void DescryptImage_Click(object sender, EventArgs e)
        {
            if (image.Image != null)
            {
                descryptedMessage.Text = ExtractText((Bitmap)image.Image);
            }
            else
            {
                descryptedMessage.Text = "Отсутствует картинка.";
            }
        }

        private void ClearImage_Click(object sender, EventArgs e)
        {
            image.Image = null;
        }

        private void descryptedMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
