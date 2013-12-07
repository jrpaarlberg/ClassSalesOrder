Partial Class SOitems
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SOitems))
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim NavigateToUrlAction1 As Telerik.Reporting.NavigateToUrlAction = New Telerik.Reporting.NavigateToUrlAction()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.sales_ord_idCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.ordered_qtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.shipped_qtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_idCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_descCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.item_priceCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.requested_del_dtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_ord_idGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.sales_ord_idGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.ordered_qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.shipped_qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_idDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_descDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_priceDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_ord_idCaptionTextBox, Me.ordered_qtyCaptionTextBox, Me.shipped_qtyCaptionTextBox, Me.item_idCaptionTextBox, Me.item_descCaptionTextBox, Me.item_priceCaptionTextBox, Me.requested_del_dtCaptionTextBox, Me.TextBox1})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'sales_ord_idCaptionTextBox
        '
        Me.sales_ord_idCaptionTextBox.CanGrow = True
        Me.sales_ord_idCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8011907339096069R), Telerik.Reporting.Drawing.Unit.Inch(0.30011811852455139R))
        Me.sales_ord_idCaptionTextBox.Name = "sales_ord_idCaptionTextBox"
        Me.sales_ord_idCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_ord_idCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.sales_ord_idCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.sales_ord_idCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_ord_idCaptionTextBox.StyleName = "Caption"
        Me.sales_ord_idCaptionTextBox.Value = "B.O."
        '
        'ordered_qtyCaptionTextBox
        '
        Me.ordered_qtyCaptionTextBox.CanGrow = True
        Me.ordered_qtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.003414154052734375R), Telerik.Reporting.Drawing.Unit.Inch(0.30011811852455139R))
        Me.ordered_qtyCaptionTextBox.Name = "ordered_qtyCaptionTextBox"
        Me.ordered_qtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.ordered_qtyCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ordered_qtyCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.ordered_qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.ordered_qtyCaptionTextBox.StyleName = "Caption"
        Me.ordered_qtyCaptionTextBox.Value = "Required"
        '
        'shipped_qtyCaptionTextBox
        '
        Me.shipped_qtyCaptionTextBox.CanGrow = True
        Me.shipped_qtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90230244398117065R), Telerik.Reporting.Drawing.Unit.Inch(0.30011811852455139R))
        Me.shipped_qtyCaptionTextBox.Name = "shipped_qtyCaptionTextBox"
        Me.shipped_qtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.shipped_qtyCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.shipped_qtyCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.shipped_qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.shipped_qtyCaptionTextBox.StyleName = "Caption"
        Me.shipped_qtyCaptionTextBox.Value = "Shipped"
        '
        'item_idCaptionTextBox
        '
        Me.item_idCaptionTextBox.CanGrow = True
        Me.item_idCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7050817012786865R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_idCaptionTextBox.Name = "item_idCaptionTextBox"
        Me.item_idCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934R))
        Me.item_idCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.item_idCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.item_idCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_idCaptionTextBox.StyleName = "Caption"
        Me.item_idCaptionTextBox.Value = "Item Number"
        '
        'item_descCaptionTextBox
        '
        Me.item_descCaptionTextBox.CanGrow = True
        Me.item_descCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6039698123931885R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_descCaptionTextBox.Name = "item_descCaptionTextBox"
        Me.item_descCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3005161285400391R), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934R))
        Me.item_descCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.item_descCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.item_descCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_descCaptionTextBox.StyleName = "Caption"
        Me.item_descCaptionTextBox.Value = "Description"
        '
        'item_priceCaptionTextBox
        '
        Me.item_priceCaptionTextBox.CanGrow = True
        Me.item_priceCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9045653343200684R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_priceCaptionTextBox.Name = "item_priceCaptionTextBox"
        Me.item_priceCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934R))
        Me.item_priceCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.item_priceCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.item_priceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.item_priceCaptionTextBox.StyleName = "Caption"
        Me.item_priceCaptionTextBox.Value = "Unit Price"
        '
        'requested_del_dtCaptionTextBox
        '
        Me.requested_del_dtCaptionTextBox.CanGrow = True
        Me.requested_del_dtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.8242077827453613R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.requested_del_dtCaptionTextBox.Name = "requested_del_dtCaptionTextBox"
        Me.requested_del_dtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934R))
        Me.requested_del_dtCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.requested_del_dtCaptionTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.requested_del_dtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.requested_del_dtCaptionTextBox.StyleName = "Caption"
        Me.requested_del_dtCaptionTextBox.Value = "Amount"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.003414154052734375R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6965858936309814R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "Quantity"
        '
        'sales_ord_idGroupFooterSection
        '
        Me.sales_ord_idGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197R)
        Me.sales_ord_idGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.TextBox7})
        Me.sales_ord_idGroupFooterSection.Name = "sales_ord_idGroupFooterSection"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5R), Telerik.Reporting.Drawing.Unit.Inch(0.10000006109476089R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.18121051788330078R))
        Me.TextBox6.Value = "Total Order:"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0R), Telerik.Reporting.Drawing.Unit.Inch(0.081210613250732422R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=Sum(fields.ExtPrice)"
        '
        'sales_ord_idGroupHeaderSection
        '
        Me.sales_ord_idGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.058333318680524826R)
        Me.sales_ord_idGroupHeaderSection.Name = "sales_ord_idGroupHeaderSection"
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "Data Source=TR-SQL;WSID=TR-SQL;UID=Converge;PWD=volters;Database=converge;Initial" & _
    " Catalog=Converge;Integrated Security=False"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Parameters.dOpenFlag.Value", Telerik.Reporting.FilterOperator.Equal, "= (status_cd IN Str_to_Array(""OH,IC,CL,CA,SC,CP""))"))
        FormattingRule1.Style.Visible = False
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.74166679382324219R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.ordered_qtyDataTextBox, Me.shipped_qtyDataTextBox, Me.item_idDataTextBox, Me.item_descDataTextBox, Me.item_priceDataTextBox, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox8})
        Me.detail.Name = "detail"
        '
        'ordered_qtyDataTextBox
        '
        Me.ordered_qtyDataTextBox.Action = Nothing
        Me.ordered_qtyDataTextBox.CanGrow = True
        Me.ordered_qtyDataTextBox.Format = "{0:N0}"
        Me.ordered_qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.ordered_qtyDataTextBox.Name = "ordered_qtyDataTextBox"
        Me.ordered_qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90222370624542236R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.ordered_qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.ordered_qtyDataTextBox.StyleName = "Data"
        Me.ordered_qtyDataTextBox.Value = "=Fields.ordered_qty"
        '
        'shipped_qtyDataTextBox
        '
        Me.shipped_qtyDataTextBox.CanGrow = True
        Me.shipped_qtyDataTextBox.Format = "{0:N0}"
        Me.shipped_qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.998849093914032R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.shipped_qtyDataTextBox.Name = "shipped_qtyDataTextBox"
        Me.shipped_qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80226290225982666R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.shipped_qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.shipped_qtyDataTextBox.StyleName = "Data"
        Me.shipped_qtyDataTextBox.Value = "=Fields.shipped_qty"
        '
        'item_idDataTextBox
        '
        NavigateToUrlAction1.Url = "=""http://74.219.111.98/converge/item/item.asp?function_cd=display&item_id=""+Field" & _
    "s.item_id"
        Me.item_idDataTextBox.Action = NavigateToUrlAction1
        Me.item_idDataTextBox.Anchoring = Telerik.Reporting.AnchoringStyles.Top
        Me.item_idDataTextBox.CanGrow = True
        Me.item_idDataTextBox.DocumentMapText = ""
        Me.item_idDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8005163669586182R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.item_idDataTextBox.Name = "item_idDataTextBox"
        Me.item_idDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69948363304138184R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.item_idDataTextBox.Style.Color = System.Drawing.Color.Blue
        Me.item_idDataTextBox.Style.Font.Bold = True
        Me.item_idDataTextBox.Style.Font.Underline = True
        Me.item_idDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.item_idDataTextBox.StyleName = "Data"
        Me.item_idDataTextBox.Value = "= Fields.item_nbr"
        '
        'item_descDataTextBox
        '
        Me.item_descDataTextBox.CanGrow = True
        Me.item_descDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7201578617095947R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.item_descDataTextBox.Name = "item_descDataTextBox"
        Me.item_descDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3005161285400391R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.item_descDataTextBox.StyleName = "Data"
        Me.item_descDataTextBox.Value = "=Fields.item_desc"
        '
        'item_priceDataTextBox
        '
        Me.item_priceDataTextBox.CanGrow = True
        Me.item_priceDataTextBox.Format = "{0:N4}"
        Me.item_priceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.item_priceDataTextBox.Name = "item_priceDataTextBox"
        Me.item_priceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.81956237554550171R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.item_priceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.item_priceDataTextBox.StyleName = "Data"
        Me.item_priceDataTextBox.Value = "=Fields.item_price"
        '
        'TextBox2
        '
        Me.TextBox2.Format = "{0:N0}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9954347610473633R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70456534624099731R), Telerik.Reporting.Drawing.Unit.Inch(0.22083346545696259R))
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Fields.ordered_qty - Fields.Shipped_qty"
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0:d}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7207531929016113R), Telerik.Reporting.Drawing.Unit.Inch(0.24174563586711884R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.320673942565918R), Telerik.Reporting.Drawing.Unit.Inch(0.1999211311340332R))
        Me.TextBox3.Value = "=Fields.requested_del_dt"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7201578617095947R), Telerik.Reporting.Drawing.Unit.Inch(0.44174560904502869R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3005163669586182R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox4.Value = "=Fields.item_tx"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7201578617095947R), Telerik.Reporting.Drawing.Unit.Inch(0.24174563586711884R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0005165338516235R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox5.Value = "Required Date:"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.22083353996276855R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "=Fields.ExtPrice"
        '
        'SOitems
        '
        Me.DataSource = Me.SqlDataSource2
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_ord_id", Telerik.Reporting.FilterOperator.Equal, "=Parameters.DetailSalesOrderID.Value"))
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.sales_ord_idGroupFooterSection
        Group2.GroupHeader = Me.sales_ord_idGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.sales_ord_id"))
        Group2.Name = "sales_ord_idGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.sales_ord_idGroupHeaderSection, Me.sales_ord_idGroupFooterSection, Me.reportFooter, Me.detail})
        Me.Name = "SOitems"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "DetailSalesOrderID"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter2.Name = "dOpenFlag"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.Black
        StyleRule1.Style.Font.Bold = True
        StyleRule1.Style.Font.Italic = False
        StyleRule1.Style.Font.Name = "Tahoma"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule1.Style.Font.Strikeout = False
        StyleRule1.Style.Font.Underline = False
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.11964225769043R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_ord_idCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents ordered_qtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents shipped_qtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_idCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_descCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_priceCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents requested_del_dtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents sales_ord_idGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_ord_idGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents ordered_qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents shipped_qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_idDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_descDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_priceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
End Class