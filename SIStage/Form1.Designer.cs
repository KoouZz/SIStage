using System.Windows.Forms;
using System.Drawing;
using System.Security.Permissions;
using System.Linq;



namespace SIStage
{
    partial class MainWindow
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
            this.SuspendLayout();
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainWindow";
            this.Text = "SIStage";
            this.Font = new Font("MS Sans Serif", 14F);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion


        private void InitComponentsAtForm(string btn)
        {
            if (btn == "sis")
            {
                Controls.Clear();
                InitMainComponents();
            } 
            if (btn == "led")
            {
                Controls.Clear();
                InitMainComponents();

                Label ledTest = new Label();
                ledTest.Font = new Font("MS Sans Serif", 20F);
                ledTest.Size = new Size(300, 50);
                ledTest.Text = "Тест кнопки экраны";
                ledTest.Location = new Point(Width / 2 - ledTest.Width / 2, Height / 2 - ledTest.Height / 2);
                Controls.Add(ledTest);
            }

            if (btn == "autoRetail")
            {
                Controls.Clear();
                InitMainComponents();

                Label autoRetailTest = new Label();
                autoRetailTest.Font = new Font("MS Sans Serif", 20F);
                autoRetailTest.Size = new Size(300, 50);
                autoRetailTest.Text = "Тест кнопки киоски";
                autoRetailTest.Location = new Point(Width / 2 - autoRetailTest.Width / 2, Height / 2 - autoRetailTest.Height / 2);
                Controls.Add(autoRetailTest);
            }

            if (btn == "search")
            {
                Controls.Clear();
                InitMainComponents();

                Label searchTest = new Label();
                searchTest.Font = new Font("MS Sans Serif", 20F);
                searchTest.Size = new Size(300, 50);
                searchTest.Text = "Тест кнопки поиск";
                searchTest.Location = new Point(Width / 2 - searchTest.Width / 2, Height / 2 - searchTest.Height / 2);
                Controls.Add(searchTest);
            }


        }
        private void InitMainComponents()
        {
            Button sis = new Button();
            Button led = new Button();
            Button autoRetail = new Button();
            Button search = new Button();

            sis.Location = new Point(0, 0);
            sis.Text = "SIStage";
            sis.Name = "sis";
            sis.Size = new Size(Width / 4, Height / 10);
            sis.MinimumSize = new Size(100, 50);
            sis.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            sis.Click += Sis_Click;
            Controls.Add(sis);

            led.Location = new Point(sis.Location.X + sis.Width, sis.Location.Y);
            led.Text = "Экраны";
            led.Size = new Size(sis.Width, sis.Height);
            led.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            led.Click += Led_Click;
            Controls.Add(led);

            autoRetail.Location = new Point(led.Location.X + led.Width, led.Location.Y);
            autoRetail.Text = "Киоски";
            autoRetail.Size = new Size(sis.Width, sis.Height);
            autoRetail.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            autoRetail.Click += AutoRetail_Click;
            Controls.Add(autoRetail);

            search.Location = new Point(autoRetail.Location.X + autoRetail.Width, autoRetail.Location.Y);
            search.Text = "Поиск";
            search.Size = new Size(sis.Width, sis.Height);
            search.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            search.Click += Search_Click;
            Controls.Add(search);
        }

        private void Search_Click(object sender, System.EventArgs e)
        {
            InitComponentsAtForm("search");
        }

        private void AutoRetail_Click(object sender, System.EventArgs e)
        {
            InitComponentsAtForm("autoRetail");
        }

        private void Led_Click(object sender, System.EventArgs e)
        {
            InitComponentsAtForm("led");
        }

        private void Sis_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
            InitComponentsAtForm("sis");
        }
    }
}

