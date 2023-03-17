namespace HW12
{
    partial class builder_of_mathematical_graphs_of_functions
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
            pbGraph = new PictureBox();
            txtFunction = new TextBox();
            btnDraw = new Button();
            txtMinX = new TextBox();
            txtMinY = new TextBox();
            txtMaxX = new TextBox();
            txtMaxY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGraph).BeginInit();
            SuspendLayout();
            // 
            // pbGraph
            // 
            pbGraph.Location = new Point(12, 20);
            pbGraph.Name = "pbGraph";
            pbGraph.Size = new Size(776, 363);
            pbGraph.TabIndex = 0;
            pbGraph.TabStop = false;
            pbGraph.Paint += pbGraph_Paint;
            // 
            // txtFunction
            // 
            txtFunction.Location = new Point(27, 405);
            txtFunction.Name = "txtFunction";
            txtFunction.Size = new Size(283, 23);
            txtFunction.TabIndex = 1;
            // 
            // btnDraw
            // 
            btnDraw.Location = new Point(343, 405);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 23);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Draw";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // txtMinX
            // 
            txtMinX.Location = new Point(475, 389);
            txtMinX.Name = "txtMinX";
            txtMinX.Size = new Size(100, 23);
            txtMinX.TabIndex = 3;
            // 
            // txtMinY
            // 
            txtMinY.Location = new Point(475, 418);
            txtMinY.Name = "txtMinY";
            txtMinY.Size = new Size(100, 23);
            txtMinY.TabIndex = 4;
            // 
            // txtMaxX
            // 
            txtMaxX.Location = new Point(667, 389);
            txtMaxX.Name = "txtMaxX";
            txtMaxX.Size = new Size(100, 23);
            txtMaxX.TabIndex = 5;
            // 
            // txtMaxY
            // 
            txtMaxY.Location = new Point(667, 418);
            txtMaxY.Name = "txtMaxY";
            txtMaxY.Size = new Size(100, 23);
            txtMaxY.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 392);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 7;
            label1.Text = "minX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 426);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "minY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 397);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "maxX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(626, 426);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "maxY";
            // 
            // builder_of_mathematical_graphs_of_functions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaxY);
            Controls.Add(txtMaxX);
            Controls.Add(txtMinY);
            Controls.Add(txtMinX);
            Controls.Add(btnDraw);
            Controls.Add(txtFunction);
            Controls.Add(pbGraph);
            Name = "builder_of_mathematical_graphs_of_functions";
            Text = "builder_of_mathematical_graphs_of_functions";
            ((System.ComponentModel.ISupportInitialize)pbGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGraph;
        private TextBox txtFunction;
        private Button btnDraw;
        private TextBox txtMinX;
        private TextBox txtMinY;
        private TextBox txtMaxX;
        private TextBox txtMaxY;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}