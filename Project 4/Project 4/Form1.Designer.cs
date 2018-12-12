namespace Project_4
{
    partial class CourseDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetails));
            this.lblNoOfCourseTaken = new System.Windows.Forms.Label();
            this.txtCourseTaken = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtCourseTkn = new System.Windows.Forms.TextBox();
            this.lblNoOfCourseTkn = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDte = new System.Windows.Forms.Label();
            this.txtStudentNme = new System.Windows.Forms.TextBox();
            this.lblStudentNme = new System.Windows.Forms.Label();
            this.lblClassTyp = new System.Windows.Forms.Label();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCourseNo = new System.Windows.Forms.Label();
            this.lblClassType = new System.Windows.Forms.Label();
            this.rbHybrid = new System.Windows.Forms.RadioButton();
            this.rbInClass = new System.Windows.Forms.RadioButton();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtClassType = new System.Windows.Forms.TextBox();
            this.database1DataSet = new Project_4.Database1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Project_4.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Project_4.Database1DataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableCBCourseNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoOfCourseTaken
            // 
            this.lblNoOfCourseTaken.AutoSize = true;
            this.lblNoOfCourseTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfCourseTaken.Location = new System.Drawing.Point(68, 96);
            this.lblNoOfCourseTaken.Name = "lblNoOfCourseTaken";
            this.lblNoOfCourseTaken.Size = new System.Drawing.Size(154, 18);
            this.lblNoOfCourseTaken.TabIndex = 0;
            this.lblNoOfCourseTaken.Text = "No. Of &Course Taken:";
            // 
            // txtCourseTaken
            // 
            this.txtCourseTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseTaken.Location = new System.Drawing.Point(250, 91);
            this.txtCourseTaken.Name = "txtCourseTaken";
            this.txtCourseTaken.Size = new System.Drawing.Size(180, 24);
            this.txtCourseTaken.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(250, 153);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(180, 24);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(68, 158);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(106, 18);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student &Name:";
            // 
            // txtCourseTkn
            // 
            this.txtCourseTkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseTkn.Location = new System.Drawing.Point(742, 93);
            this.txtCourseTkn.Name = "txtCourseTkn";
            this.txtCourseTkn.Size = new System.Drawing.Size(165, 24);
            this.txtCourseTkn.TabIndex = 5;
            // 
            // lblNoOfCourseTkn
            // 
            this.lblNoOfCourseTkn.AutoSize = true;
            this.lblNoOfCourseTkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfCourseTkn.Location = new System.Drawing.Point(567, 95);
            this.lblNoOfCourseTkn.Name = "lblNoOfCourseTkn";
            this.lblNoOfCourseTkn.Size = new System.Drawing.Size(154, 18);
            this.lblNoOfCourseTkn.TabIndex = 4;
            this.lblNoOfCourseTkn.Text = "No. Of Course Taken:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(742, 227);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(165, 24);
            this.txtStartDate.TabIndex = 9;
            // 
            // lblStartDte
            // 
            this.lblStartDte.AutoSize = true;
            this.lblStartDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDte.Location = new System.Drawing.Point(566, 229);
            this.lblStartDte.Name = "lblStartDte";
            this.lblStartDte.Size = new System.Drawing.Size(78, 18);
            this.lblStartDte.TabIndex = 8;
            this.lblStartDte.Text = "Start Date:";
            // 
            // txtStudentNme
            // 
            this.txtStudentNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNme.Location = new System.Drawing.Point(742, 152);
            this.txtStudentNme.Name = "txtStudentNme";
            this.txtStudentNme.Size = new System.Drawing.Size(165, 24);
            this.txtStudentNme.TabIndex = 7;
            // 
            // lblStudentNme
            // 
            this.lblStudentNme.AutoSize = true;
            this.lblStudentNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNme.Location = new System.Drawing.Point(566, 154);
            this.lblStudentNme.Name = "lblStudentNme";
            this.lblStudentNme.Size = new System.Drawing.Size(106, 18);
            this.lblStudentNme.TabIndex = 6;
            this.lblStudentNme.Text = "Student Name:";
            // 
            // lblClassTyp
            // 
            this.lblClassTyp.AutoSize = true;
            this.lblClassTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassTyp.Location = new System.Drawing.Point(566, 357);
            this.lblClassTyp.Name = "lblClassTyp";
            this.lblClassTyp.Size = new System.Drawing.Size(86, 18);
            this.lblClassTyp.TabIndex = 12;
            this.lblClassTyp.Text = "Class Type:";
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNo.Location = new System.Drawing.Point(742, 293);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.Size = new System.Drawing.Size(165, 24);
            this.txtCourseNo.TabIndex = 11;
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNumber.Location = new System.Drawing.Point(566, 295);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(85, 18);
            this.lblCourseNumber.TabIndex = 10;
            this.lblCourseNumber.Text = "Course No:";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(162, 467);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(144, 40);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "&SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGet.Location = new System.Drawing.Point(641, 467);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(144, 40);
            this.BtnGet.TabIndex = 15;
            this.BtnGet.Text = "&GET";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(410, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 40);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(68, 225);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 18);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "Start &Date:";
            // 
            // lblCourseNo
            // 
            this.lblCourseNo.AutoSize = true;
            this.lblCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNo.Location = new System.Drawing.Point(68, 295);
            this.lblCourseNo.Name = "lblCourseNo";
            this.lblCourseNo.Size = new System.Drawing.Size(93, 18);
            this.lblCourseNo.TabIndex = 19;
            this.lblCourseNo.Text = "Course &No. :";
            this.lblCourseNo.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassType.Location = new System.Drawing.Point(68, 356);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(86, 18);
            this.lblClassType.TabIndex = 20;
            this.lblClassType.Text = "Class &Type:";
            // 
            // rbHybrid
            // 
            this.rbHybrid.AutoSize = true;
            this.rbHybrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHybrid.Location = new System.Drawing.Point(250, 356);
            this.rbHybrid.Name = "rbHybrid";
            this.rbHybrid.Size = new System.Drawing.Size(71, 22);
            this.rbHybrid.TabIndex = 22;
            this.rbHybrid.TabStop = true;
            this.rbHybrid.Text = "&Hybrid";
            this.rbHybrid.UseVisualStyleBackColor = true;
            // 
            // rbInClass
            // 
            this.rbInClass.AutoSize = true;
            this.rbInClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInClass.Location = new System.Drawing.Point(369, 356);
            this.rbInClass.Name = "rbInClass";
            this.rbInClass.Size = new System.Drawing.Size(83, 22);
            this.rbInClass.TabIndex = 23;
            this.rbInClass.TabStop = true;
            this.rbInClass.Text = "In-Class";
            this.rbInClass.UseVisualStyleBackColor = true;
            this.rbInClass.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.Location = new System.Drawing.Point(248, 229);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(182, 24);
            this.dateTimeStartDate.TabIndex = 26;
            // 
            // txtClassType
            // 
            this.txtClassType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassType.Location = new System.Drawing.Point(742, 356);
            this.txtClassType.Name = "txtClassType";
            this.txtClassType.Size = new System.Drawing.Size(165, 24);
            this.txtClassType.TabIndex = 27;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_4.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(983, 27);
            this.tableBindingNavigator.TabIndex = 28;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.database1DataSet;
            // 
            // tableCBCourseNo
            // 
            this.tableCBCourseNo.DataSource = this.tableBindingSource1;
            this.tableCBCourseNo.DisplayMember = "courseno";
            this.tableCBCourseNo.FormattingEnabled = true;
            this.tableCBCourseNo.Location = new System.Drawing.Point(250, 289);
            this.tableCBCourseNo.Name = "tableCBCourseNo";
            this.tableCBCourseNo.Size = new System.Drawing.Size(180, 24);
            this.tableCBCourseNo.TabIndex = 28;
            this.tableCBCourseNo.ValueMember = "courseno";
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 644);
            this.Controls.Add(this.tableCBCourseNo);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.txtClassType);
            this.Controls.Add(this.dateTimeStartDate);
            this.Controls.Add(this.rbInClass);
            this.Controls.Add(this.rbHybrid);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.lblCourseNo);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblClassTyp);
            this.Controls.Add(this.txtCourseNo);
            this.Controls.Add(this.lblCourseNumber);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDte);
            this.Controls.Add(this.txtStudentNme);
            this.Controls.Add(this.lblStudentNme);
            this.Controls.Add(this.txtCourseTkn);
            this.Controls.Add(this.lblNoOfCourseTkn);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtCourseTaken);
            this.Controls.Add(this.lblNoOfCourseTaken);
            this.Name = "CourseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoOfCourseTaken;
        private System.Windows.Forms.TextBox txtCourseTaken;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtCourseTkn;
        private System.Windows.Forms.Label lblNoOfCourseTkn;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDte;
        private System.Windows.Forms.TextBox txtStudentNme;
        private System.Windows.Forms.Label lblStudentNme;
        private System.Windows.Forms.Label lblClassTyp;
        private System.Windows.Forms.TextBox txtCourseNo;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.RadioButton rbHybrid;
        private System.Windows.Forms.RadioButton rbInClass;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        private System.Windows.Forms.TextBox txtClassType;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.ComboBox tableCBCourseNo;
    }
}

