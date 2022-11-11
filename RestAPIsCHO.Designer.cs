
namespace CHO
{
    partial class RestAPIsCHO
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
            this.tabAPIControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inptCEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCEP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rTBJson = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rTBStatusCode = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tabAPIControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAPIControl
            // 
            this.tabAPIControl.Controls.Add(this.tabPage1);
            this.tabAPIControl.Controls.Add(this.tabPage2);
            this.tabAPIControl.Controls.Add(this.tabPage3);
            this.tabAPIControl.Location = new System.Drawing.Point(12, 12);
            this.tabAPIControl.Name = "tabAPIControl";
            this.tabAPIControl.SelectedIndex = 0;
            this.tabAPIControl.Size = new System.Drawing.Size(776, 538);
            this.tabAPIControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rTBJson);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rTBStatusCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Correios CEP API";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inptCEP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetCEP);
            this.groupBox1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // inptCEP
            // 
            this.inptCEP.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inptCEP.Location = new System.Drawing.Point(40, 39);
            this.inptCEP.Name = "inptCEP";
            this.inptCEP.Size = new System.Drawing.Size(133, 23);
            this.inptCEP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CEP";
            // 
            // btnGetCEP
            // 
            this.btnGetCEP.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCEP.Location = new System.Drawing.Point(60, 79);
            this.btnGetCEP.Name = "btnGetCEP";
            this.btnGetCEP.Size = new System.Drawing.Size(93, 31);
            this.btnGetCEP.TabIndex = 0;
            this.btnGetCEP.Text = "Chamar API";
            this.btnGetCEP.UseVisualStyleBackColor = true;
            this.btnGetCEP.Click += new System.EventHandler(this.btnGetCEP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dados Retornados";
            // 
            // rTBJson
            // 
            this.rTBJson.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBJson.Location = new System.Drawing.Point(18, 179);
            this.rTBJson.Name = "rTBJson";
            this.rTBJson.Size = new System.Drawing.Size(721, 316);
            this.rTBJson.TabIndex = 9;
            this.rTBJson.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status Chamado";
            // 
            // rTBStatusCode
            // 
            this.rTBStatusCode.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBStatusCode.Location = new System.Drawing.Point(409, 47);
            this.rTBStatusCode.Name = "rTBStatusCode";
            this.rTBStatusCode.Size = new System.Drawing.Size(250, 88);
            this.rTBStatusCode.TabIndex = 7;
            this.rTBStatusCode.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GeoLocalização API";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.richTextBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clima API";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(51, 301);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(180, 120);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status Chamado";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(279, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 304);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dados Retornados";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Endereço";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(40, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 23);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(279, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 127);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa Endereço";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar Coordenadas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latitude";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Longitude";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(40, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 23);
            this.textBox3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa Coordenadas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(279, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 127);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa Endereço";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(40, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(384, 23);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "cidade, estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Endereço";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(161, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(35, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 201);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisa Coordenadas";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(40, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 23);
            this.textBox5.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Longitude";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(40, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 23);
            this.textBox6.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Latitude";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(55, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 44);
            this.button4.TabIndex = 0;
            this.button4.Text = "Consultar Coordenadas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Dados Retornados";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(279, 183);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(464, 304);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Status Chamado";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(51, 301);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(180, 120);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            // 
            // RestAPIsCHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.tabAPIControl);
            this.Name = "RestAPIsCHO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHO - API Controller";
            this.tabAPIControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAPIControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inptCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTBJson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTBStatusCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}

