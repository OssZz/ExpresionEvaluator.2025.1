namespace Evaluator.UI.Windows
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
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(484, 50);
            this.txtDisplay.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel.Size = new System.Drawing.Size(484, 411);
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Black;

            for (int i = 0; i < 5; i++)
                this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            for (int i = 0; i < 5; i++)
                this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            string[] buttons = {
        "7", "8", "9", "(", ")",
        "4", "5", "6", "*", "/",
        "1", "2", "3", "+", "-",
        "0", ".", "^", "Delete", "Clear",
        "=", "", "", "", ""
    };

            foreach (string btnText in buttons)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Fill;
                btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                btn.Text = btnText;
                btn.Margin = new Padding(1);
                if (btnText == "" || btnText == null)
                {
                    btn.Enabled = false;
                    btn.Visible = false;
                }
                else if ("0123456789().".Contains(btnText))
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.Black;
                }

                btn.Click += new EventHandler(ButtonClick);
                this.tableLayoutPanel.Controls.Add(btn);
            }

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Functions Evaluator";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion
    }
}
