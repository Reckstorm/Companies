namespace CompaniesList
{
    partial class CompanyItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyItem));
            label1 = new Label();
            Name_TB = new Label();
            label3 = new Label();
            CEO_TB = new Label();
            label5 = new Label();
            Employees_TB = new Label();
            label7 = new Label();
            Cities = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Name_TB
            // 
            resources.ApplyResources(Name_TB, "Name_TB");
            Name_TB.Name = "Name_TB";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // CEO_TB
            // 
            resources.ApplyResources(CEO_TB, "CEO_TB");
            CEO_TB.Name = "CEO_TB";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // Employees_TB
            // 
            resources.ApplyResources(Employees_TB, "Employees_TB");
            Employees_TB.Name = "Employees_TB";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // Cities
            // 
            resources.ApplyResources(Cities, "Cities");
            Cities.AutoEllipsis = true;
            Cities.Name = "Cities";
            // 
            // CompanyItem
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(Cities);
            Controls.Add(label7);
            Controls.Add(Employees_TB);
            Controls.Add(label5);
            Controls.Add(CEO_TB);
            Controls.Add(label3);
            Controls.Add(Name_TB);
            Controls.Add(label1);
            Name = "CompanyItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Name_TB;
        private Label label3;
        private Label CEO_TB;
        private Label label5;
        private Label Employees_TB;
        private Label label7;
        private Label Cities;
    }
}
