﻿namespace treeDiM.StackBuilder.Desktop
{
    partial class DockContentAnalysisCasePallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockContentAnalysisCasePallet));
            this.gbStopCriterions = new System.Windows.Forms.GroupBox();
            this.uCtrlOptMaxNumber = new treeDiM.Basics.UCtrlOptInt();
            this.uCtrlOptMaximumWeight = new treeDiM.Basics.UCtrlOptDouble();
            this.uCtrlMaxPalletHeight = new treeDiM.Basics.UCtrlDouble();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPageStrappers = new System.Windows.Forms.TabPage();
            this.ctrlStrapperSet = new treeDiM.StackBuilder.Basics.Controls.CtrlStrapperSet();
            this.tabPagePalletCorners = new System.Windows.Forms.TabPage();
            this.cbPalletCorners = new System.Windows.Forms.ComboBox();
            this.chkbPalletCorners = new System.Windows.Forms.CheckBox();
            this.tabPagePalletCornersTop = new System.Windows.Forms.TabPage();
            this.chkbPalletCornersTopY = new System.Windows.Forms.CheckBox();
            this.cbPalletCornersTop = new System.Windows.Forms.ComboBox();
            this.chkbPalletCornersTopX = new System.Windows.Forms.CheckBox();
            this.tabPagePalletCap = new System.Windows.Forms.TabPage();
            this.cbPalletCap = new System.Windows.Forms.ComboBox();
            this.chkbPalletCap = new System.Windows.Forms.CheckBox();
            this.tabPagePalletFilm = new System.Windows.Forms.TabPage();
            this.uCtrlPalletFilmCovering = new treeDiM.Basics.UCtrlDouble();
            this.uCtrlPalletFilmLength = new treeDiM.Basics.UCtrlDouble();
            this.cbPalletFilm = new System.Windows.Forms.ComboBox();
            this.chkbPalletFilm = new System.Windows.Forms.CheckBox();
            this.tabPagePalletSleeve = new System.Windows.Forms.TabPage();
            this.comboBoxColorPicker1 = new OfficePickers.ColorPicker.ComboBoxColorPicker();
            this.chkbSleeve = new System.Windows.Forms.CheckBox();
            this.tabPagePalletLabels = new System.Windows.Forms.TabPage();
            this.cbPalletLabels = new System.Windows.Forms.ComboBox();
            this.bnAdd = new System.Windows.Forms.Button();
            this.gridLabels = new SourceGrid.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).BeginInit();
            this.splitContainerHoriz.Panel1.SuspendLayout();
            this.splitContainerHoriz.Panel2.SuspendLayout();
            this.splitContainerHoriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).BeginInit();
            this.splitContainerVert.Panel1.SuspendLayout();
            this.splitContainerVert.Panel2.SuspendLayout();
            this.splitContainerVert.SuspendLayout();
            this.gbStopCriterions.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabPageStrappers.SuspendLayout();
            this.tabPagePalletCorners.SuspendLayout();
            this.tabPagePalletCornersTop.SuspendLayout();
            this.tabPagePalletCap.SuspendLayout();
            this.tabPagePalletFilm.SuspendLayout();
            this.tabPagePalletSleeve.SuspendLayout();
            this.tabPagePalletLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphCtrlSolution
            // 
            resources.ApplyResources(this.graphCtrlSolution, "graphCtrlSolution");
            // 
            // splitContainerHoriz
            // 
            // 
            // splitContainerHoriz.Panel2
            // 
            this.splitContainerHoriz.Panel2.Controls.Add(this.gbStopCriterions);
            this.splitContainerHoriz.Panel2.Controls.Add(this.tabCtrl);
            resources.ApplyResources(this.splitContainerHoriz, "splitContainerHoriz");
            // 
            // splitContainerVert
            // 
            resources.ApplyResources(this.splitContainerVert, "splitContainerVert");
            // 
            // gridSolution
            // 
            resources.ApplyResources(this.gridSolution, "gridSolution");
            // 
            // gbStopCriterions
            // 
            resources.ApplyResources(this.gbStopCriterions, "gbStopCriterions");
            this.gbStopCriterions.Controls.Add(this.uCtrlOptMaxNumber);
            this.gbStopCriterions.Controls.Add(this.uCtrlOptMaximumWeight);
            this.gbStopCriterions.Controls.Add(this.uCtrlMaxPalletHeight);
            this.gbStopCriterions.Name = "gbStopCriterions";
            this.gbStopCriterions.TabStop = false;
            // 
            // uCtrlOptMaxNumber
            // 
            resources.ApplyResources(this.uCtrlOptMaxNumber, "uCtrlOptMaxNumber");
            this.uCtrlOptMaxNumber.Minimum = 0;
            this.uCtrlOptMaxNumber.Name = "uCtrlOptMaxNumber";
            this.uCtrlOptMaxNumber.ValueChanged += new treeDiM.Basics.UCtrlOptInt.ValueChangedDelegate(this.OnCriterionChanged);
            // 
            // uCtrlOptMaximumWeight
            // 
            resources.ApplyResources(this.uCtrlOptMaximumWeight, "uCtrlOptMaximumWeight");
            this.uCtrlOptMaximumWeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlOptMaximumWeight.Name = "uCtrlOptMaximumWeight";
            this.uCtrlOptMaximumWeight.Unit = treeDiM.Basics.UnitsManager.UnitType.UT_MASS;
            // 
            // uCtrlMaxPalletHeight
            // 
            resources.ApplyResources(this.uCtrlMaxPalletHeight, "uCtrlMaxPalletHeight");
            this.uCtrlMaxPalletHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.uCtrlMaxPalletHeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlMaxPalletHeight.Name = "uCtrlMaxPalletHeight";
            this.uCtrlMaxPalletHeight.Unit = treeDiM.Basics.UnitsManager.UnitType.UT_LENGTH;
            // 
            // tabCtrl
            // 
            resources.ApplyResources(this.tabCtrl, "tabCtrl");
            this.tabCtrl.Controls.Add(this.tabPageStrappers);
            this.tabCtrl.Controls.Add(this.tabPagePalletCorners);
            this.tabCtrl.Controls.Add(this.tabPagePalletCornersTop);
            this.tabCtrl.Controls.Add(this.tabPagePalletCap);
            this.tabCtrl.Controls.Add(this.tabPagePalletFilm);
            this.tabCtrl.Controls.Add(this.tabPagePalletLabels);
            this.tabCtrl.Controls.Add(this.tabPagePalletSleeve);
            this.tabCtrl.Multiline = true;
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            // 
            // tabPageStrappers
            // 
            this.tabPageStrappers.Controls.Add(this.ctrlStrapperSet);
            resources.ApplyResources(this.tabPageStrappers, "tabPageStrappers");
            this.tabPageStrappers.Name = "tabPageStrappers";
            this.tabPageStrappers.UseVisualStyleBackColor = true;
            // 
            // ctrlStrapperSet
            // 
            resources.ApplyResources(this.ctrlStrapperSet, "ctrlStrapperSet");
            this.ctrlStrapperSet.Name = "ctrlStrapperSet";
            this.ctrlStrapperSet.Number = 0;
            this.ctrlStrapperSet.StrapperSet = null;
            this.ctrlStrapperSet.ValueChanged += new treeDiM.StackBuilder.Basics.Controls.CtrlStrapperSet.OnValueChanged(this.OnPalletProtectionChanged);
            // 
            // tabPagePalletCorners
            // 
            this.tabPagePalletCorners.Controls.Add(this.cbPalletCorners);
            this.tabPagePalletCorners.Controls.Add(this.chkbPalletCorners);
            resources.ApplyResources(this.tabPagePalletCorners, "tabPagePalletCorners");
            this.tabPagePalletCorners.Name = "tabPagePalletCorners";
            this.tabPagePalletCorners.UseVisualStyleBackColor = true;
            // 
            // cbPalletCorners
            // 
            this.cbPalletCorners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletCorners.FormattingEnabled = true;
            resources.ApplyResources(this.cbPalletCorners, "cbPalletCorners");
            this.cbPalletCorners.Name = "cbPalletCorners";
            this.cbPalletCorners.SelectedIndexChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // chkbPalletCorners
            // 
            resources.ApplyResources(this.chkbPalletCorners, "chkbPalletCorners");
            this.chkbPalletCorners.Name = "chkbPalletCorners";
            this.chkbPalletCorners.UseVisualStyleBackColor = true;
            this.chkbPalletCorners.CheckedChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // tabPagePalletCornersTop
            // 
            this.tabPagePalletCornersTop.Controls.Add(this.chkbPalletCornersTopY);
            this.tabPagePalletCornersTop.Controls.Add(this.cbPalletCornersTop);
            this.tabPagePalletCornersTop.Controls.Add(this.chkbPalletCornersTopX);
            resources.ApplyResources(this.tabPagePalletCornersTop, "tabPagePalletCornersTop");
            this.tabPagePalletCornersTop.Name = "tabPagePalletCornersTop";
            this.tabPagePalletCornersTop.UseVisualStyleBackColor = true;
            // 
            // chkbPalletCornersTopY
            // 
            resources.ApplyResources(this.chkbPalletCornersTopY, "chkbPalletCornersTopY");
            this.chkbPalletCornersTopY.Name = "chkbPalletCornersTopY";
            this.chkbPalletCornersTopY.UseVisualStyleBackColor = true;
            this.chkbPalletCornersTopY.CheckedChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // cbPalletCornersTop
            // 
            this.cbPalletCornersTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletCornersTop.FormattingEnabled = true;
            resources.ApplyResources(this.cbPalletCornersTop, "cbPalletCornersTop");
            this.cbPalletCornersTop.Name = "cbPalletCornersTop";
            this.cbPalletCornersTop.SelectedIndexChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // chkbPalletCornersTopX
            // 
            resources.ApplyResources(this.chkbPalletCornersTopX, "chkbPalletCornersTopX");
            this.chkbPalletCornersTopX.Name = "chkbPalletCornersTopX";
            this.chkbPalletCornersTopX.UseVisualStyleBackColor = true;
            this.chkbPalletCornersTopX.CheckedChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // tabPagePalletCap
            // 
            this.tabPagePalletCap.Controls.Add(this.cbPalletCap);
            this.tabPagePalletCap.Controls.Add(this.chkbPalletCap);
            resources.ApplyResources(this.tabPagePalletCap, "tabPagePalletCap");
            this.tabPagePalletCap.Name = "tabPagePalletCap";
            this.tabPagePalletCap.UseVisualStyleBackColor = true;
            // 
            // cbPalletCap
            // 
            this.cbPalletCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletCap.FormattingEnabled = true;
            resources.ApplyResources(this.cbPalletCap, "cbPalletCap");
            this.cbPalletCap.Name = "cbPalletCap";
            this.cbPalletCap.SelectedIndexChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // chkbPalletCap
            // 
            resources.ApplyResources(this.chkbPalletCap, "chkbPalletCap");
            this.chkbPalletCap.Name = "chkbPalletCap";
            this.chkbPalletCap.UseVisualStyleBackColor = true;
            this.chkbPalletCap.CheckedChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // tabPagePalletFilm
            // 
            this.tabPagePalletFilm.Controls.Add(this.uCtrlPalletFilmCovering);
            this.tabPagePalletFilm.Controls.Add(this.uCtrlPalletFilmLength);
            this.tabPagePalletFilm.Controls.Add(this.cbPalletFilm);
            this.tabPagePalletFilm.Controls.Add(this.chkbPalletFilm);
            resources.ApplyResources(this.tabPagePalletFilm, "tabPagePalletFilm");
            this.tabPagePalletFilm.Name = "tabPagePalletFilm";
            this.tabPagePalletFilm.UseVisualStyleBackColor = true;
            // 
            // uCtrlPalletFilmCovering
            // 
            resources.ApplyResources(this.uCtrlPalletFilmCovering, "uCtrlPalletFilmCovering");
            this.uCtrlPalletFilmCovering.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.uCtrlPalletFilmCovering.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlPalletFilmCovering.Name = "uCtrlPalletFilmCovering";
            this.uCtrlPalletFilmCovering.Unit = treeDiM.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlPalletFilmCovering.ValueChanged += new treeDiM.Basics.UCtrlDouble.ValueChangedDelegate(this.OnPalletProtectionChanged);
            // 
            // uCtrlPalletFilmLength
            // 
            resources.ApplyResources(this.uCtrlPalletFilmLength, "uCtrlPalletFilmLength");
            this.uCtrlPalletFilmLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.uCtrlPalletFilmLength.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.uCtrlPalletFilmLength.Name = "uCtrlPalletFilmLength";
            this.uCtrlPalletFilmLength.Unit = treeDiM.Basics.UnitsManager.UnitType.UT_LENGTH;
            this.uCtrlPalletFilmLength.ValueChanged += new treeDiM.Basics.UCtrlDouble.ValueChangedDelegate(this.OnPalletProtectionChanged);
            // 
            // cbPalletFilm
            // 
            this.cbPalletFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletFilm.FormattingEnabled = true;
            resources.ApplyResources(this.cbPalletFilm, "cbPalletFilm");
            this.cbPalletFilm.Name = "cbPalletFilm";
            this.cbPalletFilm.SelectedIndexChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // chkbPalletFilm
            // 
            resources.ApplyResources(this.chkbPalletFilm, "chkbPalletFilm");
            this.chkbPalletFilm.Name = "chkbPalletFilm";
            this.chkbPalletFilm.UseVisualStyleBackColor = true;
            this.chkbPalletFilm.CheckedChanged += new System.EventHandler(this.OnPalletProtectionChanged);
            // 
            // tabPagePalletSleeve
            // 
            this.tabPagePalletSleeve.Controls.Add(this.comboBoxColorPicker1);
            this.tabPagePalletSleeve.Controls.Add(this.chkbSleeve);
            resources.ApplyResources(this.tabPagePalletSleeve, "tabPagePalletSleeve");
            this.tabPagePalletSleeve.Name = "tabPagePalletSleeve";
            this.tabPagePalletSleeve.UseVisualStyleBackColor = true;
            // 
            // comboBoxColorPicker1
            // 
            this.comboBoxColorPicker1.Color = System.Drawing.Color.Beige;
            this.comboBoxColorPicker1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColorPicker1.DropDownHeight = 1;
            this.comboBoxColorPicker1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColorPicker1.DropDownWidth = 1;
            this.comboBoxColorPicker1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxColorPicker1, "comboBoxColorPicker1");
            this.comboBoxColorPicker1.Items.AddRange(new object[] {
            resources.GetString("comboBoxColorPicker1.Items"),
            resources.GetString("comboBoxColorPicker1.Items1"),
            resources.GetString("comboBoxColorPicker1.Items2"),
            resources.GetString("comboBoxColorPicker1.Items3")});
            this.comboBoxColorPicker1.Name = "comboBoxColorPicker1";
            // 
            // chkbSleeve
            // 
            resources.ApplyResources(this.chkbSleeve, "chkbSleeve");
            this.chkbSleeve.Name = "chkbSleeve";
            this.chkbSleeve.UseVisualStyleBackColor = true;
            // 
            // tabPagePalletLabels
            // 
            this.tabPagePalletLabels.Controls.Add(this.cbPalletLabels);
            this.tabPagePalletLabels.Controls.Add(this.bnAdd);
            this.tabPagePalletLabels.Controls.Add(this.gridLabels);
            resources.ApplyResources(this.tabPagePalletLabels, "tabPagePalletLabels");
            this.tabPagePalletLabels.Name = "tabPagePalletLabels";
            this.tabPagePalletLabels.UseVisualStyleBackColor = true;
            // 
            // cbPalletLabels
            // 
            resources.ApplyResources(this.cbPalletLabels, "cbPalletLabels");
            this.cbPalletLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalletLabels.FormattingEnabled = true;
            this.cbPalletLabels.Name = "cbPalletLabels";
            // 
            // bnAdd
            // 
            resources.ApplyResources(this.bnAdd, "bnAdd");
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.OnBnAddLabel);
            // 
            // gridLabels
            // 
            resources.ApplyResources(this.gridLabels, "gridLabels");
            this.gridLabels.EnableSort = true;
            this.gridLabels.Name = "gridLabels";
            this.gridLabels.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.gridLabels.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.gridLabels.TabStop = true;
            this.gridLabels.ToolTipText = "";
            // 
            // DockContentAnalysisCasePallet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DockContentAnalysisCasePallet";
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.graphCtrlSolution)).EndInit();
            this.splitContainerHoriz.Panel1.ResumeLayout(false);
            this.splitContainerHoriz.Panel2.ResumeLayout(false);
            this.splitContainerHoriz.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHoriz)).EndInit();
            this.splitContainerHoriz.ResumeLayout(false);
            this.splitContainerVert.Panel1.ResumeLayout(false);
            this.splitContainerVert.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).EndInit();
            this.splitContainerVert.ResumeLayout(false);
            this.gbStopCriterions.ResumeLayout(false);
            this.tabCtrl.ResumeLayout(false);
            this.tabPageStrappers.ResumeLayout(false);
            this.tabPagePalletCorners.ResumeLayout(false);
            this.tabPagePalletCorners.PerformLayout();
            this.tabPagePalletCornersTop.ResumeLayout(false);
            this.tabPagePalletCornersTop.PerformLayout();
            this.tabPagePalletCap.ResumeLayout(false);
            this.tabPagePalletCap.PerformLayout();
            this.tabPagePalletFilm.ResumeLayout(false);
            this.tabPagePalletFilm.PerformLayout();
            this.tabPagePalletSleeve.ResumeLayout(false);
            this.tabPagePalletSleeve.PerformLayout();
            this.tabPagePalletLabels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPagePalletCorners;
        private System.Windows.Forms.ComboBox cbPalletCorners;
        private System.Windows.Forms.CheckBox chkbPalletCorners;
        private System.Windows.Forms.TabPage tabPagePalletCap;
        private System.Windows.Forms.ComboBox cbPalletCap;
        private System.Windows.Forms.CheckBox chkbPalletCap;
        private System.Windows.Forms.TabPage tabPagePalletFilm;
        private System.Windows.Forms.ComboBox cbPalletFilm;
        private System.Windows.Forms.CheckBox chkbPalletFilm;
        private System.Windows.Forms.GroupBox gbStopCriterions;
        private treeDiM.Basics.UCtrlDouble uCtrlMaxPalletHeight;
        private treeDiM.Basics.UCtrlOptDouble uCtrlOptMaximumWeight;
        private treeDiM.Basics.UCtrlOptInt uCtrlOptMaxNumber;
        private System.Windows.Forms.TabPage tabPageStrappers;
        private Basics.Controls.CtrlStrapperSet ctrlStrapperSet;
        private System.Windows.Forms.TabPage tabPagePalletCornersTop;
        private System.Windows.Forms.ComboBox cbPalletCornersTop;
        private System.Windows.Forms.CheckBox chkbPalletCornersTopX;
        private System.Windows.Forms.CheckBox chkbPalletCornersTopY;
        private System.Windows.Forms.TabPage tabPagePalletSleeve;
        private System.Windows.Forms.CheckBox chkbSleeve;
        private System.Windows.Forms.TabPage tabPagePalletLabels;
        private OfficePickers.ColorPicker.ComboBoxColorPicker comboBoxColorPicker1;
        private System.Windows.Forms.Button bnAdd;
        private SourceGrid.Grid gridLabels;
        private System.Windows.Forms.ComboBox cbPalletLabels;
        private treeDiM.Basics.UCtrlDouble uCtrlPalletFilmCovering;
        private treeDiM.Basics.UCtrlDouble uCtrlPalletFilmLength;
    }
}