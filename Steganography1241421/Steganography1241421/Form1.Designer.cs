namespace Steganography1241421
{
    partial class Form1
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
            this.image = new System.Windows.Forms.PictureBox();
            this.uploadImage = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.enscryptButton = new System.Windows.Forms.Button();
            this.descryptedMessage = new System.Windows.Forms.RichTextBox();
            this.descryptImage = new System.Windows.Forms.Button();
            this.ClearImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.image.Location = new System.Drawing.Point(14, 41);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(562, 328);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(14, 12);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(172, 23);
            this.uploadImage.TabIndex = 1;
            this.uploadImage.Text = "Загрузить картинку";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(14, 404);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(562, 96);
            this.messageBox.TabIndex = 2;
            this.messageBox.Text = "";
            // 
            // enscryptButton
            // 
            this.enscryptButton.Location = new System.Drawing.Point(14, 375);
            this.enscryptButton.Name = "enscryptButton";
            this.enscryptButton.Size = new System.Drawing.Size(145, 23);
            this.enscryptButton.TabIndex = 3;
            this.enscryptButton.Text = "Вставить текст";
            this.enscryptButton.UseVisualStyleBackColor = true;
            this.enscryptButton.Click += new System.EventHandler(this.EnscryptButton_Click);
            // 
            // descryptedMessage
            // 
            this.descryptedMessage.Location = new System.Drawing.Point(582, 41);
            this.descryptedMessage.Name = "descryptedMessage";
            this.descryptedMessage.Size = new System.Drawing.Size(286, 328);
            this.descryptedMessage.TabIndex = 4;
            this.descryptedMessage.Text = "";
            this.descryptedMessage.TextChanged += new System.EventHandler(this.descryptedMessage_TextChanged);
            // 
            // descryptImage
            // 
            this.descryptImage.Location = new System.Drawing.Point(582, 12);
            this.descryptImage.Name = "descryptImage";
            this.descryptImage.Size = new System.Drawing.Size(165, 23);
            this.descryptImage.TabIndex = 5;
            this.descryptImage.Text = "Получить сообщение";
            this.descryptImage.UseVisualStyleBackColor = true;
            this.descryptImage.Click += new System.EventHandler(this.DescryptImage_Click);
            // 
            // ClearImage
            // 
            this.ClearImage.Location = new System.Drawing.Point(192, 12);
            this.ClearImage.Name = "ClearImage";
            this.ClearImage.Size = new System.Drawing.Size(145, 23);
            this.ClearImage.TabIndex = 6;
            this.ClearImage.Text = "Очистить картинку";
            this.ClearImage.UseVisualStyleBackColor = true;
            this.ClearImage.Click += new System.EventHandler(this.ClearImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(883, 514);
            this.Controls.Add(this.ClearImage);
            this.Controls.Add(this.descryptImage);
            this.Controls.Add(this.descryptedMessage);
            this.Controls.Add(this.enscryptButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.image);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button enscryptButton;
        private System.Windows.Forms.RichTextBox descryptedMessage;
        private System.Windows.Forms.Button descryptImage;
        private System.Windows.Forms.Button ClearImage;
    }
}

