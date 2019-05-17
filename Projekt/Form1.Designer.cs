namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabela = new System.Windows.Forms.DataGridView();
            this.lPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwafirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicanrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powiatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polisa1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polisa2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przychodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eBIDTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDEEBIDTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marża1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marża2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Wyswietl_dane = new System.Windows.Forms.Button();
            this.Wyszukaj = new System.Windows.Forms.TextBox();
            this.po_nazwie_firmy = new System.Windows.Forms.Button();
            this.po_REGON = new System.Windows.Forms.Button();
            this.po_nazwisku = new System.Windows.Forms.Button();
            this.po_miescie = new System.Windows.Forms.Button();
            this.po_powiecie = new System.Windows.Forms.Button();
            this.po_data1_mniejsze = new System.Windows.Forms.Button();
            this.po_data2_mniejsze = new System.Windows.Forms.Button();
            this.po_data1_wieksze = new System.Windows.Forms.Button();
            this.po_data2_wieksze = new System.Windows.Forms.Button();
            this.po_przychody_mniejsze = new System.Windows.Forms.Button();
            this.po_przychody_wieksze = new System.Windows.Forms.Button();
            this.po_EBIDTA_wieksze = new System.Windows.Forms.Button();
            this.po_EBIDTA_mniejsze = new System.Windows.Forms.Button();
            this.dodaj_firme = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.Usunieto_element = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pokaz_wykres = new System.Windows.Forms.RadioButton();
            this.ukryj_wykres = new System.Windows.Forms.RadioButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Drukuj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Liczba_firm = new System.Windows.Forms.Label();
            this.zamknij = new System.Windows.Forms.Button();
            this.wykres = new System.Windows.Forms.Panel();
            this.firmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.AutoGenerateColumns = false;
            this.tabela.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lPDataGridViewTextBoxColumn,
            this.nazwafirmyDataGridViewTextBoxColumn,
            this.rEGONDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicanrDataGridViewTextBoxColumn,
            this.powiatDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.polisa1DataGridViewTextBoxColumn,
            this.polisa2DataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.przychodyDataGridViewTextBoxColumn,
            this.eBIDTADataGridViewTextBoxColumn,
            this.nDEEBIDTADataGridViewTextBoxColumn,
            this.dSCRDataGridViewTextBoxColumn,
            this.marża1DataGridViewTextBoxColumn,
            this.marża2DataGridViewTextBoxColumn});
            this.tabela.DataSource = this.firmaBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabela.Location = new System.Drawing.Point(206, 56);
            this.tabela.Name = "tabela";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabela.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tabela.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabela.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tabela.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.tabela.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.tabela.RowTemplate.Height = 25;
            this.tabela.Size = new System.Drawing.Size(1640, 876);
            this.tabela.TabIndex = 2;
            this.tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellContentClick);
            this.tabela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SidePanel_MouseMove);
            // 
            // lPDataGridViewTextBoxColumn
            // 
            this.lPDataGridViewTextBoxColumn.DataPropertyName = "LP";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.lPDataGridViewTextBoxColumn.HeaderText = "LP";
            this.lPDataGridViewTextBoxColumn.Name = "lPDataGridViewTextBoxColumn";
            // 
            // nazwafirmyDataGridViewTextBoxColumn
            // 
            this.nazwafirmyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_firmy";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F);
            this.nazwafirmyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nazwafirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa_firmy";
            this.nazwafirmyDataGridViewTextBoxColumn.Name = "nazwafirmyDataGridViewTextBoxColumn";
            // 
            // rEGONDataGridViewTextBoxColumn
            // 
            this.rEGONDataGridViewTextBoxColumn.DataPropertyName = "REGON";
            this.rEGONDataGridViewTextBoxColumn.HeaderText = "REGON";
            this.rEGONDataGridViewTextBoxColumn.Name = "rEGONDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // ulicanrDataGridViewTextBoxColumn
            // 
            this.ulicanrDataGridViewTextBoxColumn.DataPropertyName = "Ulica_nr";
            this.ulicanrDataGridViewTextBoxColumn.HeaderText = "Ulica_nr";
            this.ulicanrDataGridViewTextBoxColumn.Name = "ulicanrDataGridViewTextBoxColumn";
            // 
            // powiatDataGridViewTextBoxColumn
            // 
            this.powiatDataGridViewTextBoxColumn.DataPropertyName = "Powiat";
            this.powiatDataGridViewTextBoxColumn.HeaderText = "Powiat";
            this.powiatDataGridViewTextBoxColumn.Name = "powiatDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // polisa1DataGridViewTextBoxColumn
            // 
            this.polisa1DataGridViewTextBoxColumn.DataPropertyName = "Polisa1";
            this.polisa1DataGridViewTextBoxColumn.HeaderText = "Polisa1";
            this.polisa1DataGridViewTextBoxColumn.Name = "polisa1DataGridViewTextBoxColumn";
            // 
            // polisa2DataGridViewTextBoxColumn
            // 
            this.polisa2DataGridViewTextBoxColumn.DataPropertyName = "Polisa2";
            this.polisa2DataGridViewTextBoxColumn.HeaderText = "Polisa2";
            this.polisa2DataGridViewTextBoxColumn.Name = "polisa2DataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // przychodyDataGridViewTextBoxColumn
            // 
            this.przychodyDataGridViewTextBoxColumn.DataPropertyName = "Przychody";
            this.przychodyDataGridViewTextBoxColumn.HeaderText = "Przychody";
            this.przychodyDataGridViewTextBoxColumn.Name = "przychodyDataGridViewTextBoxColumn";
            // 
            // eBIDTADataGridViewTextBoxColumn
            // 
            this.eBIDTADataGridViewTextBoxColumn.DataPropertyName = "EBIDTA";
            this.eBIDTADataGridViewTextBoxColumn.HeaderText = "EBIDTA";
            this.eBIDTADataGridViewTextBoxColumn.Name = "eBIDTADataGridViewTextBoxColumn";
            // 
            // nDEEBIDTADataGridViewTextBoxColumn
            // 
            this.nDEEBIDTADataGridViewTextBoxColumn.DataPropertyName = "NDE_EBIDTA";
            this.nDEEBIDTADataGridViewTextBoxColumn.HeaderText = "NDE_EBIDTA";
            this.nDEEBIDTADataGridViewTextBoxColumn.Name = "nDEEBIDTADataGridViewTextBoxColumn";
            // 
            // dSCRDataGridViewTextBoxColumn
            // 
            this.dSCRDataGridViewTextBoxColumn.DataPropertyName = "DSCR";
            this.dSCRDataGridViewTextBoxColumn.HeaderText = "DSCR";
            this.dSCRDataGridViewTextBoxColumn.Name = "dSCRDataGridViewTextBoxColumn";
            // 
            // marża1DataGridViewTextBoxColumn
            // 
            this.marża1DataGridViewTextBoxColumn.DataPropertyName = "Marża1";
            this.marża1DataGridViewTextBoxColumn.HeaderText = "Marża1";
            this.marża1DataGridViewTextBoxColumn.Name = "marża1DataGridViewTextBoxColumn";
            // 
            // marża2DataGridViewTextBoxColumn
            // 
            this.marża2DataGridViewTextBoxColumn.DataPropertyName = "Marża2";
            this.marża2DataGridViewTextBoxColumn.HeaderText = "Marża2";
            this.marża2DataGridViewTextBoxColumn.Name = "marża2DataGridViewTextBoxColumn";
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataSource = typeof(Projekt.Firma);
            // 
            // Wyswietl_dane
            // 
            this.Wyswietl_dane.BackColor = System.Drawing.Color.Transparent;
            this.Wyswietl_dane.FlatAppearance.BorderSize = 0;
            this.Wyswietl_dane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wyswietl_dane.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyswietl_dane.ForeColor = System.Drawing.Color.White;
            this.Wyswietl_dane.Location = new System.Drawing.Point(2, 2);
            this.Wyswietl_dane.Name = "Wyswietl_dane";
            this.Wyswietl_dane.Size = new System.Drawing.Size(205, 54);
            this.Wyswietl_dane.TabIndex = 3;
            this.Wyswietl_dane.Text = "Wyświetl wszystkie dane";
            this.Wyswietl_dane.UseVisualStyleBackColor = false;
            this.Wyswietl_dane.Click += new System.EventHandler(this.Wyswietl_dane_Click);
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.BackColor = System.Drawing.Color.White;
            this.Wyszukaj.Location = new System.Drawing.Point(22, 62);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(162, 20);
            this.Wyszukaj.TabIndex = 10;
            // 
            // po_nazwie_firmy
            // 
            this.po_nazwie_firmy.BackColor = System.Drawing.Color.Transparent;
            this.po_nazwie_firmy.FlatAppearance.BorderSize = 0;
            this.po_nazwie_firmy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_nazwie_firmy.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_nazwie_firmy.ForeColor = System.Drawing.Color.White;
            this.po_nazwie_firmy.Location = new System.Drawing.Point(0, 148);
            this.po_nazwie_firmy.Name = "po_nazwie_firmy";
            this.po_nazwie_firmy.Size = new System.Drawing.Size(205, 54);
            this.po_nazwie_firmy.TabIndex = 11;
            this.po_nazwie_firmy.Text = "wyszukaj po nazwie firmy:";
            this.po_nazwie_firmy.UseVisualStyleBackColor = false;
            this.po_nazwie_firmy.Click += new System.EventHandler(this.po_nazwie_firmy_Click);
            // 
            // po_REGON
            // 
            this.po_REGON.BackColor = System.Drawing.Color.Transparent;
            this.po_REGON.FlatAppearance.BorderSize = 0;
            this.po_REGON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_REGON.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_REGON.ForeColor = System.Drawing.Color.White;
            this.po_REGON.Location = new System.Drawing.Point(3, 208);
            this.po_REGON.Name = "po_REGON";
            this.po_REGON.Size = new System.Drawing.Size(205, 54);
            this.po_REGON.TabIndex = 12;
            this.po_REGON.Text = "wyszukaj po Regon:";
            this.po_REGON.UseVisualStyleBackColor = false;
            this.po_REGON.Click += new System.EventHandler(this.po_REGON_Click);
            // 
            // po_nazwisku
            // 
            this.po_nazwisku.BackColor = System.Drawing.Color.Transparent;
            this.po_nazwisku.FlatAppearance.BorderSize = 0;
            this.po_nazwisku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_nazwisku.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_nazwisku.ForeColor = System.Drawing.Color.White;
            this.po_nazwisku.Location = new System.Drawing.Point(3, 268);
            this.po_nazwisku.Name = "po_nazwisku";
            this.po_nazwisku.Size = new System.Drawing.Size(205, 54);
            this.po_nazwisku.TabIndex = 13;
            this.po_nazwisku.Text = "wyszukaj po nazwisku:";
            this.po_nazwisku.UseVisualStyleBackColor = false;
            this.po_nazwisku.Click += new System.EventHandler(this.po_nazwisku_Click);
            // 
            // po_miescie
            // 
            this.po_miescie.BackColor = System.Drawing.Color.Transparent;
            this.po_miescie.FlatAppearance.BorderSize = 0;
            this.po_miescie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_miescie.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_miescie.ForeColor = System.Drawing.Color.White;
            this.po_miescie.Location = new System.Drawing.Point(0, 328);
            this.po_miescie.Name = "po_miescie";
            this.po_miescie.Size = new System.Drawing.Size(205, 54);
            this.po_miescie.TabIndex = 14;
            this.po_miescie.Text = "wyszukaj po  Mieście:";
            this.po_miescie.UseVisualStyleBackColor = false;
            this.po_miescie.Click += new System.EventHandler(this.po_miescie_Click);
            // 
            // po_powiecie
            // 
            this.po_powiecie.BackColor = System.Drawing.Color.Transparent;
            this.po_powiecie.FlatAppearance.BorderSize = 0;
            this.po_powiecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_powiecie.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_powiecie.ForeColor = System.Drawing.Color.White;
            this.po_powiecie.Location = new System.Drawing.Point(3, 388);
            this.po_powiecie.Name = "po_powiecie";
            this.po_powiecie.Size = new System.Drawing.Size(205, 54);
            this.po_powiecie.TabIndex = 15;
            this.po_powiecie.Text = "wyszukaj po Powiecie:";
            this.po_powiecie.UseVisualStyleBackColor = false;
            this.po_powiecie.Click += new System.EventHandler(this.po_powiecie_Click);
            // 
            // po_data1_mniejsze
            // 
            this.po_data1_mniejsze.BackColor = System.Drawing.Color.Transparent;
            this.po_data1_mniejsze.FlatAppearance.BorderSize = 0;
            this.po_data1_mniejsze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_data1_mniejsze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_data1_mniejsze.ForeColor = System.Drawing.Color.White;
            this.po_data1_mniejsze.Location = new System.Drawing.Point(-4, 508);
            this.po_data1_mniejsze.Name = "po_data1_mniejsze";
            this.po_data1_mniejsze.Size = new System.Drawing.Size(205, 54);
            this.po_data1_mniejsze.TabIndex = 16;
            this.po_data1_mniejsze.Text = "mniejsze od Data1:";
            this.po_data1_mniejsze.UseVisualStyleBackColor = false;
            this.po_data1_mniejsze.Click += new System.EventHandler(this.po_data1_mniejsze_Click);
            // 
            // po_data2_mniejsze
            // 
            this.po_data2_mniejsze.BackColor = System.Drawing.Color.Transparent;
            this.po_data2_mniejsze.FlatAppearance.BorderSize = 0;
            this.po_data2_mniejsze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_data2_mniejsze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_data2_mniejsze.ForeColor = System.Drawing.Color.White;
            this.po_data2_mniejsze.Location = new System.Drawing.Point(3, 688);
            this.po_data2_mniejsze.Name = "po_data2_mniejsze";
            this.po_data2_mniejsze.Size = new System.Drawing.Size(205, 54);
            this.po_data2_mniejsze.TabIndex = 17;
            this.po_data2_mniejsze.Text = "mniejsze od Data2:";
            this.po_data2_mniejsze.UseVisualStyleBackColor = false;
            this.po_data2_mniejsze.Click += new System.EventHandler(this.po_data2_Click);
            // 
            // po_data1_wieksze
            // 
            this.po_data1_wieksze.BackColor = System.Drawing.Color.Transparent;
            this.po_data1_wieksze.FlatAppearance.BorderSize = 0;
            this.po_data1_wieksze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_data1_wieksze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_data1_wieksze.ForeColor = System.Drawing.Color.White;
            this.po_data1_wieksze.Location = new System.Drawing.Point(-1, 448);
            this.po_data1_wieksze.Name = "po_data1_wieksze";
            this.po_data1_wieksze.Size = new System.Drawing.Size(205, 54);
            this.po_data1_wieksze.TabIndex = 18;
            this.po_data1_wieksze.Text = "większe od Data1:";
            this.po_data1_wieksze.UseVisualStyleBackColor = false;
            this.po_data1_wieksze.Click += new System.EventHandler(this.po_data1_wieksze_Click);
            // 
            // po_data2_wieksze
            // 
            this.po_data2_wieksze.BackColor = System.Drawing.Color.Transparent;
            this.po_data2_wieksze.FlatAppearance.BorderSize = 0;
            this.po_data2_wieksze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_data2_wieksze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_data2_wieksze.ForeColor = System.Drawing.Color.White;
            this.po_data2_wieksze.Location = new System.Drawing.Point(-1, 755);
            this.po_data2_wieksze.Name = "po_data2_wieksze";
            this.po_data2_wieksze.Size = new System.Drawing.Size(205, 54);
            this.po_data2_wieksze.TabIndex = 19;
            this.po_data2_wieksze.Text = "większe od Data2:";
            this.po_data2_wieksze.UseVisualStyleBackColor = false;
            this.po_data2_wieksze.Click += new System.EventHandler(this.po_data2_wieksze_Click);
            // 
            // po_przychody_mniejsze
            // 
            this.po_przychody_mniejsze.BackColor = System.Drawing.Color.Transparent;
            this.po_przychody_mniejsze.FlatAppearance.BorderSize = 0;
            this.po_przychody_mniejsze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_przychody_mniejsze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_przychody_mniejsze.ForeColor = System.Drawing.Color.White;
            this.po_przychody_mniejsze.Location = new System.Drawing.Point(2, 815);
            this.po_przychody_mniejsze.Name = "po_przychody_mniejsze";
            this.po_przychody_mniejsze.Size = new System.Drawing.Size(205, 54);
            this.po_przychody_mniejsze.TabIndex = 20;
            this.po_przychody_mniejsze.Text = "Przychody mniejsze od:";
            this.po_przychody_mniejsze.UseVisualStyleBackColor = false;
            this.po_przychody_mniejsze.Click += new System.EventHandler(this.po_przychody_mniejsze_Click);
            // 
            // po_przychody_wieksze
            // 
            this.po_przychody_wieksze.BackColor = System.Drawing.Color.Transparent;
            this.po_przychody_wieksze.FlatAppearance.BorderSize = 0;
            this.po_przychody_wieksze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_przychody_wieksze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_przychody_wieksze.ForeColor = System.Drawing.Color.White;
            this.po_przychody_wieksze.Location = new System.Drawing.Point(2, 875);
            this.po_przychody_wieksze.Name = "po_przychody_wieksze";
            this.po_przychody_wieksze.Size = new System.Drawing.Size(205, 54);
            this.po_przychody_wieksze.TabIndex = 21;
            this.po_przychody_wieksze.Text = "Przychody większe od:";
            this.po_przychody_wieksze.UseVisualStyleBackColor = false;
            this.po_przychody_wieksze.Click += new System.EventHandler(this.po_przychody_wieksze_Click);
            // 
            // po_EBIDTA_wieksze
            // 
            this.po_EBIDTA_wieksze.BackColor = System.Drawing.Color.Transparent;
            this.po_EBIDTA_wieksze.FlatAppearance.BorderSize = 0;
            this.po_EBIDTA_wieksze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_EBIDTA_wieksze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_EBIDTA_wieksze.ForeColor = System.Drawing.Color.White;
            this.po_EBIDTA_wieksze.Location = new System.Drawing.Point(-1, 628);
            this.po_EBIDTA_wieksze.Name = "po_EBIDTA_wieksze";
            this.po_EBIDTA_wieksze.Size = new System.Drawing.Size(205, 54);
            this.po_EBIDTA_wieksze.TabIndex = 22;
            this.po_EBIDTA_wieksze.Text = "EBIDTA większe od:";
            this.po_EBIDTA_wieksze.UseVisualStyleBackColor = false;
            this.po_EBIDTA_wieksze.Click += new System.EventHandler(this.po_EBIDTA_wieksze_Click);
            // 
            // po_EBIDTA_mniejsze
            // 
            this.po_EBIDTA_mniejsze.BackColor = System.Drawing.Color.Transparent;
            this.po_EBIDTA_mniejsze.FlatAppearance.BorderSize = 0;
            this.po_EBIDTA_mniejsze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.po_EBIDTA_mniejsze.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.po_EBIDTA_mniejsze.ForeColor = System.Drawing.Color.White;
            this.po_EBIDTA_mniejsze.Location = new System.Drawing.Point(0, 568);
            this.po_EBIDTA_mniejsze.Name = "po_EBIDTA_mniejsze";
            this.po_EBIDTA_mniejsze.Size = new System.Drawing.Size(205, 54);
            this.po_EBIDTA_mniejsze.TabIndex = 23;
            this.po_EBIDTA_mniejsze.Text = "EBIDTA Mniejsze od:";
            this.po_EBIDTA_mniejsze.UseVisualStyleBackColor = false;
            this.po_EBIDTA_mniejsze.Click += new System.EventHandler(this.po_EBIDTA_mniejsze_Click);
            // 
            // dodaj_firme
            // 
            this.dodaj_firme.BackColor = System.Drawing.Color.Transparent;
            this.dodaj_firme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodaj_firme.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.dodaj_firme.ForeColor = System.Drawing.Color.White;
            this.dodaj_firme.Location = new System.Drawing.Point(9, 88);
            this.dodaj_firme.Name = "dodaj_firme";
            this.dodaj_firme.Size = new System.Drawing.Size(192, 54);
            this.dodaj_firme.TabIndex = 24;
            this.dodaj_firme.Text = "Dodaj firme:";
            this.dodaj_firme.UseVisualStyleBackColor = false;
            this.dodaj_firme.Click += new System.EventHandler(this.dodaj_firme_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.BackColor = System.Drawing.Color.Transparent;
            this.Zapisz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Zapisz.FlatAppearance.BorderSize = 3;
            this.Zapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zapisz.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Zapisz.ForeColor = System.Drawing.Color.Black;
            this.Zapisz.Location = new System.Drawing.Point(163, 0);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(166, 58);
            this.Zapisz.TabIndex = 26;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = false;
            this.Zapisz.Visible = false;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Usun
            // 
            this.Usun.BackColor = System.Drawing.Color.Transparent;
            this.Usun.FlatAppearance.BorderSize = 0;
            this.Usun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usun.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Usun.ForeColor = System.Drawing.Color.Black;
            this.Usun.Location = new System.Drawing.Point(481, 1);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(183, 57);
            this.Usun.TabIndex = 27;
            this.Usun.Text = "Usuń zaznaczony element";
            this.Usun.UseVisualStyleBackColor = false;
            this.Usun.Click += new System.EventHandler(this.Usun_Click_1);
            // 
            // Usunieto_element
            // 
            this.Usunieto_element.AutoSize = true;
            this.Usunieto_element.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Usunieto_element.Location = new System.Drawing.Point(670, 19);
            this.Usunieto_element.Name = "Usunieto_element";
            this.Usunieto_element.Size = new System.Drawing.Size(197, 20);
            this.Usunieto_element.TabIndex = 28;
            this.Usunieto_element.Text = "usunięto element o indeksie:";
            this.Usunieto_element.Visible = false;
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.SystemColors.Desktop;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin1;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold);
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(206, 54);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Cambria", 20F);
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            series1.LabelForeColor = System.Drawing.SystemColors.Window;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 0;
            series1.Name = "Przychody";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1640, 878);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // pokaz_wykres
            // 
            this.pokaz_wykres.AutoSize = true;
            this.pokaz_wykres.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.pokaz_wykres.Location = new System.Drawing.Point(1345, 2);
            this.pokaz_wykres.Name = "pokaz_wykres";
            this.pokaz_wykres.Size = new System.Drawing.Size(189, 24);
            this.pokaz_wykres.TabIndex = 31;
            this.pokaz_wykres.TabStop = true;
            this.pokaz_wykres.Text = "Pokaz wykres (Przychody)";
            this.pokaz_wykres.UseVisualStyleBackColor = true;
            this.pokaz_wykres.CheckedChanged += new System.EventHandler(this.pokaz_wykres_CheckedChanged);
            // 
            // ukryj_wykres
            // 
            this.ukryj_wykres.AutoSize = true;
            this.ukryj_wykres.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.ukryj_wykres.Location = new System.Drawing.Point(1345, 29);
            this.ukryj_wykres.Name = "ukryj_wykres";
            this.ukryj_wykres.Size = new System.Drawing.Size(106, 24);
            this.ukryj_wykres.TabIndex = 32;
            this.ukryj_wykres.TabStop = true;
            this.ukryj_wykres.Text = "ukryj wykres";
            this.ukryj_wykres.UseVisualStyleBackColor = true;
            this.ukryj_wykres.CheckedChanged += new System.EventHandler(this.ukryj_wykres_CheckedChanged);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.SidePanel.Controls.Add(this.panel3);
            this.SidePanel.Controls.Add(this.Wyszukaj);
            this.SidePanel.Controls.Add(this.Wyswietl_dane);
            this.SidePanel.Controls.Add(this.po_nazwie_firmy);
            this.SidePanel.Controls.Add(this.po_REGON);
            this.SidePanel.Controls.Add(this.po_nazwisku);
            this.SidePanel.Controls.Add(this.po_miescie);
            this.SidePanel.Controls.Add(this.po_powiecie);
            this.SidePanel.Controls.Add(this.po_data1_mniejsze);
            this.SidePanel.Controls.Add(this.po_EBIDTA_wieksze);
            this.SidePanel.Controls.Add(this.dodaj_firme);
            this.SidePanel.Controls.Add(this.po_EBIDTA_mniejsze);
            this.SidePanel.Controls.Add(this.po_data1_wieksze);
            this.SidePanel.Controls.Add(this.po_przychody_wieksze);
            this.SidePanel.Controls.Add(this.po_data2_mniejsze);
            this.SidePanel.Controls.Add(this.po_przychody_mniejsze);
            this.SidePanel.Controls.Add(this.po_data2_wieksze);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(207, 932);
            this.SidePanel.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.panel3.Location = new System.Drawing.Point(2, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 54);
            this.panel3.TabIndex = 35;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.Drukuj);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Liczba_firm);
            this.panel2.Controls.Add(this.zamknij);
            this.panel2.Controls.Add(this.wykres);
            this.panel2.Controls.Add(this.Zapisz);
            this.panel2.Controls.Add(this.Usun);
            this.panel2.Controls.Add(this.ukryj_wykres);
            this.panel2.Controls.Add(this.Usunieto_element);
            this.panel2.Controls.Add(this.pokaz_wykres);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1639, 58);
            this.panel2.TabIndex = 34;
            // 
            // Drukuj
            // 
            this.Drukuj.BackColor = System.Drawing.Color.Transparent;
            this.Drukuj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Drukuj.FlatAppearance.BorderSize = 3;
            this.Drukuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drukuj.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Drukuj.ForeColor = System.Drawing.Color.Black;
            this.Drukuj.Location = new System.Drawing.Point(-1, 0);
            this.Drukuj.Name = "Drukuj";
            this.Drukuj.Size = new System.Drawing.Size(166, 58);
            this.Drukuj.TabIndex = 37;
            this.Drukuj.Text = "Drukuj";
            this.Drukuj.UseVisualStyleBackColor = false;
            this.Drukuj.Click += new System.EventHandler(this.Drukuj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.label3.Location = new System.Drawing.Point(1103, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "format daty: dd/mm/yyyy ";
            // 
            // Liczba_firm
            // 
            this.Liczba_firm.AutoSize = true;
            this.Liczba_firm.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Liczba_firm.Location = new System.Drawing.Point(1172, 9);
            this.Liczba_firm.Name = "Liczba_firm";
            this.Liczba_firm.Size = new System.Drawing.Size(80, 20);
            this.Liczba_firm.TabIndex = 35;
            this.Liczba_firm.Text = "liczba firm:";
            // 
            // zamknij
            // 
            this.zamknij.BackColor = System.Drawing.Color.Transparent;
            this.zamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknij.FlatAppearance.BorderSize = 0;
            this.zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknij.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknij.ForeColor = System.Drawing.Color.White;
            this.zamknij.Image = global::Projekt.Properties.Resources.shutdown_icon_18_48;
            this.zamknij.Location = new System.Drawing.Point(1561, 3);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(66, 52);
            this.zamknij.TabIndex = 25;
            this.zamknij.UseVisualStyleBackColor = false;
            this.zamknij.Click += new System.EventHandler(this.button18_Click_1);
            // 
            // wykres
            // 
            this.wykres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wykres.Location = new System.Drawing.Point(0, 59);
            this.wykres.Name = "wykres";
            this.wykres.Size = new System.Drawing.Size(1639, 732);
            this.wykres.TabIndex = 35;
            this.wykres.Visible = false;
            // 
            // firmaBindingSource1
            // 
            this.firmaBindingSource1.DataSource = typeof(Projekt.Firma);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1846, 932);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pekao";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private System.Windows.Forms.Button Wyswietl_dane;
        private System.Windows.Forms.BindingSource firmaBindingSource1;
        private System.Windows.Forms.TextBox Wyszukaj;
        private System.Windows.Forms.Button po_nazwie_firmy;
        private System.Windows.Forms.Button po_REGON;
        private System.Windows.Forms.Button po_nazwisku;
        private System.Windows.Forms.Button po_miescie;
        private System.Windows.Forms.Button po_powiecie;
        private System.Windows.Forms.Button po_data1_mniejsze;
        private System.Windows.Forms.Button po_data2_mniejsze;
        private System.Windows.Forms.Button po_data1_wieksze;
        private System.Windows.Forms.Button po_data2_wieksze;
        private System.Windows.Forms.Button po_przychody_mniejsze;
        private System.Windows.Forms.Button po_przychody_wieksze;
        private System.Windows.Forms.Button po_EBIDTA_wieksze;
        private System.Windows.Forms.Button po_EBIDTA_mniejsze;
        private System.Windows.Forms.Button dodaj_firme;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Label Usunieto_element;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton pokaz_wykres;
        private System.Windows.Forms.RadioButton ukryj_wykres;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel wykres;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Liczba_firm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Drukuj;
        private System.Windows.Forms.DataGridViewTextBoxColumn lPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwafirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicanrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powiatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polisa1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polisa2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przychodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBIDTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDEEBIDTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSCRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkt1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marża1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prowizja1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkt2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marża2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prowizja2DataGridViewTextBoxColumn;
    }
}

