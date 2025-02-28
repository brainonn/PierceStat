﻿using System;
using System.Windows.Forms;

namespace PierceStat
{
    partial class Form_MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell2 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.comboBox_ComPortsList = new System.Windows.Forms.ComboBox();
            this.label_COM = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCOMPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ConnectCOM = new System.Windows.Forms.Button();
            this.richTextBox_Messages = new System.Windows.Forms.RichTextBox();
            this.groupBox_PierceStat = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown_U_HeaterSet = new System.Windows.Forms.NumericUpDown();
            this.checkBox_U_HeaterEnable = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Channel2 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDown_ISet2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Polarity2 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox_Temp2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointTemp2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_PTemp2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DTemp2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ITemp2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Freq2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointFreq2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_DFreq2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PFreq2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IFreq2 = new System.Windows.Forms.NumericUpDown();
            this.button_EnableCh2 = new System.Windows.Forms.Button();
            this.comboBox_Source2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_Mode2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_Load2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox_Channel1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_ISet1 = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.checkBox_Polarity1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox_Temp1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointTemp1 = new System.Windows.Forms.NumericUpDown();
            this.label_SetPointTemp = new System.Windows.Forms.Label();
            this.label_PTemp1 = new System.Windows.Forms.Label();
            this.label_ITemp1 = new System.Windows.Forms.Label();
            this.label_DTemp1 = new System.Windows.Forms.Label();
            this.numericUpDown_PTemp1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DTemp1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ITemp1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Freq1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_SetPointFreq1 = new System.Windows.Forms.NumericUpDown();
            this.label_SetPointFreq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_DFreq1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PFreq1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IFreq1 = new System.Windows.Forms.NumericUpDown();
            this.button_EnableCh1 = new System.Windows.Forms.Button();
            this.comboBox_Source1 = new System.Windows.Forms.ComboBox();
            this.label_Source1 = new System.Windows.Forms.Label();
            this.comboBox_Mode1 = new System.Windows.Forms.ComboBox();
            this.label_Mode1 = new System.Windows.Forms.Label();
            this.comboBox_Load1 = new System.Windows.Forms.ComboBox();
            this.label_Load1 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox_ChannelsMode = new System.Windows.Forms.GroupBox();
            this.radioButton_ModeDependent = new System.Windows.Forms.RadioButton();
            this.radioButton_ModeIndependent = new System.Windows.Forms.RadioButton();
            this.button_SaveFlash = new System.Windows.Forms.Button();
            this.groupBox_Meas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_AlarmFreqMasked = new System.Windows.Forms.CheckBox();
            this.label_CurrentCh1 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp4Masked = new System.Windows.Forms.CheckBox();
            this.pictureBox_AlarmFreq = new System.Windows.Forms.PictureBox();
            this.checkBox_AlarmTemp3Masked = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp2Masked = new System.Windows.Forms.CheckBox();
            this.numericUpDown_FreqMax = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown_FreqMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp4 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_FreqMeas = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_AlarmTemp3 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp2 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmTemp1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_CurrentCh1Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp2Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp3Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp4Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh1Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh2Meas = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AlarmCurrentCh1Masked = new System.Windows.Forms.CheckBox();
            this.checkBox_AlarmU_HeaterMasked = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBox_AlarmU_PowerMasked = new System.Windows.Forms.CheckBox();
            this.label_U_Power = new System.Windows.Forms.Label();
            this.numericUpDown_Temp4Min = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AlarmCurrentCh2Masked = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Temp3Min = new System.Windows.Forms.NumericUpDown();
            this.label_U_Heater = new System.Windows.Forms.Label();
            this.numericUpDown_Temp2Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMeas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMeas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp4Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp3Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CurrentCh2Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp2Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp1Meas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_HeaterMax = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_AlarmCurrentCh1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmCurrentCh2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmU_Power = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox_AlarmU_Heater = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox_AlarmTemp1Masked = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.numericUpDown_FilterBand = new System.Windows.Forms.NumericUpDown();
            this.checkBox_PeakFilter = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDown_FreqMeas2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_PlotDeriv = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotFreq = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.numericUpDown_DerNumber = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.numericUpDown_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBoxKprtCalibration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_freqOffset = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AwaitTime = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.numericUpDown_DeltaF = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_KprtValue = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown_TstartKprt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TstopKprt = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.numericUpDown_NumPointsKprt = new System.Windows.Forms.NumericUpDown();
            this.button_CalibrateKprt = new System.Windows.Forms.Button();
            this.button_ResetPlots = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox_PlotTempFreq = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp4 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp3 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp2 = new System.Windows.Forms.CheckBox();
            this.checkBox_PlotTemp1 = new System.Windows.Forms.CheckBox();
            this.chart_Freq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Temps = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_SaveData = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.Temp1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutDataTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutTableButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ClearTable = new System.Windows.Forms.Button();
            this.button_AddData = new System.Windows.Forms.Button();
            this.button_SaveTable = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_PierceStat.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_Channel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet2)).BeginInit();
            this.groupBox_Temp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp2)).BeginInit();
            this.groupBox_Freq2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq2)).BeginInit();
            this.groupBox_Channel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet1)).BeginInit();
            this.groupBox_Temp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp1)).BeginInit();
            this.groupBox_Freq1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq1)).BeginInit();
            this.groupBox_ChannelsMode.SuspendLayout();
            this.groupBox_Meas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Meas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Heater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilterBand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).BeginInit();
            this.groupBoxKprtCalibration.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AwaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DeltaF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KprtValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstartKprt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstopKprt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPointsKprt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutDataTable.SuspendLayout();
            this.flowLayoutTableButtons.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ComPortsList
            // 
            this.comboBox_ComPortsList.FormattingEnabled = true;
            this.comboBox_ComPortsList.Location = new System.Drawing.Point(37, 2);
            this.comboBox_ComPortsList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ComPortsList.Name = "comboBox_ComPortsList";
            this.comboBox_ComPortsList.Size = new System.Drawing.Size(82, 21);
            this.comboBox_ComPortsList.TabIndex = 0;
            this.comboBox_ComPortsList.SelectedIndexChanged += new System.EventHandler(this.comboBox_ComPortsList_SelectedIndexChanged);
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(2, 0);
            this.label_COM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(31, 13);
            this.label_COM.TabIndex = 1;
            this.label_COM.Text = "COM";
            this.label_COM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_Main.Size = new System.Drawing.Size(1863, 24);
            this.menuStrip_Main.TabIndex = 2;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCOMPortsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updateCOMPortsToolStripMenuItem
            // 
            this.updateCOMPortsToolStripMenuItem.Name = "updateCOMPortsToolStripMenuItem";
            this.updateCOMPortsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateCOMPortsToolStripMenuItem.Text = "Update COM ports";
            this.updateCOMPortsToolStripMenuItem.Click += new System.EventHandler(this.updateCOMPortsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button_ConnectCOM
            // 
            this.button_ConnectCOM.Location = new System.Drawing.Point(123, 2);
            this.button_ConnectCOM.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConnectCOM.Name = "button_ConnectCOM";
            this.button_ConnectCOM.Size = new System.Drawing.Size(83, 25);
            this.button_ConnectCOM.TabIndex = 3;
            this.button_ConnectCOM.Text = "Connect";
            this.button_ConnectCOM.UseVisualStyleBackColor = true;
            this.button_ConnectCOM.Click += new System.EventHandler(this.button_ConnectCOM_Click);
            // 
            // richTextBox_Messages
            // 
            this.richTextBox_Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Messages.Location = new System.Drawing.Point(2, 543);
            this.richTextBox_Messages.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_Messages.Name = "richTextBox_Messages";
            this.richTextBox_Messages.Size = new System.Drawing.Size(668, 239);
            this.richTextBox_Messages.TabIndex = 4;
            this.richTextBox_Messages.Text = "";
            // 
            // groupBox_PierceStat
            // 
            this.groupBox_PierceStat.Controls.Add(this.flowLayoutPanel8);
            this.groupBox_PierceStat.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_PierceStat.Controls.Add(this.label44);
            this.groupBox_PierceStat.Controls.Add(this.label43);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_ChannelsMode);
            this.groupBox_PierceStat.Controls.Add(this.button_SaveFlash);
            this.groupBox_PierceStat.Controls.Add(this.groupBox_Meas);
            this.groupBox_PierceStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PierceStat.Location = new System.Drawing.Point(2, 2);
            this.groupBox_PierceStat.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_PierceStat.Name = "groupBox_PierceStat";
            this.groupBox_PierceStat.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_PierceStat.Size = new System.Drawing.Size(539, 811);
            this.groupBox_PierceStat.TabIndex = 5;
            this.groupBox_PierceStat.TabStop = false;
            this.groupBox_PierceStat.Text = "PierceStat™ ";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label21);
            this.flowLayoutPanel8.Controls.Add(this.numericUpDown_U_HeaterSet);
            this.flowLayoutPanel8.Controls.Add(this.checkBox_U_HeaterEnable);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(8, 67);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(299, 27);
            this.flowLayoutPanel8.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "U_Heater Set, V";
            // 
            // numericUpDown_U_HeaterSet
            // 
            this.numericUpDown_U_HeaterSet.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterSet.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_HeaterSet.Location = new System.Drawing.Point(91, 2);
            this.numericUpDown_U_HeaterSet.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_HeaterSet.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterSet.Name = "numericUpDown_U_HeaterSet";
            this.numericUpDown_U_HeaterSet.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_U_HeaterSet.TabIndex = 33;
            this.numericUpDown_U_HeaterSet.ValueChanged += new System.EventHandler(this.numericUpDown_U_HeaterSet_ValueChanged);
            // 
            // checkBox_U_HeaterEnable
            // 
            this.checkBox_U_HeaterEnable.AutoSize = true;
            this.checkBox_U_HeaterEnable.Location = new System.Drawing.Point(184, 2);
            this.checkBox_U_HeaterEnable.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_U_HeaterEnable.Name = "checkBox_U_HeaterEnable";
            this.checkBox_U_HeaterEnable.Size = new System.Drawing.Size(65, 17);
            this.checkBox_U_HeaterEnable.TabIndex = 2;
            this.checkBox_U_HeaterEnable.Text = "Enabled";
            this.checkBox_U_HeaterEnable.UseVisualStyleBackColor = true;
            this.checkBox_U_HeaterEnable.CheckedChanged += new System.EventHandler(this.checkBox_U_HeaterEnable_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_Channel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_Channel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 106);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 345);
            this.tableLayoutPanel2.TabIndex = 65;
            // 
            // groupBox_Channel2
            // 
            this.groupBox_Channel2.Controls.Add(this.label30);
            this.groupBox_Channel2.Controls.Add(this.numericUpDown_ISet2);
            this.groupBox_Channel2.Controls.Add(this.checkBox_Polarity2);
            this.groupBox_Channel2.Controls.Add(this.label28);
            this.groupBox_Channel2.Controls.Add(this.groupBox_Temp2);
            this.groupBox_Channel2.Controls.Add(this.groupBox_Freq2);
            this.groupBox_Channel2.Controls.Add(this.button_EnableCh2);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Source2);
            this.groupBox_Channel2.Controls.Add(this.label13);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Mode2);
            this.groupBox_Channel2.Controls.Add(this.label14);
            this.groupBox_Channel2.Controls.Add(this.comboBox_Load2);
            this.groupBox_Channel2.Controls.Add(this.label15);
            this.groupBox_Channel2.Location = new System.Drawing.Point(259, 2);
            this.groupBox_Channel2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Channel2.Name = "groupBox_Channel2";
            this.groupBox_Channel2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Channel2.Size = new System.Drawing.Size(245, 341);
            this.groupBox_Channel2.TabIndex = 30;
            this.groupBox_Channel2.TabStop = false;
            this.groupBox_Channel2.Text = "Channel 2";
            this.groupBox_Channel2.Enter += new System.EventHandler(this.groupBox_Channel2_Enter);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 140);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 46;
            this.label30.Text = "I Set, %";
            // 
            // numericUpDown_ISet2
            // 
            this.numericUpDown_ISet2.DecimalPlaces = 2;
            this.numericUpDown_ISet2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ISet2.Location = new System.Drawing.Point(107, 139);
            this.numericUpDown_ISet2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_ISet2.Name = "numericUpDown_ISet2";
            this.numericUpDown_ISet2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_ISet2.TabIndex = 46;
            this.numericUpDown_ISet2.ValueChanged += new System.EventHandler(this.numericUpDown_ISet2_ValueChanged);
            // 
            // checkBox_Polarity2
            // 
            this.checkBox_Polarity2.AutoSize = true;
            this.checkBox_Polarity2.Location = new System.Drawing.Point(107, 116);
            this.checkBox_Polarity2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Polarity2.Name = "checkBox_Polarity2";
            this.checkBox_Polarity2.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Polarity2.TabIndex = 37;
            this.checkBox_Polarity2.Text = "Reversed";
            this.checkBox_Polarity2.UseVisualStyleBackColor = true;
            this.checkBox_Polarity2.CheckedChanged += new System.EventHandler(this.checkBox_Polarity2_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 116);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 33;
            this.label28.Text = "Polarity";
            // 
            // groupBox_Temp2
            // 
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_SetPointTemp2);
            this.groupBox_Temp2.Controls.Add(this.label5);
            this.groupBox_Temp2.Controls.Add(this.label6);
            this.groupBox_Temp2.Controls.Add(this.label7);
            this.groupBox_Temp2.Controls.Add(this.label8);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_PTemp2);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_DTemp2);
            this.groupBox_Temp2.Controls.Add(this.numericUpDown_ITemp2);
            this.groupBox_Temp2.Location = new System.Drawing.Point(15, 166);
            this.groupBox_Temp2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Temp2.Name = "groupBox_Temp2";
            this.groupBox_Temp2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Temp2.Size = new System.Drawing.Size(114, 122);
            this.groupBox_Temp2.TabIndex = 31;
            this.groupBox_Temp2.TabStop = false;
            this.groupBox_Temp2.Text = "Temp Source";
            // 
            // numericUpDown_SetPointTemp2
            // 
            this.numericUpDown_SetPointTemp2.DecimalPlaces = 2;
            this.numericUpDown_SetPointTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_SetPointTemp2.Location = new System.Drawing.Point(12, 36);
            this.numericUpDown_SetPointTemp2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_SetPointTemp2.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_SetPointTemp2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_SetPointTemp2.Name = "numericUpDown_SetPointTemp2";
            this.numericUpDown_SetPointTemp2.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_SetPointTemp2.TabIndex = 11;
            this.numericUpDown_SetPointTemp2.ValueChanged += new System.EventHandler(this.numericUpDown_SetPointTemp2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Temp Setpoint, °C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "D";
            // 
            // numericUpDown_PTemp2
            // 
            this.numericUpDown_PTemp2.DecimalPlaces = 5;
            this.numericUpDown_PTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PTemp2.Location = new System.Drawing.Point(27, 57);
            this.numericUpDown_PTemp2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_PTemp2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_PTemp2.Name = "numericUpDown_PTemp2";
            this.numericUpDown_PTemp2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_PTemp2.TabIndex = 15;
            this.numericUpDown_PTemp2.ValueChanged += new System.EventHandler(this.numericUpDown_PTemp2_ValueChanged);
            // 
            // numericUpDown_DTemp2
            // 
            this.numericUpDown_DTemp2.DecimalPlaces = 5;
            this.numericUpDown_DTemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DTemp2.Location = new System.Drawing.Point(27, 95);
            this.numericUpDown_DTemp2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DTemp2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_DTemp2.Name = "numericUpDown_DTemp2";
            this.numericUpDown_DTemp2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_DTemp2.TabIndex = 17;
            this.numericUpDown_DTemp2.ValueChanged += new System.EventHandler(this.numericUpDown_DTemp2_ValueChanged);
            // 
            // numericUpDown_ITemp2
            // 
            this.numericUpDown_ITemp2.DecimalPlaces = 5;
            this.numericUpDown_ITemp2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ITemp2.Location = new System.Drawing.Point(27, 75);
            this.numericUpDown_ITemp2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_ITemp2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_ITemp2.Name = "numericUpDown_ITemp2";
            this.numericUpDown_ITemp2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ITemp2.TabIndex = 16;
            this.numericUpDown_ITemp2.ValueChanged += new System.EventHandler(this.numericUpDown_ITemp2_ValueChanged);
            // 
            // groupBox_Freq2
            // 
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_SetPointFreq2);
            this.groupBox_Freq2.Controls.Add(this.label9);
            this.groupBox_Freq2.Controls.Add(this.label10);
            this.groupBox_Freq2.Controls.Add(this.label11);
            this.groupBox_Freq2.Controls.Add(this.label12);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_DFreq2);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_PFreq2);
            this.groupBox_Freq2.Controls.Add(this.numericUpDown_IFreq2);
            this.groupBox_Freq2.Location = new System.Drawing.Point(133, 166);
            this.groupBox_Freq2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Freq2.Name = "groupBox_Freq2";
            this.groupBox_Freq2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Freq2.Size = new System.Drawing.Size(102, 122);
            this.groupBox_Freq2.TabIndex = 30;
            this.groupBox_Freq2.TabStop = false;
            this.groupBox_Freq2.Text = "Freq Source";
            // 
            // numericUpDown_SetPointFreq2
            // 
            this.numericUpDown_SetPointFreq2.Location = new System.Drawing.Point(11, 36);
            this.numericUpDown_SetPointFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_SetPointFreq2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq2.Name = "numericUpDown_SetPointFreq2";
            this.numericUpDown_SetPointFreq2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_SetPointFreq2.TabIndex = 19;
            this.numericUpDown_SetPointFreq2.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq2.ValueChanged += new System.EventHandler(this.numericUpDown_SetPointFreq2_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Freq Setpoint, Hz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "P";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "I";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "D";
            // 
            // numericUpDown_DFreq2
            // 
            this.numericUpDown_DFreq2.DecimalPlaces = 5;
            this.numericUpDown_DFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DFreq2.Location = new System.Drawing.Point(26, 95);
            this.numericUpDown_DFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DFreq2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_DFreq2.Name = "numericUpDown_DFreq2";
            this.numericUpDown_DFreq2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_DFreq2.TabIndex = 25;
            this.numericUpDown_DFreq2.ValueChanged += new System.EventHandler(this.numericUpDown_DFreq2_ValueChanged);
            // 
            // numericUpDown_PFreq2
            // 
            this.numericUpDown_PFreq2.DecimalPlaces = 5;
            this.numericUpDown_PFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PFreq2.Location = new System.Drawing.Point(26, 57);
            this.numericUpDown_PFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_PFreq2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_PFreq2.Name = "numericUpDown_PFreq2";
            this.numericUpDown_PFreq2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_PFreq2.TabIndex = 23;
            this.numericUpDown_PFreq2.ValueChanged += new System.EventHandler(this.numericUpDown_PFreq2_ValueChanged);
            // 
            // numericUpDown_IFreq2
            // 
            this.numericUpDown_IFreq2.DecimalPlaces = 5;
            this.numericUpDown_IFreq2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IFreq2.Location = new System.Drawing.Point(26, 75);
            this.numericUpDown_IFreq2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_IFreq2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_IFreq2.Name = "numericUpDown_IFreq2";
            this.numericUpDown_IFreq2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_IFreq2.TabIndex = 24;
            this.numericUpDown_IFreq2.ValueChanged += new System.EventHandler(this.numericUpDown_IFreq2_ValueChanged);
            // 
            // button_EnableCh2
            // 
            this.button_EnableCh2.Location = new System.Drawing.Point(15, 292);
            this.button_EnableCh2.Margin = new System.Windows.Forms.Padding(2);
            this.button_EnableCh2.Name = "button_EnableCh2";
            this.button_EnableCh2.Size = new System.Drawing.Size(220, 42);
            this.button_EnableCh2.TabIndex = 26;
            this.button_EnableCh2.Text = "Enable";
            this.button_EnableCh2.UseVisualStyleBackColor = true;
            this.button_EnableCh2.Click += new System.EventHandler(this.button_EnableCh2_Click);
            // 
            // comboBox_Source2
            // 
            this.comboBox_Source2.FormattingEnabled = true;
            this.comboBox_Source2.Items.AddRange(new object[] {
            "Temp1",
            "Temp2",
            "Temp3",
            "Temp4",
            "Freq"});
            this.comboBox_Source2.Location = new System.Drawing.Point(107, 83);
            this.comboBox_Source2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Source2.Name = "comboBox_Source2";
            this.comboBox_Source2.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Source2.TabIndex = 9;
            this.comboBox_Source2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Source2_SelectedIndexChanged);
            this.comboBox_Source2.EnabledChanged += new System.EventHandler(this.comboBox_Source2_EnabledChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Source";
            // 
            // comboBox_Mode2
            // 
            this.comboBox_Mode2.FormattingEnabled = true;
            this.comboBox_Mode2.Items.AddRange(new object[] {
            "PID",
            "Const current"});
            this.comboBox_Mode2.Location = new System.Drawing.Point(107, 53);
            this.comboBox_Mode2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Mode2.Name = "comboBox_Mode2";
            this.comboBox_Mode2.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Mode2.TabIndex = 7;
            this.comboBox_Mode2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Mode";
            // 
            // comboBox_Load2
            // 
            this.comboBox_Load2.FormattingEnabled = true;
            this.comboBox_Load2.Items.AddRange(new object[] {
            "Resistor",
            "Peltier"});
            this.comboBox_Load2.Location = new System.Drawing.Point(107, 20);
            this.comboBox_Load2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Load2.Name = "comboBox_Load2";
            this.comboBox_Load2.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Load2.TabIndex = 1;
            this.comboBox_Load2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Load2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Load";
            // 
            // groupBox_Channel1
            // 
            this.groupBox_Channel1.Controls.Add(this.numericUpDown_ISet1);
            this.groupBox_Channel1.Controls.Add(this.label29);
            this.groupBox_Channel1.Controls.Add(this.checkBox_Polarity1);
            this.groupBox_Channel1.Controls.Add(this.label27);
            this.groupBox_Channel1.Controls.Add(this.groupBox_Temp1);
            this.groupBox_Channel1.Controls.Add(this.groupBox_Freq1);
            this.groupBox_Channel1.Controls.Add(this.button_EnableCh1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Source1);
            this.groupBox_Channel1.Controls.Add(this.label_Source1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Mode1);
            this.groupBox_Channel1.Controls.Add(this.label_Mode1);
            this.groupBox_Channel1.Controls.Add(this.comboBox_Load1);
            this.groupBox_Channel1.Controls.Add(this.label_Load1);
            this.groupBox_Channel1.Location = new System.Drawing.Point(2, 2);
            this.groupBox_Channel1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Channel1.Name = "groupBox_Channel1";
            this.groupBox_Channel1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Channel1.Size = new System.Drawing.Size(253, 341);
            this.groupBox_Channel1.TabIndex = 5;
            this.groupBox_Channel1.TabStop = false;
            this.groupBox_Channel1.Text = "Channel 1";
            // 
            // numericUpDown_ISet1
            // 
            this.numericUpDown_ISet1.DecimalPlaces = 2;
            this.numericUpDown_ISet1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ISet1.Location = new System.Drawing.Point(107, 139);
            this.numericUpDown_ISet1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_ISet1.Name = "numericUpDown_ISet1";
            this.numericUpDown_ISet1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_ISet1.TabIndex = 45;
            this.numericUpDown_ISet1.ValueChanged += new System.EventHandler(this.numericUpDown_ISet1_ValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 143);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 37;
            this.label29.Text = "I Set, %";
            // 
            // checkBox_Polarity1
            // 
            this.checkBox_Polarity1.AutoSize = true;
            this.checkBox_Polarity1.Location = new System.Drawing.Point(107, 118);
            this.checkBox_Polarity1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Polarity1.Name = "checkBox_Polarity1";
            this.checkBox_Polarity1.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Polarity1.TabIndex = 36;
            this.checkBox_Polarity1.Text = "Reversed";
            this.checkBox_Polarity1.UseVisualStyleBackColor = true;
            this.checkBox_Polarity1.CheckedChanged += new System.EventHandler(this.checkBox_Polarity1_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 118);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Polarity";
            // 
            // groupBox_Temp1
            // 
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_SetPointTemp1);
            this.groupBox_Temp1.Controls.Add(this.label_SetPointTemp);
            this.groupBox_Temp1.Controls.Add(this.label_PTemp1);
            this.groupBox_Temp1.Controls.Add(this.label_ITemp1);
            this.groupBox_Temp1.Controls.Add(this.label_DTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_PTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_DTemp1);
            this.groupBox_Temp1.Controls.Add(this.numericUpDown_ITemp1);
            this.groupBox_Temp1.Location = new System.Drawing.Point(13, 166);
            this.groupBox_Temp1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Temp1.Name = "groupBox_Temp1";
            this.groupBox_Temp1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Temp1.Size = new System.Drawing.Size(114, 122);
            this.groupBox_Temp1.TabIndex = 31;
            this.groupBox_Temp1.TabStop = false;
            this.groupBox_Temp1.Text = "Temp Source";
            // 
            // numericUpDown_SetPointTemp1
            // 
            this.numericUpDown_SetPointTemp1.DecimalPlaces = 2;
            this.numericUpDown_SetPointTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_SetPointTemp1.Location = new System.Drawing.Point(13, 36);
            this.numericUpDown_SetPointTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_SetPointTemp1.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_SetPointTemp1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDown_SetPointTemp1.Name = "numericUpDown_SetPointTemp1";
            this.numericUpDown_SetPointTemp1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_SetPointTemp1.TabIndex = 11;
            this.numericUpDown_SetPointTemp1.ValueChanged += new System.EventHandler(this.numericUpDown_SetPointTemp1_ValueChanged);
            // 
            // label_SetPointTemp
            // 
            this.label_SetPointTemp.AutoSize = true;
            this.label_SetPointTemp.Location = new System.Drawing.Point(11, 21);
            this.label_SetPointTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SetPointTemp.Name = "label_SetPointTemp";
            this.label_SetPointTemp.Size = new System.Drawing.Size(93, 13);
            this.label_SetPointTemp.TabIndex = 10;
            this.label_SetPointTemp.Text = "Temp Setpoint, °C";
            // 
            // label_PTemp1
            // 
            this.label_PTemp1.AutoSize = true;
            this.label_PTemp1.Location = new System.Drawing.Point(11, 59);
            this.label_PTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PTemp1.Name = "label_PTemp1";
            this.label_PTemp1.Size = new System.Drawing.Size(14, 13);
            this.label_PTemp1.TabIndex = 12;
            this.label_PTemp1.Text = "P";
            // 
            // label_ITemp1
            // 
            this.label_ITemp1.AutoSize = true;
            this.label_ITemp1.Location = new System.Drawing.Point(12, 77);
            this.label_ITemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ITemp1.Name = "label_ITemp1";
            this.label_ITemp1.Size = new System.Drawing.Size(10, 13);
            this.label_ITemp1.TabIndex = 13;
            this.label_ITemp1.Text = "I";
            // 
            // label_DTemp1
            // 
            this.label_DTemp1.AutoSize = true;
            this.label_DTemp1.Location = new System.Drawing.Point(10, 97);
            this.label_DTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DTemp1.Name = "label_DTemp1";
            this.label_DTemp1.Size = new System.Drawing.Size(15, 13);
            this.label_DTemp1.TabIndex = 14;
            this.label_DTemp1.Text = "D";
            // 
            // numericUpDown_PTemp1
            // 
            this.numericUpDown_PTemp1.DecimalPlaces = 5;
            this.numericUpDown_PTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PTemp1.Location = new System.Drawing.Point(27, 57);
            this.numericUpDown_PTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_PTemp1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_PTemp1.Name = "numericUpDown_PTemp1";
            this.numericUpDown_PTemp1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_PTemp1.TabIndex = 15;
            this.numericUpDown_PTemp1.ValueChanged += new System.EventHandler(this.numericUpDown_PTemp1_ValueChanged);
            // 
            // numericUpDown_DTemp1
            // 
            this.numericUpDown_DTemp1.DecimalPlaces = 5;
            this.numericUpDown_DTemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DTemp1.Location = new System.Drawing.Point(27, 95);
            this.numericUpDown_DTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DTemp1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_DTemp1.Name = "numericUpDown_DTemp1";
            this.numericUpDown_DTemp1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_DTemp1.TabIndex = 17;
            this.numericUpDown_DTemp1.ValueChanged += new System.EventHandler(this.numericUpDown_DTemp1_ValueChanged);
            // 
            // numericUpDown_ITemp1
            // 
            this.numericUpDown_ITemp1.DecimalPlaces = 5;
            this.numericUpDown_ITemp1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_ITemp1.Location = new System.Drawing.Point(27, 75);
            this.numericUpDown_ITemp1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_ITemp1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_ITemp1.Name = "numericUpDown_ITemp1";
            this.numericUpDown_ITemp1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_ITemp1.TabIndex = 16;
            this.numericUpDown_ITemp1.ValueChanged += new System.EventHandler(this.numericUpDown_ITemp1_ValueChanged);
            // 
            // groupBox_Freq1
            // 
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_SetPointFreq1);
            this.groupBox_Freq1.Controls.Add(this.label_SetPointFreq);
            this.groupBox_Freq1.Controls.Add(this.label3);
            this.groupBox_Freq1.Controls.Add(this.label2);
            this.groupBox_Freq1.Controls.Add(this.label1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_DFreq1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_PFreq1);
            this.groupBox_Freq1.Controls.Add(this.numericUpDown_IFreq1);
            this.groupBox_Freq1.Location = new System.Drawing.Point(131, 166);
            this.groupBox_Freq1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Freq1.Name = "groupBox_Freq1";
            this.groupBox_Freq1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Freq1.Size = new System.Drawing.Size(102, 122);
            this.groupBox_Freq1.TabIndex = 30;
            this.groupBox_Freq1.TabStop = false;
            this.groupBox_Freq1.Text = "Freq Source";
            // 
            // numericUpDown_SetPointFreq1
            // 
            this.numericUpDown_SetPointFreq1.Location = new System.Drawing.Point(11, 36);
            this.numericUpDown_SetPointFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_SetPointFreq1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq1.Name = "numericUpDown_SetPointFreq1";
            this.numericUpDown_SetPointFreq1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_SetPointFreq1.TabIndex = 19;
            this.numericUpDown_SetPointFreq1.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_SetPointFreq1.ValueChanged += new System.EventHandler(this.numericUpDown_SetPointFreq1_ValueChanged);
            // 
            // label_SetPointFreq
            // 
            this.label_SetPointFreq.AutoSize = true;
            this.label_SetPointFreq.Location = new System.Drawing.Point(9, 21);
            this.label_SetPointFreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SetPointFreq.Name = "label_SetPointFreq";
            this.label_SetPointFreq.Size = new System.Drawing.Size(89, 13);
            this.label_SetPointFreq.TabIndex = 18;
            this.label_SetPointFreq.Text = "Freq Setpoint, Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "D";
            // 
            // numericUpDown_DFreq1
            // 
            this.numericUpDown_DFreq1.DecimalPlaces = 5;
            this.numericUpDown_DFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_DFreq1.Location = new System.Drawing.Point(26, 95);
            this.numericUpDown_DFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DFreq1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_DFreq1.Name = "numericUpDown_DFreq1";
            this.numericUpDown_DFreq1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_DFreq1.TabIndex = 25;
            this.numericUpDown_DFreq1.ValueChanged += new System.EventHandler(this.numericUpDown_DFreq1_ValueChanged);
            // 
            // numericUpDown_PFreq1
            // 
            this.numericUpDown_PFreq1.DecimalPlaces = 5;
            this.numericUpDown_PFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PFreq1.Location = new System.Drawing.Point(26, 57);
            this.numericUpDown_PFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_PFreq1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_PFreq1.Name = "numericUpDown_PFreq1";
            this.numericUpDown_PFreq1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_PFreq1.TabIndex = 23;
            this.numericUpDown_PFreq1.ValueChanged += new System.EventHandler(this.numericUpDown_PFreq1_ValueChanged);
            // 
            // numericUpDown_IFreq1
            // 
            this.numericUpDown_IFreq1.DecimalPlaces = 5;
            this.numericUpDown_IFreq1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_IFreq1.Location = new System.Drawing.Point(26, 75);
            this.numericUpDown_IFreq1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_IFreq1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_IFreq1.Name = "numericUpDown_IFreq1";
            this.numericUpDown_IFreq1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_IFreq1.TabIndex = 24;
            this.numericUpDown_IFreq1.ValueChanged += new System.EventHandler(this.numericUpDown_IFreq1_ValueChanged);
            // 
            // button_EnableCh1
            // 
            this.button_EnableCh1.Location = new System.Drawing.Point(13, 292);
            this.button_EnableCh1.Margin = new System.Windows.Forms.Padding(2);
            this.button_EnableCh1.Name = "button_EnableCh1";
            this.button_EnableCh1.Size = new System.Drawing.Size(220, 42);
            this.button_EnableCh1.TabIndex = 26;
            this.button_EnableCh1.Text = "Enable";
            this.button_EnableCh1.UseVisualStyleBackColor = true;
            this.button_EnableCh1.Click += new System.EventHandler(this.button_EnableCh1_Click);
            // 
            // comboBox_Source1
            // 
            this.comboBox_Source1.DisplayMember = "(none)";
            this.comboBox_Source1.FormattingEnabled = true;
            this.comboBox_Source1.Items.AddRange(new object[] {
            "Temp1",
            "Temp2",
            "Temp3",
            "Temp4",
            "Freq"});
            this.comboBox_Source1.Location = new System.Drawing.Point(107, 83);
            this.comboBox_Source1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Source1.Name = "comboBox_Source1";
            this.comboBox_Source1.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Source1.TabIndex = 9;
            this.comboBox_Source1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Source1_SelectedIndexChanged);
            this.comboBox_Source1.EnabledChanged += new System.EventHandler(this.comboBox_Source1_EnabledChanged);
            // 
            // label_Source1
            // 
            this.label_Source1.AutoSize = true;
            this.label_Source1.Location = new System.Drawing.Point(8, 88);
            this.label_Source1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Source1.Name = "label_Source1";
            this.label_Source1.Size = new System.Drawing.Size(41, 13);
            this.label_Source1.TabIndex = 8;
            this.label_Source1.Text = "Source";
            // 
            // comboBox_Mode1
            // 
            this.comboBox_Mode1.FormattingEnabled = true;
            this.comboBox_Mode1.Items.AddRange(new object[] {
            "PID",
            "Const current"});
            this.comboBox_Mode1.Location = new System.Drawing.Point(107, 53);
            this.comboBox_Mode1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Mode1.Name = "comboBox_Mode1";
            this.comboBox_Mode1.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Mode1.TabIndex = 7;
            this.comboBox_Mode1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode1_SelectedIndexChanged);
            // 
            // label_Mode1
            // 
            this.label_Mode1.AutoSize = true;
            this.label_Mode1.Location = new System.Drawing.Point(8, 55);
            this.label_Mode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Mode1.Name = "label_Mode1";
            this.label_Mode1.Size = new System.Drawing.Size(34, 13);
            this.label_Mode1.TabIndex = 6;
            this.label_Mode1.Text = "Mode";
            // 
            // comboBox_Load1
            // 
            this.comboBox_Load1.FormattingEnabled = true;
            this.comboBox_Load1.Items.AddRange(new object[] {
            "Resistor",
            "Peltier"});
            this.comboBox_Load1.Location = new System.Drawing.Point(107, 20);
            this.comboBox_Load1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Load1.Name = "comboBox_Load1";
            this.comboBox_Load1.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Load1.TabIndex = 1;
            this.comboBox_Load1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Load1_SelectedIndexChanged);
            // 
            // label_Load1
            // 
            this.label_Load1.AutoSize = true;
            this.label_Load1.Location = new System.Drawing.Point(8, 21);
            this.label_Load1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Load1.Name = "label_Load1";
            this.label_Load1.Size = new System.Drawing.Size(31, 13);
            this.label_Load1.TabIndex = 0;
            this.label_Load1.Text = "Load";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1119, 702);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(20, 13);
            this.label44.TabIndex = 64;
            this.label44.Text = "Hz";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(963, 702);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(57, 13);
            this.label43.TabIndex = 63;
            this.label43.Text = "Bandwidth";
            // 
            // groupBox_ChannelsMode
            // 
            this.groupBox_ChannelsMode.Controls.Add(this.radioButton_ModeDependent);
            this.groupBox_ChannelsMode.Controls.Add(this.radioButton_ModeIndependent);
            this.groupBox_ChannelsMode.Location = new System.Drawing.Point(317, 23);
            this.groupBox_ChannelsMode.Name = "groupBox_ChannelsMode";
            this.groupBox_ChannelsMode.Size = new System.Drawing.Size(113, 71);
            this.groupBox_ChannelsMode.TabIndex = 47;
            this.groupBox_ChannelsMode.TabStop = false;
            this.groupBox_ChannelsMode.Text = "Channels mode";
            // 
            // radioButton_ModeDependent
            // 
            this.radioButton_ModeDependent.AutoSize = true;
            this.radioButton_ModeDependent.Checked = true;
            this.radioButton_ModeDependent.Location = new System.Drawing.Point(9, 48);
            this.radioButton_ModeDependent.Name = "radioButton_ModeDependent";
            this.radioButton_ModeDependent.Size = new System.Drawing.Size(78, 17);
            this.radioButton_ModeDependent.TabIndex = 46;
            this.radioButton_ModeDependent.TabStop = true;
            this.radioButton_ModeDependent.Text = "Dependent";
            this.radioButton_ModeDependent.UseVisualStyleBackColor = true;
            this.radioButton_ModeDependent.CheckedChanged += new System.EventHandler(this.radioButton_ModeDependent_CheckedChanged);
            // 
            // radioButton_ModeIndependent
            // 
            this.radioButton_ModeIndependent.AutoSize = true;
            this.radioButton_ModeIndependent.Location = new System.Drawing.Point(9, 27);
            this.radioButton_ModeIndependent.Name = "radioButton_ModeIndependent";
            this.radioButton_ModeIndependent.Size = new System.Drawing.Size(85, 17);
            this.radioButton_ModeIndependent.TabIndex = 45;
            this.radioButton_ModeIndependent.Text = "Independent";
            this.radioButton_ModeIndependent.UseVisualStyleBackColor = true;
            // 
            // button_SaveFlash
            // 
            this.button_SaveFlash.Location = new System.Drawing.Point(9, 17);
            this.button_SaveFlash.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveFlash.Name = "button_SaveFlash";
            this.button_SaveFlash.Size = new System.Drawing.Size(198, 38);
            this.button_SaveFlash.TabIndex = 35;
            this.button_SaveFlash.Text = "Save Flash";
            this.button_SaveFlash.UseVisualStyleBackColor = true;
            this.button_SaveFlash.Click += new System.EventHandler(this.button_SaveFlash_Click);
            // 
            // groupBox_Meas
            // 
            this.groupBox_Meas.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Meas.Location = new System.Drawing.Point(6, 480);
            this.groupBox_Meas.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Meas.Name = "groupBox_Meas";
            this.groupBox_Meas.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Meas.Size = new System.Drawing.Size(493, 287);
            this.groupBox_Meas.TabIndex = 31;
            this.groupBox_Meas.TabStop = false;
            this.groupBox_Meas.Text = "Measurements";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmFreqMasked, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentCh1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp4Masked, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmFreq, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp3Masked, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp2Masked, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMax, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMin, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp4, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FreqMeas, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp3, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.label24, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp2, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmTemp1, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh1Meas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Max, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Max, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Max, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Max, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh1Max, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh2Meas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmCurrentCh1Masked, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmU_HeaterMasked, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmU_PowerMasked, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_U_Power, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Min, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmCurrentCh2Masked, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Min, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label_U_Heater, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Min, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMeas, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Min, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMeas, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMin, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp4Meas, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMin, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp3Meas, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_CurrentCh2Max, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp2Meas, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_PowerMax, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_Temp1Meas, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_U_HeaterMax, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmCurrentCh1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmCurrentCh2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmU_Power, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_AlarmU_Heater, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_AlarmTemp1Masked, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label32, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 270);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // checkBox_AlarmFreqMasked
            // 
            this.checkBox_AlarmFreqMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmFreqMasked.AutoSize = true;
            this.checkBox_AlarmFreqMasked.Location = new System.Drawing.Point(455, 248);
            this.checkBox_AlarmFreqMasked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmFreqMasked.Name = "checkBox_AlarmFreqMasked";
            this.checkBox_AlarmFreqMasked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmFreqMasked.TabIndex = 77;
            this.checkBox_AlarmFreqMasked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmFreqMasked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmFreqMasked_CheckedChanged);
            // 
            // label_CurrentCh1
            // 
            this.label_CurrentCh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_CurrentCh1.AutoSize = true;
            this.label_CurrentCh1.Location = new System.Drawing.Point(10, 29);
            this.label_CurrentCh1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CurrentCh1.Name = "label_CurrentCh1";
            this.label_CurrentCh1.Size = new System.Drawing.Size(76, 13);
            this.label_CurrentCh1.TabIndex = 28;
            this.label_CurrentCh1.Text = "Current Ch1, A";
            this.label_CurrentCh1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp4Masked
            // 
            this.checkBox_AlarmTemp4Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp4Masked.AutoSize = true;
            this.checkBox_AlarmTemp4Masked.Location = new System.Drawing.Point(455, 221);
            this.checkBox_AlarmTemp4Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmTemp4Masked.Name = "checkBox_AlarmTemp4Masked";
            this.checkBox_AlarmTemp4Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmTemp4Masked.TabIndex = 74;
            this.checkBox_AlarmTemp4Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmTemp4Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmTemp4Masked_CheckedChanged);
            // 
            // pictureBox_AlarmFreq
            // 
            this.pictureBox_AlarmFreq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmFreq.Location = new System.Drawing.Point(402, 245);
            this.pictureBox_AlarmFreq.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmFreq.Name = "pictureBox_AlarmFreq";
            this.pictureBox_AlarmFreq.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmFreq.TabIndex = 68;
            this.pictureBox_AlarmFreq.TabStop = false;
            this.pictureBox_AlarmFreq.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // checkBox_AlarmTemp3Masked
            // 
            this.checkBox_AlarmTemp3Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp3Masked.AutoSize = true;
            this.checkBox_AlarmTemp3Masked.Location = new System.Drawing.Point(455, 197);
            this.checkBox_AlarmTemp3Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmTemp3Masked.Name = "checkBox_AlarmTemp3Masked";
            this.checkBox_AlarmTemp3Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmTemp3Masked.TabIndex = 73;
            this.checkBox_AlarmTemp3Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmTemp3Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmTemp3Masked_CheckedChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 5);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Meas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp2Masked
            // 
            this.checkBox_AlarmTemp2Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp2Masked.AutoSize = true;
            this.checkBox_AlarmTemp2Masked.Location = new System.Drawing.Point(455, 173);
            this.checkBox_AlarmTemp2Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmTemp2Masked.Name = "checkBox_AlarmTemp2Masked";
            this.checkBox_AlarmTemp2Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmTemp2Masked.TabIndex = 72;
            this.checkBox_AlarmTemp2Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmTemp2Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmTemp2Masked_CheckedChanged);
            // 
            // numericUpDown_FreqMax
            // 
            this.numericUpDown_FreqMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMax.Location = new System.Drawing.Point(299, 245);
            this.numericUpDown_FreqMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FreqMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMax.Name = "numericUpDown_FreqMax";
            this.numericUpDown_FreqMax.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_FreqMax.TabIndex = 76;
            this.numericUpDown_FreqMax.ThousandsSeparator = true;
            this.numericUpDown_FreqMax.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMax.ValueChanged += new System.EventHandler(this.numericUpDown_FreqMax_ValueChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(230, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Min";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_FreqMin
            // 
            this.numericUpDown_FreqMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMin.Location = new System.Drawing.Point(202, 245);
            this.numericUpDown_FreqMin.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FreqMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMin.Name = "numericUpDown_FreqMin";
            this.numericUpDown_FreqMin.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_FreqMin.TabIndex = 35;
            this.numericUpDown_FreqMin.ThousandsSeparator = true;
            this.numericUpDown_FreqMin.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMin.ValueChanged += new System.EventHandler(this.numericUpDown_FreqMin_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp4
            // 
            this.pictureBox_AlarmTemp4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp4.Location = new System.Drawing.Point(402, 218);
            this.pictureBox_AlarmTemp4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmTemp4.Name = "pictureBox_AlarmTemp4";
            this.pictureBox_AlarmTemp4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmTemp4.TabIndex = 67;
            this.pictureBox_AlarmTemp4.TabStop = false;
            this.pictureBox_AlarmTemp4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // numericUpDown_FreqMeas
            // 
            this.numericUpDown_FreqMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMeas.Location = new System.Drawing.Point(105, 245);
            this.numericUpDown_FreqMeas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FreqMeas.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMeas.Name = "numericUpDown_FreqMeas";
            this.numericUpDown_FreqMeas.ReadOnly = true;
            this.numericUpDown_FreqMeas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_FreqMeas.TabIndex = 35;
            this.numericUpDown_FreqMeas.ThousandsSeparator = true;
            this.numericUpDown_FreqMeas.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // pictureBox_AlarmTemp3
            // 
            this.pictureBox_AlarmTemp3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp3.Location = new System.Drawing.Point(402, 194);
            this.pictureBox_AlarmTemp3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmTemp3.Name = "pictureBox_AlarmTemp3";
            this.pictureBox_AlarmTemp3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmTemp3.TabIndex = 66;
            this.pictureBox_AlarmTemp3.TabStop = false;
            this.pictureBox_AlarmTemp3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(440, 5);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 68;
            this.label24.Text = "Masked";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp2
            // 
            this.pictureBox_AlarmTemp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp2.Location = new System.Drawing.Point(402, 170);
            this.pictureBox_AlarmTemp2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmTemp2.Name = "pictureBox_AlarmTemp2";
            this.pictureBox_AlarmTemp2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmTemp2.TabIndex = 65;
            this.pictureBox_AlarmTemp2.TabStop = false;
            this.pictureBox_AlarmTemp2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 248);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 75;
            this.label26.Text = "Freq, Hz";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmTemp1
            // 
            this.pictureBox_AlarmTemp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmTemp1.Location = new System.Drawing.Point(402, 146);
            this.pictureBox_AlarmTemp1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmTemp1.Name = "pictureBox_AlarmTemp1";
            this.pictureBox_AlarmTemp1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmTemp1.TabIndex = 64;
            this.pictureBox_AlarmTemp1.TabStop = false;
            this.pictureBox_AlarmTemp1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // numericUpDown_CurrentCh1Meas
            // 
            this.numericUpDown_CurrentCh1Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh1Meas.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh1Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh1Meas.Location = new System.Drawing.Point(105, 26);
            this.numericUpDown_CurrentCh1Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_CurrentCh1Meas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh1Meas.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh1Meas.Name = "numericUpDown_CurrentCh1Meas";
            this.numericUpDown_CurrentCh1Meas.ReadOnly = true;
            this.numericUpDown_CurrentCh1Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_CurrentCh1Meas.TabIndex = 27;
            // 
            // numericUpDown_Temp1Max
            // 
            this.numericUpDown_Temp1Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Max.DecimalPlaces = 2;
            this.numericUpDown_Temp1Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Max.Location = new System.Drawing.Point(299, 146);
            this.numericUpDown_Temp1Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp1Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp1Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Max.Name = "numericUpDown_Temp1Max";
            this.numericUpDown_Temp1Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp1Max.TabIndex = 60;
            this.numericUpDown_Temp1Max.ValueChanged += new System.EventHandler(this.numericUpDown_Temp1Max_ValueChanged);
            // 
            // numericUpDown_Temp2Max
            // 
            this.numericUpDown_Temp2Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Max.DecimalPlaces = 2;
            this.numericUpDown_Temp2Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Max.Location = new System.Drawing.Point(299, 170);
            this.numericUpDown_Temp2Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp2Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp2Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Max.Name = "numericUpDown_Temp2Max";
            this.numericUpDown_Temp2Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp2Max.TabIndex = 61;
            this.numericUpDown_Temp2Max.ValueChanged += new System.EventHandler(this.numericUpDown_Temp2Max_ValueChanged);
            // 
            // numericUpDown_Temp3Max
            // 
            this.numericUpDown_Temp3Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Max.DecimalPlaces = 2;
            this.numericUpDown_Temp3Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Max.Location = new System.Drawing.Point(299, 194);
            this.numericUpDown_Temp3Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp3Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp3Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Max.Name = "numericUpDown_Temp3Max";
            this.numericUpDown_Temp3Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp3Max.TabIndex = 62;
            this.numericUpDown_Temp3Max.ValueChanged += new System.EventHandler(this.numericUpDown_Temp3Max_ValueChanged);
            // 
            // numericUpDown_Temp4Max
            // 
            this.numericUpDown_Temp4Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Max.DecimalPlaces = 2;
            this.numericUpDown_Temp4Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Max.Location = new System.Drawing.Point(299, 218);
            this.numericUpDown_Temp4Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp4Max.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp4Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Max.Name = "numericUpDown_Temp4Max";
            this.numericUpDown_Temp4Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp4Max.TabIndex = 63;
            this.numericUpDown_Temp4Max.ValueChanged += new System.EventHandler(this.numericUpDown_Temp4Max_ValueChanged);
            // 
            // numericUpDown_CurrentCh1Max
            // 
            this.numericUpDown_CurrentCh1Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh1Max.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh1Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh1Max.Location = new System.Drawing.Point(299, 26);
            this.numericUpDown_CurrentCh1Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_CurrentCh1Max.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh1Max.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh1Max.Name = "numericUpDown_CurrentCh1Max";
            this.numericUpDown_CurrentCh1Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_CurrentCh1Max.TabIndex = 46;
            // 
            // numericUpDown_CurrentCh2Meas
            // 
            this.numericUpDown_CurrentCh2Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh2Meas.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh2Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh2Meas.Location = new System.Drawing.Point(105, 50);
            this.numericUpDown_CurrentCh2Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_CurrentCh2Meas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh2Meas.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh2Meas.Name = "numericUpDown_CurrentCh2Meas";
            this.numericUpDown_CurrentCh2Meas.ReadOnly = true;
            this.numericUpDown_CurrentCh2Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_CurrentCh2Meas.TabIndex = 41;
            // 
            // checkBox_AlarmCurrentCh1Masked
            // 
            this.checkBox_AlarmCurrentCh1Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmCurrentCh1Masked.AutoSize = true;
            this.checkBox_AlarmCurrentCh1Masked.Location = new System.Drawing.Point(455, 29);
            this.checkBox_AlarmCurrentCh1Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmCurrentCh1Masked.Name = "checkBox_AlarmCurrentCh1Masked";
            this.checkBox_AlarmCurrentCh1Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmCurrentCh1Masked.TabIndex = 34;
            this.checkBox_AlarmCurrentCh1Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmCurrentCh1Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmCurrentCh1Masked_CheckedChanged);
            // 
            // checkBox_AlarmU_HeaterMasked
            // 
            this.checkBox_AlarmU_HeaterMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmU_HeaterMasked.AutoSize = true;
            this.checkBox_AlarmU_HeaterMasked.Location = new System.Drawing.Point(455, 101);
            this.checkBox_AlarmU_HeaterMasked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmU_HeaterMasked.Name = "checkBox_AlarmU_HeaterMasked";
            this.checkBox_AlarmU_HeaterMasked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmU_HeaterMasked.TabIndex = 70;
            this.checkBox_AlarmU_HeaterMasked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmU_HeaterMasked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmU_HeaterMasked_CheckedChanged);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Current Ch2, A";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmU_PowerMasked
            // 
            this.checkBox_AlarmU_PowerMasked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmU_PowerMasked.AutoSize = true;
            this.checkBox_AlarmU_PowerMasked.Location = new System.Drawing.Point(455, 77);
            this.checkBox_AlarmU_PowerMasked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmU_PowerMasked.Name = "checkBox_AlarmU_PowerMasked";
            this.checkBox_AlarmU_PowerMasked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmU_PowerMasked.TabIndex = 69;
            this.checkBox_AlarmU_PowerMasked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmU_PowerMasked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmU_PowerMasked_CheckedChanged);
            // 
            // label_U_Power
            // 
            this.label_U_Power.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_U_Power.AutoSize = true;
            this.label_U_Power.Location = new System.Drawing.Point(16, 77);
            this.label_U_Power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_U_Power.Name = "label_U_Power";
            this.label_U_Power.Size = new System.Drawing.Size(64, 13);
            this.label_U_Power.TabIndex = 0;
            this.label_U_Power.Text = "U_Power, V";
            this.label_U_Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Temp4Min
            // 
            this.numericUpDown_Temp4Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Min.DecimalPlaces = 2;
            this.numericUpDown_Temp4Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Min.Location = new System.Drawing.Point(202, 218);
            this.numericUpDown_Temp4Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp4Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp4Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Min.Name = "numericUpDown_Temp4Min";
            this.numericUpDown_Temp4Min.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp4Min.TabIndex = 59;
            this.numericUpDown_Temp4Min.ValueChanged += new System.EventHandler(this.numericUpDown_Temp4Min_ValueChanged);
            // 
            // checkBox_AlarmCurrentCh2Masked
            // 
            this.checkBox_AlarmCurrentCh2Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmCurrentCh2Masked.AutoSize = true;
            this.checkBox_AlarmCurrentCh2Masked.Location = new System.Drawing.Point(455, 53);
            this.checkBox_AlarmCurrentCh2Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmCurrentCh2Masked.Name = "checkBox_AlarmCurrentCh2Masked";
            this.checkBox_AlarmCurrentCh2Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmCurrentCh2Masked.TabIndex = 35;
            this.checkBox_AlarmCurrentCh2Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmCurrentCh2Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmCurrentCh2Masked_CheckedChanged);
            // 
            // numericUpDown_Temp3Min
            // 
            this.numericUpDown_Temp3Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Min.DecimalPlaces = 2;
            this.numericUpDown_Temp3Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Min.Location = new System.Drawing.Point(202, 194);
            this.numericUpDown_Temp3Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp3Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp3Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Min.Name = "numericUpDown_Temp3Min";
            this.numericUpDown_Temp3Min.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp3Min.TabIndex = 58;
            this.numericUpDown_Temp3Min.ValueChanged += new System.EventHandler(this.numericUpDown_Temp3Min_ValueChanged);
            // 
            // label_U_Heater
            // 
            this.label_U_Heater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_U_Heater.AutoSize = true;
            this.label_U_Heater.Location = new System.Drawing.Point(15, 101);
            this.label_U_Heater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_U_Heater.Name = "label_U_Heater";
            this.label_U_Heater.Size = new System.Drawing.Size(66, 13);
            this.label_U_Heater.TabIndex = 1;
            this.label_U_Heater.Text = "U_Heater, V";
            this.label_U_Heater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Temp2Min
            // 
            this.numericUpDown_Temp2Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Min.DecimalPlaces = 2;
            this.numericUpDown_Temp2Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Min.Location = new System.Drawing.Point(202, 170);
            this.numericUpDown_Temp2Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp2Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp2Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Min.Name = "numericUpDown_Temp2Min";
            this.numericUpDown_Temp2Min.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp2Min.TabIndex = 57;
            this.numericUpDown_Temp2Min.ValueChanged += new System.EventHandler(this.numericUpDown_Temp2Min_ValueChanged);
            // 
            // numericUpDown_U_PowerMeas
            // 
            this.numericUpDown_U_PowerMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMeas.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMeas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_U_PowerMeas.Location = new System.Drawing.Point(105, 74);
            this.numericUpDown_U_PowerMeas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_PowerMeas.Name = "numericUpDown_U_PowerMeas";
            this.numericUpDown_U_PowerMeas.ReadOnly = true;
            this.numericUpDown_U_PowerMeas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_PowerMeas.TabIndex = 3;
            // 
            // numericUpDown_Temp1Min
            // 
            this.numericUpDown_Temp1Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Min.DecimalPlaces = 2;
            this.numericUpDown_Temp1Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Min.Location = new System.Drawing.Point(202, 146);
            this.numericUpDown_Temp1Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp1Min.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_Temp1Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Min.Name = "numericUpDown_Temp1Min";
            this.numericUpDown_Temp1Min.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp1Min.TabIndex = 56;
            this.numericUpDown_Temp1Min.ValueChanged += new System.EventHandler(this.numericUpDown_Temp1Min_ValueChanged);
            // 
            // numericUpDown_U_HeaterMeas
            // 
            this.numericUpDown_U_HeaterMeas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMeas.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMeas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_U_HeaterMeas.Location = new System.Drawing.Point(105, 98);
            this.numericUpDown_U_HeaterMeas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_HeaterMeas.Name = "numericUpDown_U_HeaterMeas";
            this.numericUpDown_U_HeaterMeas.ReadOnly = true;
            this.numericUpDown_U_HeaterMeas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_HeaterMeas.TabIndex = 4;
            // 
            // numericUpDown_U_HeaterMin
            // 
            this.numericUpDown_U_HeaterMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMin.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_U_HeaterMin.Location = new System.Drawing.Point(202, 98);
            this.numericUpDown_U_HeaterMin.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_HeaterMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMin.Name = "numericUpDown_U_HeaterMin";
            this.numericUpDown_U_HeaterMin.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_HeaterMin.TabIndex = 50;
            this.numericUpDown_U_HeaterMin.ValueChanged += new System.EventHandler(this.numericUpDown_U_HeaterMin_ValueChanged);
            // 
            // numericUpDown_Temp4Meas
            // 
            this.numericUpDown_Temp4Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp4Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp4Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp4Meas.Location = new System.Drawing.Point(105, 218);
            this.numericUpDown_Temp4Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp4Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp4Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp4Meas.Name = "numericUpDown_Temp4Meas";
            this.numericUpDown_Temp4Meas.ReadOnly = true;
            this.numericUpDown_Temp4Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp4Meas.TabIndex = 39;
            // 
            // numericUpDown_U_PowerMin
            // 
            this.numericUpDown_U_PowerMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMin.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_PowerMin.Location = new System.Drawing.Point(202, 74);
            this.numericUpDown_U_PowerMin.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_PowerMin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMin.Name = "numericUpDown_U_PowerMin";
            this.numericUpDown_U_PowerMin.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_PowerMin.TabIndex = 48;
            this.numericUpDown_U_PowerMin.ValueChanged += new System.EventHandler(this.numericUpDown_U_PowerMin_ValueChanged);
            // 
            // numericUpDown_Temp3Meas
            // 
            this.numericUpDown_Temp3Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp3Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp3Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp3Meas.Location = new System.Drawing.Point(105, 194);
            this.numericUpDown_Temp3Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp3Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp3Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp3Meas.Name = "numericUpDown_Temp3Meas";
            this.numericUpDown_Temp3Meas.ReadOnly = true;
            this.numericUpDown_Temp3Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp3Meas.TabIndex = 38;
            // 
            // numericUpDown_CurrentCh2Max
            // 
            this.numericUpDown_CurrentCh2Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_CurrentCh2Max.DecimalPlaces = 3;
            this.numericUpDown_CurrentCh2Max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_CurrentCh2Max.Location = new System.Drawing.Point(299, 50);
            this.numericUpDown_CurrentCh2Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_CurrentCh2Max.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_CurrentCh2Max.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDown_CurrentCh2Max.Name = "numericUpDown_CurrentCh2Max";
            this.numericUpDown_CurrentCh2Max.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_CurrentCh2Max.TabIndex = 47;
            // 
            // numericUpDown_Temp2Meas
            // 
            this.numericUpDown_Temp2Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp2Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp2Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp2Meas.Location = new System.Drawing.Point(105, 170);
            this.numericUpDown_Temp2Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp2Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp2Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp2Meas.Name = "numericUpDown_Temp2Meas";
            this.numericUpDown_Temp2Meas.ReadOnly = true;
            this.numericUpDown_Temp2Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp2Meas.TabIndex = 37;
            // 
            // numericUpDown_U_PowerMax
            // 
            this.numericUpDown_U_PowerMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_PowerMax.DecimalPlaces = 2;
            this.numericUpDown_U_PowerMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_PowerMax.Location = new System.Drawing.Point(299, 74);
            this.numericUpDown_U_PowerMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_PowerMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMax.Name = "numericUpDown_U_PowerMax";
            this.numericUpDown_U_PowerMax.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_PowerMax.TabIndex = 49;
            this.numericUpDown_U_PowerMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_PowerMax.ValueChanged += new System.EventHandler(this.numericUpDown_U_PowerMax_ValueChanged);
            // 
            // numericUpDown_Temp1Meas
            // 
            this.numericUpDown_Temp1Meas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Temp1Meas.DecimalPlaces = 2;
            this.numericUpDown_Temp1Meas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_Temp1Meas.Location = new System.Drawing.Point(105, 146);
            this.numericUpDown_Temp1Meas.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Temp1Meas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Temp1Meas.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDown_Temp1Meas.Name = "numericUpDown_Temp1Meas";
            this.numericUpDown_Temp1Meas.ReadOnly = true;
            this.numericUpDown_Temp1Meas.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Temp1Meas.TabIndex = 32;
            // 
            // numericUpDown_U_HeaterMax
            // 
            this.numericUpDown_U_HeaterMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_U_HeaterMax.DecimalPlaces = 2;
            this.numericUpDown_U_HeaterMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_U_HeaterMax.Location = new System.Drawing.Point(299, 98);
            this.numericUpDown_U_HeaterMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_U_HeaterMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMax.Name = "numericUpDown_U_HeaterMax";
            this.numericUpDown_U_HeaterMax.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_U_HeaterMax.TabIndex = 51;
            this.numericUpDown_U_HeaterMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterMax.ValueChanged += new System.EventHandler(this.numericUpDown_U_HeaterMax_ValueChanged);
            // 
            // pictureBox_AlarmCurrentCh1
            // 
            this.pictureBox_AlarmCurrentCh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmCurrentCh1.Location = new System.Drawing.Point(402, 26);
            this.pictureBox_AlarmCurrentCh1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmCurrentCh1.Name = "pictureBox_AlarmCurrentCh1";
            this.pictureBox_AlarmCurrentCh1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmCurrentCh1.TabIndex = 52;
            this.pictureBox_AlarmCurrentCh1.TabStop = false;
            this.pictureBox_AlarmCurrentCh1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 221);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Temp 4, °C";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmCurrentCh2
            // 
            this.pictureBox_AlarmCurrentCh2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmCurrentCh2.Location = new System.Drawing.Point(402, 50);
            this.pictureBox_AlarmCurrentCh2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmCurrentCh2.Name = "pictureBox_AlarmCurrentCh2";
            this.pictureBox_AlarmCurrentCh2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmCurrentCh2.TabIndex = 53;
            this.pictureBox_AlarmCurrentCh2.TabStop = false;
            this.pictureBox_AlarmCurrentCh2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 197);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Temp 3, °C";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmU_Power
            // 
            this.pictureBox_AlarmU_Power.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmU_Power.Location = new System.Drawing.Point(402, 74);
            this.pictureBox_AlarmU_Power.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmU_Power.Name = "pictureBox_AlarmU_Power";
            this.pictureBox_AlarmU_Power.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmU_Power.TabIndex = 54;
            this.pictureBox_AlarmU_Power.TabStop = false;
            this.pictureBox_AlarmU_Power.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 173);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Temp 2, °C";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_AlarmU_Heater
            // 
            this.pictureBox_AlarmU_Heater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_AlarmU_Heater.Location = new System.Drawing.Point(402, 98);
            this.pictureBox_AlarmU_Heater.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_AlarmU_Heater.Name = "pictureBox_AlarmU_Heater";
            this.pictureBox_AlarmU_Heater.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_AlarmU_Heater.TabIndex = 55;
            this.pictureBox_AlarmU_Heater.TabStop = false;
            this.pictureBox_AlarmU_Heater.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 149);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Temp 1, °C";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_AlarmTemp1Masked
            // 
            this.checkBox_AlarmTemp1Masked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_AlarmTemp1Masked.AutoSize = true;
            this.checkBox_AlarmTemp1Masked.Location = new System.Drawing.Point(455, 149);
            this.checkBox_AlarmTemp1Masked.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_AlarmTemp1Masked.Name = "checkBox_AlarmTemp1Masked";
            this.checkBox_AlarmTemp1Masked.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AlarmTemp1Masked.TabIndex = 71;
            this.checkBox_AlarmTemp1Masked.UseVisualStyleBackColor = true;
            this.checkBox_AlarmTemp1Masked.CheckedChanged += new System.EventHandler(this.checkBox_AlarmTemp1Masked_CheckedChanged);
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(395, 5);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 13);
            this.label32.TabIndex = 78;
            this.label32.Text = "Alarm";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_FilterBand
            // 
            this.numericUpDown_FilterBand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FilterBand.DecimalPlaces = 1;
            this.numericUpDown_FilterBand.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_FilterBand.Location = new System.Drawing.Point(403, 2);
            this.numericUpDown_FilterBand.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FilterBand.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_FilterBand.Name = "numericUpDown_FilterBand";
            this.numericUpDown_FilterBand.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown_FilterBand.TabIndex = 62;
            this.numericUpDown_FilterBand.ThousandsSeparator = true;
            this.numericUpDown_FilterBand.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_FilterBand.ValueChanged += new System.EventHandler(this.numericUpDown_FilterBand_ValueChanged);
            // 
            // checkBox_PeakFilter
            // 
            this.checkBox_PeakFilter.AutoSize = true;
            this.checkBox_PeakFilter.Checked = true;
            this.checkBox_PeakFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PeakFilter.Location = new System.Drawing.Point(493, 3);
            this.checkBox_PeakFilter.Name = "checkBox_PeakFilter";
            this.checkBox_PeakFilter.Size = new System.Drawing.Size(73, 17);
            this.checkBox_PeakFilter.TabIndex = 58;
            this.checkBox_PeakFilter.Text = "Peak filter";
            this.checkBox_PeakFilter.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(167, 0);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(20, 13);
            this.label42.TabIndex = 61;
            this.label42.Text = "Hz";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(2, 0);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(57, 13);
            this.label41.TabIndex = 60;
            this.label41.Text = "Frequency";
            // 
            // numericUpDown_FreqMeas2
            // 
            this.numericUpDown_FreqMeas2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_FreqMeas2.DecimalPlaces = 1;
            this.numericUpDown_FreqMeas2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_FreqMeas2.Location = new System.Drawing.Point(63, 2);
            this.numericUpDown_FreqMeas2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_FreqMeas2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_FreqMeas2.Name = "numericUpDown_FreqMeas2";
            this.numericUpDown_FreqMeas2.ReadOnly = true;
            this.numericUpDown_FreqMeas2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_FreqMeas2.TabIndex = 59;
            this.numericUpDown_FreqMeas2.ThousandsSeparator = true;
            this.numericUpDown_FreqMeas2.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // checkBox_PlotDeriv
            // 
            this.checkBox_PlotDeriv.AutoSize = true;
            this.checkBox_PlotDeriv.Checked = true;
            this.checkBox_PlotDeriv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotDeriv.Location = new System.Drawing.Point(116, 3);
            this.checkBox_PlotDeriv.Name = "checkBox_PlotDeriv";
            this.checkBox_PlotDeriv.Size = new System.Drawing.Size(74, 17);
            this.checkBox_PlotDeriv.TabIndex = 58;
            this.checkBox_PlotDeriv.Text = "Derivative";
            this.checkBox_PlotDeriv.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotFreq
            // 
            this.checkBox_PlotFreq.AutoSize = true;
            this.checkBox_PlotFreq.Checked = true;
            this.checkBox_PlotFreq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotFreq.Location = new System.Drawing.Point(63, 3);
            this.checkBox_PlotFreq.Name = "checkBox_PlotFreq";
            this.checkBox_PlotFreq.Size = new System.Drawing.Size(47, 17);
            this.checkBox_PlotFreq.TabIndex = 57;
            this.checkBox_PlotFreq.Text = "Freq";
            this.checkBox_PlotFreq.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 0);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 13);
            this.label40.TabIndex = 56;
            this.label40.Text = "Plot select";
            // 
            // numericUpDown_DerNumber
            // 
            this.numericUpDown_DerNumber.Location = new System.Drawing.Point(350, 2);
            this.numericUpDown_DerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DerNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_DerNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_DerNumber.Name = "numericUpDown_DerNumber";
            this.numericUpDown_DerNumber.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_DerNumber.TabIndex = 54;
            this.numericUpDown_DerNumber.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(195, 0);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(151, 13);
            this.label38.TabIndex = 52;
            this.label38.Text = "Number to calculate derivative";
            // 
            // numericUpDown_TimeInterval
            // 
            this.numericUpDown_TimeInterval.Location = new System.Drawing.Point(92, 2);
            this.numericUpDown_TimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_TimeInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_TimeInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_TimeInterval.Name = "numericUpDown_TimeInterval";
            this.numericUpDown_TimeInterval.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_TimeInterval.TabIndex = 51;
            this.numericUpDown_TimeInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_TimeInterval.ValueChanged += new System.EventHandler(this.numericUpDown_TimeInterval_ValueChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(2, 0);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(86, 13);
            this.label37.TabIndex = 50;
            this.label37.Text = "Time interval, ms";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // groupBoxKprtCalibration
            // 
            this.groupBoxKprtCalibration.AutoSize = true;
            this.groupBoxKprtCalibration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxKprtCalibration.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxKprtCalibration.Controls.Add(this.button_CalibrateKprt);
            this.groupBoxKprtCalibration.Location = new System.Drawing.Point(3, 392);
            this.groupBoxKprtCalibration.Name = "groupBoxKprtCalibration";
            this.groupBoxKprtCalibration.Size = new System.Drawing.Size(666, 75);
            this.groupBoxKprtCalibration.TabIndex = 48;
            this.groupBoxKprtCalibration.TabStop = false;
            this.groupBoxKprtCalibration.Text = "Kprt Calibration";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_freqOffset, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_AwaitTime, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label39, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_DeltaF, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_KprtValue, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label34, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label36, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label45, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label46, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_TstartKprt, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_TstopKprt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label35, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_NumPointsKprt, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 56);
            this.tableLayoutPanel3.TabIndex = 62;
            // 
            // numericUpDown_freqOffset
            // 
            this.numericUpDown_freqOffset.DecimalPlaces = 1;
            this.numericUpDown_freqOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_freqOffset.Location = new System.Drawing.Point(430, 22);
            this.numericUpDown_freqOffset.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_freqOffset.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numericUpDown_freqOffset.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_freqOffset.Name = "numericUpDown_freqOffset";
            this.numericUpDown_freqOffset.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown_freqOffset.TabIndex = 58;
            this.numericUpDown_freqOffset.ThousandsSeparator = true;
            this.numericUpDown_freqOffset.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_freqOffset.ValueChanged += new System.EventHandler(this.numericUpDown_freqOffset_ValueChanged);
            // 
            // numericUpDown_AwaitTime
            // 
            this.numericUpDown_AwaitTime.DecimalPlaces = 1;
            this.numericUpDown_AwaitTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_AwaitTime.Location = new System.Drawing.Point(298, 22);
            this.numericUpDown_AwaitTime.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_AwaitTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_AwaitTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_AwaitTime.Name = "numericUpDown_AwaitTime";
            this.numericUpDown_AwaitTime.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_AwaitTime.TabIndex = 62;
            this.numericUpDown_AwaitTime.ThousandsSeparator = true;
            this.numericUpDown_AwaitTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_AwaitTime.ValueChanged += new System.EventHandler(this.numericUpDown_AwaitTime_ValueChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(365, 20);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 13);
            this.label39.TabIndex = 57;
            this.label39.Text = "f0, Hz";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(2, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 13);
            this.label33.TabIndex = 49;
            this.label33.Text = "Tstart, °C";
            // 
            // numericUpDown_DeltaF
            // 
            this.numericUpDown_DeltaF.DecimalPlaces = 1;
            this.numericUpDown_DeltaF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_DeltaF.Location = new System.Drawing.Point(298, 2);
            this.numericUpDown_DeltaF.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_DeltaF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_DeltaF.Name = "numericUpDown_DeltaF";
            this.numericUpDown_DeltaF.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_DeltaF.TabIndex = 61;
            this.numericUpDown_DeltaF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_DeltaF.ValueChanged += new System.EventHandler(this.numericUpDown_DeltaF_ValueChanged);
            // 
            // numericUpDown_KprtValue
            // 
            this.numericUpDown_KprtValue.DecimalPlaces = 1;
            this.numericUpDown_KprtValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_KprtValue.Location = new System.Drawing.Point(430, 2);
            this.numericUpDown_KprtValue.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_KprtValue.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_KprtValue.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown_KprtValue.Name = "numericUpDown_KprtValue";
            this.numericUpDown_KprtValue.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_KprtValue.TabIndex = 55;
            this.numericUpDown_KprtValue.Value = new decimal(new int[] {
            5000,
            0,
            0,
            -2147418112});
            this.numericUpDown_KprtValue.ValueChanged += new System.EventHandler(this.numericUpDown_KprtValue_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(2, 20);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(51, 13);
            this.label34.TabIndex = 50;
            this.label34.Text = "Tstop, °C";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(365, 0);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 13);
            this.label36.TabIndex = 54;
            this.label36.Text = "Kprt, Hz/°C";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(228, 20);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(66, 13);
            this.label45.TabIndex = 59;
            this.label45.Text = "Await time, s";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(228, 0);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 13);
            this.label46.TabIndex = 60;
            this.label46.Text = "Δf, Hz";
            // 
            // numericUpDown_TstartKprt
            // 
            this.numericUpDown_TstartKprt.DecimalPlaces = 2;
            this.numericUpDown_TstartKprt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_TstartKprt.Location = new System.Drawing.Point(57, 2);
            this.numericUpDown_TstartKprt.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_TstartKprt.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_TstartKprt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_TstartKprt.Name = "numericUpDown_TstartKprt";
            this.numericUpDown_TstartKprt.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_TstartKprt.TabIndex = 48;
            this.numericUpDown_TstartKprt.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // numericUpDown_TstopKprt
            // 
            this.numericUpDown_TstopKprt.DecimalPlaces = 2;
            this.numericUpDown_TstopKprt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_TstopKprt.Location = new System.Drawing.Point(57, 22);
            this.numericUpDown_TstopKprt.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_TstopKprt.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_TstopKprt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_TstopKprt.Name = "numericUpDown_TstopKprt";
            this.numericUpDown_TstopKprt.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown_TstopKprt.TabIndex = 51;
            this.numericUpDown_TstopKprt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(137, 0);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(87, 20);
            this.label35.TabIndex = 52;
            this.label35.Text = "Number of points";
            // 
            // numericUpDown_NumPointsKprt
            // 
            this.numericUpDown_NumPointsKprt.Dock = System.Windows.Forms.DockStyle.Right;
            this.numericUpDown_NumPointsKprt.Location = new System.Drawing.Point(175, 22);
            this.numericUpDown_NumPointsKprt.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_NumPointsKprt.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_NumPointsKprt.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_NumPointsKprt.Name = "numericUpDown_NumPointsKprt";
            this.numericUpDown_NumPointsKprt.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_NumPointsKprt.TabIndex = 53;
            this.numericUpDown_NumPointsKprt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button_CalibrateKprt
            // 
            this.button_CalibrateKprt.AutoSize = true;
            this.button_CalibrateKprt.Location = new System.Drawing.Point(543, 16);
            this.button_CalibrateKprt.Name = "button_CalibrateKprt";
            this.button_CalibrateKprt.Size = new System.Drawing.Size(117, 40);
            this.button_CalibrateKprt.TabIndex = 56;
            this.button_CalibrateKprt.Text = "Calibrate";
            this.button_CalibrateKprt.UseVisualStyleBackColor = true;
            this.button_CalibrateKprt.Click += new System.EventHandler(this.button_CalibrateKprt_Click);
            // 
            // button_ResetPlots
            // 
            this.button_ResetPlots.Location = new System.Drawing.Point(3, 759);
            this.button_ResetPlots.Name = "button_ResetPlots";
            this.button_ResetPlots.Size = new System.Drawing.Size(82, 23);
            this.button_ResetPlots.TabIndex = 44;
            this.button_ResetPlots.Text = "Reset Plots";
            this.button_ResetPlots.UseVisualStyleBackColor = true;
            this.button_ResetPlots.Click += new System.EventHandler(this.button_ResetPlots_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(2, 0);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 13);
            this.label31.TabIndex = 43;
            this.label31.Text = "Plot select";
            // 
            // checkBox_PlotTempFreq
            // 
            this.checkBox_PlotTempFreq.AutoSize = true;
            this.checkBox_PlotTempFreq.Location = new System.Drawing.Point(323, 3);
            this.checkBox_PlotTempFreq.Name = "checkBox_PlotTempFreq";
            this.checkBox_PlotTempFreq.Size = new System.Drawing.Size(65, 17);
            this.checkBox_PlotTempFreq.TabIndex = 42;
            this.checkBox_PlotTempFreq.Text = "Temp (f)";
            this.checkBox_PlotTempFreq.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp4
            // 
            this.checkBox_PlotTemp4.AutoSize = true;
            this.checkBox_PlotTemp4.Location = new System.Drawing.Point(258, 3);
            this.checkBox_PlotTemp4.Name = "checkBox_PlotTemp4";
            this.checkBox_PlotTemp4.Size = new System.Drawing.Size(59, 17);
            this.checkBox_PlotTemp4.TabIndex = 41;
            this.checkBox_PlotTemp4.Text = "Temp4";
            this.checkBox_PlotTemp4.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp3
            // 
            this.checkBox_PlotTemp3.AutoSize = true;
            this.checkBox_PlotTemp3.Location = new System.Drawing.Point(193, 3);
            this.checkBox_PlotTemp3.Name = "checkBox_PlotTemp3";
            this.checkBox_PlotTemp3.Size = new System.Drawing.Size(59, 17);
            this.checkBox_PlotTemp3.TabIndex = 40;
            this.checkBox_PlotTemp3.Text = "Temp3";
            this.checkBox_PlotTemp3.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp2
            // 
            this.checkBox_PlotTemp2.AutoSize = true;
            this.checkBox_PlotTemp2.Checked = true;
            this.checkBox_PlotTemp2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotTemp2.Location = new System.Drawing.Point(128, 3);
            this.checkBox_PlotTemp2.Name = "checkBox_PlotTemp2";
            this.checkBox_PlotTemp2.Size = new System.Drawing.Size(59, 17);
            this.checkBox_PlotTemp2.TabIndex = 39;
            this.checkBox_PlotTemp2.Text = "Temp2";
            this.checkBox_PlotTemp2.UseVisualStyleBackColor = true;
            // 
            // checkBox_PlotTemp1
            // 
            this.checkBox_PlotTemp1.AutoSize = true;
            this.checkBox_PlotTemp1.Checked = true;
            this.checkBox_PlotTemp1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PlotTemp1.Location = new System.Drawing.Point(63, 3);
            this.checkBox_PlotTemp1.Name = "checkBox_PlotTemp1";
            this.checkBox_PlotTemp1.Size = new System.Drawing.Size(59, 17);
            this.checkBox_PlotTemp1.TabIndex = 38;
            this.checkBox_PlotTemp1.Text = "Temp1";
            this.checkBox_PlotTemp1.UseVisualStyleBackColor = true;
            // 
            // chart_Freq
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Title = "Time, s";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Frequency, Hz";
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.Title = "Derivative, Hz/s";
            chartArea1.Name = "ChartArea1";
            this.chart_Freq.ChartAreas.Add(chartArea1);
            legendCell1.Name = "Cell1";
            legendItem1.Cells.Add(legendCell1);
            legend1.CustomItems.Add(legendItem1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart_Freq.Legends.Add(legend1);
            this.chart_Freq.Location = new System.Drawing.Point(3, 354);
            this.chart_Freq.Name = "chart_Freq";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.LegendText = "Frequency";
            series1.Name = "Series_FreqData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.LegendText = "Derivative";
            series2.Name = "Series_DFreq";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_Freq.Series.Add(series1);
            this.chart_Freq.Series.Add(series2);
            this.chart_Freq.Size = new System.Drawing.Size(632, 286);
            this.chart_Freq.TabIndex = 37;
            this.chart_Freq.Text = "Frequency";
            title1.Name = "Title1";
            title1.Text = "Frequency and derivative";
            this.chart_Freq.Titles.Add(title1);
            // 
            // chart_Temps
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Time, s";
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.Title = "Temp, °C";
            chartArea2.Name = "ChartArea1";
            this.chart_Temps.ChartAreas.Add(chartArea2);
            legendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn1.Name = "Symbols";
            legendCellColumn2.Name = "Names";
            legend2.CellColumns.Add(legendCellColumn1);
            legend2.CellColumns.Add(legendCellColumn2);
            legendCell2.Name = "Cell1";
            legendItem2.Cells.Add(legendCell2);
            legend2.CustomItems.Add(legendItem2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.Name = "Legend1";
            this.chart_Temps.Legends.Add(legend2);
            this.chart_Temps.Location = new System.Drawing.Point(3, 3);
            this.chart_Temps.Name = "chart_Temps";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.LegendText = "Temp 1";
            series3.Name = "Series_Temp1Data";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.LegendText = "Temp 2";
            series4.Name = "Series_Temp2Data";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.LegendText = "Temp3";
            series5.Name = "Series_Temp3Data";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Fuchsia;
            series6.Legend = "Legend1";
            series6.LegendText = "Temp 4";
            series6.Name = "Series_Temp4Data";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.Lime;
            series7.Legend = "Legend1";
            series7.LegendText = "Temp (f)";
            series7.Name = "Series_TempFreqData";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_Temps.Series.Add(series3);
            this.chart_Temps.Series.Add(series4);
            this.chart_Temps.Series.Add(series5);
            this.chart_Temps.Series.Add(series6);
            this.chart_Temps.Series.Add(series7);
            this.chart_Temps.Size = new System.Drawing.Size(632, 300);
            this.chart_Temps.TabIndex = 36;
            this.chart_Temps.Text = "Temperatures";
            title2.Name = "Title1";
            title2.Text = "Temperature";
            this.chart_Temps.Titles.Add(title2);
            // 
            // button_SaveData
            // 
            this.button_SaveData.Location = new System.Drawing.Point(393, 2);
            this.button_SaveData.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveData.Name = "button_SaveData";
            this.button_SaveData.Size = new System.Drawing.Size(162, 37);
            this.button_SaveData.TabIndex = 55;
            this.button_SaveData.Text = "Save Plot Data";
            this.button_SaveData.UseVisualStyleBackColor = true;
            this.button_SaveData.Click += new System.EventHandler(this.button_SaveData_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(2, 0);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Messages";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temp1,
            this.Temp2,
            this.TempF,
            this.Freq,
            this.Power});
            this.dataGridView_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Data.Location = new System.Drawing.Point(2, 2);
            this.dataGridView_Data.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.RowHeadersVisible = false;
            this.dataGridView_Data.RowHeadersWidth = 62;
            this.dataGridView_Data.RowTemplate.Height = 28;
            this.dataGridView_Data.Size = new System.Drawing.Size(668, 385);
            this.dataGridView_Data.TabIndex = 34;
            // 
            // Temp1
            // 
            this.Temp1.HeaderText = "Temp1, C";
            this.Temp1.MinimumWidth = 8;
            this.Temp1.Name = "Temp1";
            this.Temp1.Width = 75;
            // 
            // Temp2
            // 
            this.Temp2.HeaderText = "Temp2, C";
            this.Temp2.MinimumWidth = 8;
            this.Temp2.Name = "Temp2";
            this.Temp2.Width = 75;
            // 
            // TempF
            // 
            this.TempF.HeaderText = "Temp(f), C";
            this.TempF.MinimumWidth = 8;
            this.TempF.Name = "TempF";
            this.TempF.Width = 75;
            // 
            // Freq
            // 
            this.Freq.HeaderText = "Freq, Hz";
            this.Freq.MinimumWidth = 8;
            this.Freq.Name = "Freq";
            // 
            // Power
            // 
            this.Power.HeaderText = "Power, W";
            this.Power.MinimumWidth = 8;
            this.Power.Name = "Power";
            this.Power.Width = 75;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_COM);
            this.flowLayoutPanel1.Controls.Add(this.comboBox_ComPortsList);
            this.flowLayoutPanel1.Controls.Add(this.button_ConnectCOM);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1863, 32);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // flowLayoutDataTable
            // 
            this.flowLayoutDataTable.Controls.Add(this.dataGridView_Data);
            this.flowLayoutDataTable.Controls.Add(this.groupBoxKprtCalibration);
            this.flowLayoutDataTable.Controls.Add(this.flowLayoutTableButtons);
            this.flowLayoutDataTable.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutDataTable.Controls.Add(this.richTextBox_Messages);
            this.flowLayoutDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDataTable.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutDataTable.Location = new System.Drawing.Point(1187, 3);
            this.flowLayoutDataTable.Name = "flowLayoutDataTable";
            this.flowLayoutDataTable.Size = new System.Drawing.Size(673, 809);
            this.flowLayoutDataTable.TabIndex = 61;
            this.flowLayoutDataTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutDataTable_Paint);
            // 
            // flowLayoutTableButtons
            // 
            this.flowLayoutTableButtons.AutoSize = true;
            this.flowLayoutTableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutTableButtons.Controls.Add(this.button_ClearTable);
            this.flowLayoutTableButtons.Controls.Add(this.button_AddData);
            this.flowLayoutTableButtons.Controls.Add(this.button_SaveTable);
            this.flowLayoutTableButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutTableButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutTableButtons.Location = new System.Drawing.Point(3, 473);
            this.flowLayoutTableButtons.Name = "flowLayoutTableButtons";
            this.flowLayoutTableButtons.Size = new System.Drawing.Size(666, 46);
            this.flowLayoutTableButtons.TabIndex = 60;
            // 
            // button_ClearTable
            // 
            this.button_ClearTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearTable.Location = new System.Drawing.Point(583, 3);
            this.button_ClearTable.Name = "button_ClearTable";
            this.button_ClearTable.Size = new System.Drawing.Size(80, 40);
            this.button_ClearTable.TabIndex = 59;
            this.button_ClearTable.Text = "Clear";
            this.button_ClearTable.UseVisualStyleBackColor = true;
            this.button_ClearTable.Click += new System.EventHandler(this.button_ClearTable_Click);
            // 
            // button_AddData
            // 
            this.button_AddData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddData.Location = new System.Drawing.Point(460, 3);
            this.button_AddData.Name = "button_AddData";
            this.button_AddData.Size = new System.Drawing.Size(117, 40);
            this.button_AddData.TabIndex = 57;
            this.button_AddData.Text = "Add To Table";
            this.button_AddData.UseVisualStyleBackColor = true;
            this.button_AddData.Click += new System.EventHandler(this.button_AddData_Click);
            // 
            // button_SaveTable
            // 
            this.button_SaveTable.Location = new System.Drawing.Point(306, 2);
            this.button_SaveTable.Margin = new System.Windows.Forms.Padding(2);
            this.button_SaveTable.Name = "button_SaveTable";
            this.button_SaveTable.Size = new System.Drawing.Size(149, 42);
            this.button_SaveTable.TabIndex = 58;
            this.button_SaveTable.Text = "Save Table";
            this.button_SaveTable.UseVisualStyleBackColor = true;
            this.button_SaveTable.Click += new System.EventHandler(this.button_SaveTable_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label25);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 525);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(666, 13);
            this.flowLayoutPanel2.TabIndex = 62;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label31);
            this.flowLayoutPanel3.Controls.Add(this.checkBox_PlotTemp1);
            this.flowLayoutPanel3.Controls.Add(this.checkBox_PlotTemp2);
            this.flowLayoutPanel3.Controls.Add(this.checkBox_PlotTemp3);
            this.flowLayoutPanel3.Controls.Add(this.checkBox_PlotTemp4);
            this.flowLayoutPanel3.Controls.Add(this.checkBox_PlotTempFreq);
            this.flowLayoutPanel3.Controls.Add(this.button_SaveData);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 309);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(576, 39);
            this.flowLayoutPanel3.TabIndex = 62;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.chart_Temps);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Controls.Add(this.chart_Freq);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel4.Controls.Add(this.button_ResetPlots);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(546, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(635, 809);
            this.flowLayoutPanel4.TabIndex = 63;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label40);
            this.flowLayoutPanel5.Controls.Add(this.checkBox_PlotFreq);
            this.flowLayoutPanel5.Controls.Add(this.checkBox_PlotDeriv);
            this.flowLayoutPanel5.Controls.Add(this.label38);
            this.flowLayoutPanel5.Controls.Add(this.numericUpDown_DerNumber);
            this.flowLayoutPanel5.Controls.Add(this.numericUpDown_FilterBand);
            this.flowLayoutPanel5.Controls.Add(this.checkBox_PeakFilter);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 646);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(806, 37);
            this.flowLayoutPanel5.TabIndex = 64;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label41);
            this.flowLayoutPanel7.Controls.Add(this.numericUpDown_FreqMeas2);
            this.flowLayoutPanel7.Controls.Add(this.label42);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 689);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(806, 31);
            this.flowLayoutPanel7.TabIndex = 64;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label37);
            this.flowLayoutPanel6.Controls.Add(this.numericUpDown_TimeInterval);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 726);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(190, 27);
            this.flowLayoutPanel6.TabIndex = 64;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.groupBox_PierceStat, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutDataTable, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1863, 815);
            this.tableLayoutPanel4.TabIndex = 64;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 871);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_MainWindow";
            this.Text = "PierceStat Ver1.2a";
            this.Load += new System.EventHandler(this.Form_MainWindow_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_PierceStat.ResumeLayout(false);
            this.groupBox_PierceStat.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_Channel2.ResumeLayout(false);
            this.groupBox_Channel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet2)).EndInit();
            this.groupBox_Temp2.ResumeLayout(false);
            this.groupBox_Temp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp2)).EndInit();
            this.groupBox_Freq2.ResumeLayout(false);
            this.groupBox_Freq2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq2)).EndInit();
            this.groupBox_Channel1.ResumeLayout(false);
            this.groupBox_Channel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ISet1)).EndInit();
            this.groupBox_Temp1.ResumeLayout(false);
            this.groupBox_Temp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ITemp1)).EndInit();
            this.groupBox_Freq1.ResumeLayout(false);
            this.groupBox_Freq1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPointFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PFreq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IFreq1)).EndInit();
            this.groupBox_ChannelsMode.ResumeLayout(false);
            this.groupBox_ChannelsMode.PerformLayout();
            this.groupBox_Meas.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh1Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentCh2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Meas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmCurrentCh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AlarmU_Heater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FilterBand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FreqMeas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeInterval)).EndInit();
            this.groupBoxKprtCalibration.ResumeLayout(false);
            this.groupBoxKprtCalibration.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_freqOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AwaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DeltaF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_KprtValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstartKprt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TstopKprt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPointsKprt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutDataTable.ResumeLayout(false);
            this.flowLayoutDataTable.PerformLayout();
            this.flowLayoutTableButtons.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ComPortsList;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_ConnectCOM;
        private ToolStripMenuItem updateCOMPortsToolStripMenuItem;
        private RichTextBox richTextBox_Messages;
        private GroupBox groupBox_PierceStat;
        private CheckBox checkBox_U_HeaterEnable;
        private Label label_U_Heater;
        private Label label_U_Power;
        private NumericUpDown numericUpDown_U_PowerMeas;
        private NumericUpDown numericUpDown_U_HeaterMeas;
        private GroupBox groupBox_Channel1;
        private ComboBox comboBox_Source1;
        private Label label_Source1;
        private ComboBox comboBox_Mode1;
        private Label label_Mode1;
        private ComboBox comboBox_Load1;
        private Label label_Load1;
        private NumericUpDown numericUpDown_DTemp1;
        private NumericUpDown numericUpDown_ITemp1;
        private NumericUpDown numericUpDown_PTemp1;
        private Label label_DTemp1;
        private Label label_ITemp1;
        private Label label_PTemp1;
        private NumericUpDown numericUpDown_SetPointTemp1;
        private Label label_SetPointTemp;
        private Label label_SetPointFreq;
        private NumericUpDown numericUpDown_DFreq1;
        private NumericUpDown numericUpDown_IFreq1;
        private NumericUpDown numericUpDown_PFreq1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown_SetPointFreq1;
        private Label label_CurrentCh1;
        private NumericUpDown numericUpDown_CurrentCh1Meas;
        private Button button_EnableCh1;
        private GroupBox groupBox_Channel2;
        private GroupBox groupBox_Temp2;
        private NumericUpDown numericUpDown_SetPointTemp2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown_PTemp2;
        private NumericUpDown numericUpDown_DTemp2;
        private NumericUpDown numericUpDown_ITemp2;
        private GroupBox groupBox_Freq2;
        private NumericUpDown numericUpDown_SetPointFreq2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown_DFreq2;
        private NumericUpDown numericUpDown_PFreq2;
        private NumericUpDown numericUpDown_IFreq2;
        private Button button_EnableCh2;
        private ComboBox comboBox_Source2;
        private Label label13;
        private ComboBox comboBox_Mode2;
        private Label label14;
        private ComboBox comboBox_Load2;
        private Label label15;
        private GroupBox groupBox_Temp1;
        private GroupBox groupBox_Freq1;
        private Label label4;
        private GroupBox groupBox_Meas;
        private NumericUpDown numericUpDown_Temp1Meas;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private NumericUpDown numericUpDown_Temp4Meas;
        private NumericUpDown numericUpDown_Temp3Meas;
        private NumericUpDown numericUpDown_Temp2Meas;
        private NumericUpDown numericUpDown_U_HeaterSet;
        private Label label21;
        private NumericUpDown numericUpDown_CurrentCh2Meas;
        private Label label20;
        private NumericUpDown numericUpDown_CurrentCh2Max;
        private NumericUpDown numericUpDown_CurrentCh1Max;
        private Label label23;
        private Label label22;
        private NumericUpDown numericUpDown_U_PowerMax;
        private NumericUpDown numericUpDown_U_PowerMin;
        private NumericUpDown numericUpDown_U_HeaterMax;
        private NumericUpDown numericUpDown_U_HeaterMin;
        private PictureBox pictureBox_AlarmCurrentCh1;
        private NumericUpDown numericUpDown_Temp4Max;
        private NumericUpDown numericUpDown_Temp3Max;
        private NumericUpDown numericUpDown_Temp2Max;
        private NumericUpDown numericUpDown_Temp1Max;
        private NumericUpDown numericUpDown_Temp4Min;
        private NumericUpDown numericUpDown_Temp3Min;
        private NumericUpDown numericUpDown_Temp2Min;
        private NumericUpDown numericUpDown_Temp1Min;
        private PictureBox pictureBox_AlarmU_Heater;
        private PictureBox pictureBox_AlarmU_Power;
        private PictureBox pictureBox_AlarmCurrentCh2;
        private CheckBox checkBox_AlarmCurrentCh1Masked;
        private CheckBox checkBox_AlarmTemp4Masked;
        private CheckBox checkBox_AlarmTemp3Masked;
        private CheckBox checkBox_AlarmTemp2Masked;
        private CheckBox checkBox_AlarmTemp1Masked;
        private CheckBox checkBox_AlarmU_HeaterMasked;
        private CheckBox checkBox_AlarmU_PowerMasked;
        private CheckBox checkBox_AlarmCurrentCh2Masked;
        private Label label24;
        private PictureBox pictureBox_AlarmTemp4;
        private PictureBox pictureBox_AlarmTemp3;
        private PictureBox pictureBox_AlarmTemp2;
        private PictureBox pictureBox_AlarmTemp1;
        private Label label25;
        private NumericUpDown numericUpDown_FreqMax;
        private NumericUpDown numericUpDown_FreqMin;
        private NumericUpDown numericUpDown_FreqMeas;
        private Label label26;
        private CheckBox checkBox_AlarmFreqMasked;
        private PictureBox pictureBox_AlarmFreq;
        private Button button_SaveFlash;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label label28;
        private Label label27;
        private CheckBox checkBox_Polarity2;
        private CheckBox checkBox_Polarity1;
        private Label label30;
        private NumericUpDown numericUpDown_ISet2;
        private NumericUpDown numericUpDown_ISet1;
        private Label label29;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Freq;
        private Label label31;
        private CheckBox checkBox_PlotTempFreq;
        private CheckBox checkBox_PlotTemp4;
        private CheckBox checkBox_PlotTemp3;
        private CheckBox checkBox_PlotTemp2;
        private CheckBox checkBox_PlotTemp1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label32;
        private Button button_ResetPlots;
        private GroupBox groupBox_ChannelsMode;
        private RadioButton radioButton_ModeDependent;
        private RadioButton radioButton_ModeIndependent;
        private Label label33;
        private NumericUpDown numericUpDown_TstartKprt;
        private GroupBox groupBoxKprtCalibration;
        private NumericUpDown numericUpDown_NumPointsKprt;
        private Label label35;
        private NumericUpDown numericUpDown_TstopKprt;
        private Label label34;
        private NumericUpDown numericUpDown_KprtValue;
        private Label label36;
        private Button button_CalibrateKprt;
        private NumericUpDown numericUpDown_TimeInterval;
        private Label label37;
        private NumericUpDown numericUpDown_DerNumber;
        private Label label38;
        private Label label39;
        private NumericUpDown numericUpDown_freqOffset;
        private Timer timer1;
        private Button button_SaveData;
        private CheckBox checkBox_PlotDeriv;
        private CheckBox checkBox_PlotFreq;
        private Label label40;
        private Label label42;
        private Label label41;
        private NumericUpDown numericUpDown_FreqMeas2;
        private Label label44;
        private Label label43;
        private NumericUpDown numericUpDown_FilterBand;
        private CheckBox checkBox_PeakFilter;
        private NumericUpDown numericUpDown_AwaitTime;
        private NumericUpDown numericUpDown_DeltaF;
        private Label label46;
        private Label label45;
        private DataGridView dataGridView_Data;
        private DataGridViewTextBoxColumn Temp1;
        private DataGridViewTextBoxColumn Temp2;
        private DataGridViewTextBoxColumn TempF;
        private DataGridViewTextBoxColumn Freq;
        private DataGridViewTextBoxColumn Power;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutDataTable;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutTableButtons;
        private Button button_ClearTable;
        private Button button_AddData;
        private Button button_SaveTable;
        private FlowLayoutPanel flowLayoutPanel8;
    }

}



