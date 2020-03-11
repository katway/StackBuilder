﻿#region Using directives
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

// log4net
using log4net;
// Sharp3D
using Sharp3D.Math.Core;

using treeDiM.Basics;
using treeDiM.StackBuilder.Basics;
using treeDiM.StackBuilder.Graphics;
using treeDiM.StackBuilder.Graphics.Controls;
using treeDiM.StackBuilder.Engine;
using treeDiM.StackBuilder.Desktop.Properties;
#endregion

namespace treeDiM.StackBuilder.Desktop
{
    public partial class DockContentAnalysisEdit
        : DockContentView, IDrawingContainer, IItemBaseFilter
    {
        #region Constructor
        public DockContentAnalysisEdit() : base()
        {
            _analysis = null;
            _solution = null;
            InitializeComponent();
        }
        public DockContentAnalysisEdit(IDocument document, AnalysisLayered analysis)
            : base(document)
        {
            _analysis = analysis;
            _analysis.AddListener(this);
            _solution = analysis.SolutionLay;

            InitializeComponent();
        }
        #endregion

        #region Form override
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            toolStripSepExport3D.Visible = AllowExport3D;
            toolStripButtonExport3D.Visible = AllowExport3D;

            // --- window caption
            if (null != Analysis)
                Text = Analysis.Name + " - " + Analysis.ParentDocument.Name;

            // initialize drawing container
            graphCtrlSolution.DrawingContainer = this;
            graphCtrlSolution.Viewer = new ViewerSolution(_solution);
            graphCtrlSolution.Invalidate();

            graphCtrlSolution.VolumeSelected += OnLayerSelected;

            FillGrid();
            UpdateGrid();

            FillLayerControls();
            UpdateControls();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Document.RemoveView(this);
        }
        #endregion

        #region IItemListener implementation
        public override void Update(ItemBase item)
        {
            graphCtrlSolution.Invalidate();
        }
        public override void Kill(ItemBase item)
        {
            Close();
            _analysis.RemoveListener(this);
        }
        #endregion

        #region IItemBaseFilter implementation
        public bool Accept(Control ctrl, ItemBase itemBase)
        {
            InterlayerProperties interlayer = itemBase as InterlayerProperties;
            if (ctrl == cbInterlayer && null != interlayer)
                return _analysis.AllowInterlayer(interlayer);
            return false;
        }
        #endregion

        #region Public properties
        protected virtual bool AllowExport3D => false; 
        public AnalysisLayered Analysis => _analysis;
        public SolutionLayered Solution
        {
            get { return _solution; }
            set { _solution = value; }
        }
        #endregion

        #region Virtual properties
        protected virtual string GridCaption => Resources.ID_LOAD;
        #endregion

        #region IDrawingContainer
        public void Draw(Graphics3DControl ctrl, Graphics3D graphics)
        {
            using (ViewerSolution sv = new ViewerSolution(Solution))
                sv.Draw(graphics, Transform3D.Identity);
        }
        #endregion

        #region Virtual functions
        public virtual void FillGrid()
        {
            // clear grid
            gridSolution.Rows.Clear();
            // border
            gridSolution.BorderStyle = BorderStyle.FixedSingle;
            gridSolution.ColumnsCount = 2;
            gridSolution.FixedColumns = 1;
        }
        public virtual void UpdateGrid()
        {
            try
            {
                // remove all existing rows
                gridSolution.Rows.Clear();
 
                // cell visual properties
                var vPropHeader = CellProperties.VisualPropHeader;
                var vPropValue = CellProperties.VisualPropValue;

                SourceGrid.Cells.RowHeader rowHeader;
                int iRow = -1;

                // loading caption
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(GridCaption)
                {
                    ColumnSpan = 2,
                    View = vPropHeader
                };
                gridSolution[iRow, 0] = rowHeader;
                // layer #
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(Resources.ID_LAYERCOUNT)
                {
                    View = vPropValue
                };
                gridSolution[iRow, 0] = rowHeader;
                gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(_solution.LayerCount);
                // interlayer #
                if (_solution.InterlayerCount > 0)
                {
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(Resources.ID_INTERLAYERCOUNT)
                    {
                        View = vPropValue
                    };
                    gridSolution[iRow, 0] = rowHeader;
                    gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(_solution.InterlayerCount);
                }
                // *** Item # (Recursive count)
                Packable content = _analysis.Content;
                int itemCount = _solution.ItemCount;
                int number = 1;
                do
                {
                    itemCount *= number;
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(string.Format("{0} #", content.DetailedName))
                    {
                        View = vPropValue
                    };
                    gridSolution[iRow, 0] = rowHeader;
                    gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(itemCount);
                }
                while (null != content && content.InnerContent(ref content, ref number));
                // ***

                // load dimensions
                BBox3D bboxLoad = _solution.BBoxLoad;
                // ---
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(
                    string.Format(Resources.ID_LOADDIMENSIONS, UnitsManager.LengthUnitString))
                {
                    View = vPropValue
                };
                gridSolution[iRow, 0] = rowHeader;
                gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                    string.Format(CultureInfo.InvariantCulture, "{0:0.#} x {1:0.#} x {2:0.#}", bboxLoad.Length, bboxLoad.Width, bboxLoad.Height));
                // net weight
                if (_solution.HasNetWeight)
                {
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(
                        string.Format(Resources.ID_NETWEIGHT_WU, UnitsManager.MassUnitString))
                    {
                        View = vPropValue
                    };
                    gridSolution[iRow, 0] = rowHeader;
                    gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                        string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.NetWeight));
                }
                // load weight
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(
                    string.Format(Resources.ID_LOADWEIGHT_WU, UnitsManager.MassUnitString))
                {
                    View = vPropValue
                };
                gridSolution[iRow, 0] = rowHeader;
                gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                    string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.LoadWeight));
                // total weight
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(
                    string.Format(Resources.ID_TOTALWEIGHT_WU, UnitsManager.MassUnitString))
                {
                    View = vPropValue
                };
                gridSolution[iRow, 0] = rowHeader;
                gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                    string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.Weight));
                // volume efficiency
                gridSolution.Rows.Insert(++iRow);
                rowHeader = new SourceGrid.Cells.RowHeader(Resources.ID_VOLUMEEFFICIENCY)
                {
                    View = vPropValue
                };
                gridSolution[iRow, 0] = rowHeader;
                gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                    string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.VolumeEfficiency));


                int noLayerTypesUsed = 0;
                for (int i = 0; i < _solution.Layers.Count; ++i)
                    noLayerTypesUsed += _solution.Layers[i].BoxCount > 0 ? 1 : 0;

                // ### layers : begin
                for (int i = 0; i < _solution.NoLayerTypesUsed; ++i)
                {
                    // layer caption
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(_solution.LayerCaption(i))
                    {
                        ColumnSpan = 2,
                        View = vPropHeader
                    };
                    gridSolution[iRow, 0] = rowHeader;

                    // *** Item # (recursive count)
                    content = _analysis.Content;
                    itemCount = _solution.LayerBoxCount(i);
                    number = 1;
                    do
                    {
                        itemCount *= number;

                        gridSolution.Rows.Insert(++iRow);
                        rowHeader = new SourceGrid.Cells.RowHeader(
                            string.Format("{0} #", content.DetailedName))
                        {
                            View = vPropValue
                        };
                        gridSolution[iRow, 0] = rowHeader;
                        gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(itemCount);
                    }
                    while (null != content && content.InnerContent(ref content, ref number));
                    // ***

                    // layer weight
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(string.Format(Resources.ID_WEIGHT_WU, UnitsManager.MassUnitString))
                    {
                        View = vPropValue
                    };
                    gridSolution[iRow, 0] = rowHeader;
                    gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                        string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.LayerWeight(i)));
                    // layer space
                    gridSolution.Rows.Insert(++iRow);
                    rowHeader = new SourceGrid.Cells.RowHeader(string.Format(Resources.ID_SPACES_WU, UnitsManager.LengthUnitString))
                    {
                        View = vPropValue
                    };
                    gridSolution[iRow, 0] = rowHeader;
                    gridSolution[iRow, 1] = new SourceGrid.Cells.Cell(
                        string.Format(CultureInfo.InvariantCulture, "{0:0.#}", _solution.LayerMaximumSpace(i)));
                }
                // ### layers : end

                gridSolution.AutoSizeCells();
                gridSolution.Columns.StretchToFit();
                gridSolution.AutoStretchColumnsToFitWidth = true;
                gridSolution.Invalidate();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }
        #endregion

        #region Event handlers
        private void OnLayerSelected(int id)
        {
            try
            {
                _solution.SelectLayer(id);
                UpdateControls();
            }
            catch (Exception ex)
            {   _log.Error(ex.ToString()); }
        }
        private void OnLayerTypeChanged(object sender, EventArgs e)
        {
            try
            {
                int iLayerType = cbLayerType.SelectedIndex;
                // get selected layer
                _solution.SetLayerTypeOnSelected(iLayerType);
                // redraw
                graphCtrlSolution.Invalidate();
                UpdateGrid();
            }
            catch (Exception ex)
            {   _log.Error(ex.ToString()); }
        }
        private void OnInterlayerChanged(object sender, EventArgs e)
        {
            try
            {
                // get index of interlayer
                InterlayerProperties interlayer = null;
                if (chkbInterlayer.Checked)
                    interlayer = cbInterlayer.SelectedType as InterlayerProperties;
                _solution.SetInterlayerOnSelected(interlayer);
                graphCtrlSolution.Invalidate();
                UpdateGrid();
            }
            catch (Exception ex)
            {   _log.Error(ex.ToString()); }
        }
        private void OnReflectionX(object sender, EventArgs e)
        {
            _solution.ApplySymetryOnSelected(0);
            graphCtrlSolution.Invalidate();
        }
        private void OnReflectionY(object sender, EventArgs e)
        {
            _solution.ApplySymetryOnSelected(1);
            graphCtrlSolution.Invalidate();
        }
        private void OnChkbInterlayerClicked(object sender, EventArgs e)
        {
            try
            {
                cbInterlayer.Enabled = chkbInterlayer.Checked;
                OnInterlayerChanged(null, null);
                UpdateGrid();
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }
        #endregion

        #region Toolbar event handlers
        private void OnBack(object sender, EventArgs e)
        {
            // close this form
            Close();
            // call edit analysis
            Document.EditAnalysis(_analysis);
        }
        private void OnGenerateReport(object sender, EventArgs e)
        {
            FormMain.GetInstance().GenerateReport(_analysis);
        }
        private void OnGenerateExport(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            string formatName = string.Empty;
            switch (tsb.Name)
            {
                case "toolStripButtonExportXML": formatName = Exporters.ExporterXML.FormatName; break;
                case "toolStripButtonExportCSV": formatName = Exporters.ExporterCSV.FormatName; break;
                case "toolStripButtonExportDAE": formatName = Exporters.ExporterCollada.FormatName; break;
                default: break;
            }
            FormMain.GetInstance().GenerateExport(_analysis, formatName);
        }
        private void OnExport3D(object sender, EventArgs e)
        {
            var form = new SaveFileDialog()
            {
                Filter = "Binary GL Transmission Format (*.glb)|*.glb",
                DefaultExt = "glb",
                FileName = $"{_analysis.Name}.glb"
            };
            if (DialogResult.OK == form.ShowDialog())
            {
                var exporter = new Exporters.ExporterGLB();
                exporter.Export(_analysis as AnalysisLayered, form.FileName);
            }
        }
        #endregion

        #region Layer controls
        private void FillLayerControls()
        {
            try
            {
                cbLayerType.Packable = _analysis.Content;
                // build layers and fill CCtrl
                foreach (var layerEncap in _solution.LayerEncaps)
                {
                    if (null != layerEncap.LayerDesc)
                    {
                        LayerSolver solver = new LayerSolver();
                        ILayer2D layer = solver.BuildLayer(_analysis.Content, _analysis.ContainerDimensions, layerEncap.LayerDesc, _analysis.ConstraintSet.MinimumSpace.Value);
                        cbLayerType.Items.Add(layer);
                    }
                    else if (null != layerEncap.Layer2D)
                        cbLayerType.Items.Add(layerEncap.Layer2D);
                }
                if (cbLayerType.Items.Count > 0)
                    cbLayerType.SelectedIndex = 0;

                // fill combo cbInterlayer
                Document document = Document as Document;
                cbInterlayer.Initialize(document, this, null);
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }
        protected void UpdateControls()
        {
            try
            {
                int index = _solution.SelectedLayerIndex;
                bnSymmetryX.Enabled = (index != -1);
                bnSymetryY.Enabled = (index != -1);
                cbLayerType.Enabled = (index != -1);
                chkbInterlayer.Enabled = (index != -1) && (cbInterlayer.Items.Count > 0);

                gbLayer.Text = index != -1 ? string.Format("Selected layer : {0}", index) : "Double-click a layer";

                if (index != -1)
                {
                    tbClickLayer.Hide();
                    gbLayer.Show();

                    // get selected solution item
                    SolutionItem selItem = _solution.SelectedSolutionItem;
                    if (null != selItem)
                    {
                        // set current layer
                        cbLayerType.SelectedIndex = selItem.IndexLayer;
                        // set interlayer
                        chkbInterlayer.Checked = selItem.HasInterlayer;
                        OnChkbInterlayerClicked(null, null);
                    }
                    // select combo box
                    int selIndex = 0;
                    foreach (object o in cbInterlayer.Items)
                    {
                        InterlayerProperties interlayerProp = o as InterlayerProperties;
                        if (interlayerProp == _solution.SelectedInterlayer)
                            break;
                        ++selIndex;
                    }
                    if (selIndex < cbInterlayer.Items.Count)
                        cbInterlayer.SelectedIndex = selIndex;
                }
                else
                {
                    gbLayer.Hide();
                    tbClickLayer.Show();
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
            }
        }
        #endregion

        #region Data members
        /// <summary>
        /// analysis
        /// </summary>
        protected AnalysisLayered _analysis;
        /// <summary>
        /// solution
        /// </summary>
        protected SolutionLayered _solution;
        /// <summary>
        /// logger
        /// </summary>
        protected static readonly ILog _log = LogManager.GetLogger(typeof(DockContentAnalysisEdit));
        #endregion


    }
}
